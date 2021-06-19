using AEIMapMobile.DAL.Entities;
using AEIMapMobile.DAL.Interfaces;
using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Services
{
    public class PathService : IPathService
    {
        private readonly IPathPointRepository pathPointRepository;
        private readonly IFloorRepository floorRepository;
        private readonly IRoomRepository roomRepository;
        private readonly IMapper mapper;

        public PathService(IPathPointRepository pathPointRepository, IFloorRepository floorRepository, IRoomRepository roomRepository, IMapper mapper)
        {
            this.pathPointRepository = pathPointRepository;
            this.floorRepository = floorRepository;
            this.roomRepository = roomRepository;

            this.mapper = mapper;
        }

        public async Task<PathDto> GetPathAsync(PathRequestDto model)
        {
            var startRoom = await roomRepository.FindByNumberWithDetailsAsync(model.StartRoomNumber);
            var endRoom = await roomRepository.FindByNumberWithDetailsAsync(model.EndRoomNumber);

            var startFloor = await floorRepository.FindByIdWithDetailsAsync(startRoom.FloorId);
            var endFloor = await floorRepository.FindByIdWithDetailsAsync(endRoom.FloorId);

            var startPathPoints = await pathPointRepository.FindByFloorIdAsync(startFloor.Id);
            var endPathPoints = await pathPointRepository.FindByFloorIdAsync(endFloor.Id);

            var selectedPoints = new List<IEnumerable<PathPoint>>();


            if (CheckSectorConnection(startFloor, startRoom.ExitPoint.SectorId, endRoom.ExitPoint.SectorId))
            {
                if (startFloor.Id == endFloor.Id)
                {
                    selectedPoints.Add(FindPath(startPathPoints, startRoom.ExitPoint, endRoom.ExitPoint));

                    return mapper.Map<PathDto>(selectedPoints);
                }
                else
                {
                    var exitPoint = startFloor.PathPoints.FirstOrDefault(e => e.IsExitPoint && e.SectorId == endRoom.ExitPoint.SectorId);

                    selectedPoints.Add(FindPath(startPathPoints, startRoom.ExitPoint, exitPoint));
                }
            }
            else
            {
                var exitPoint = startFloor.PathPoints.FirstOrDefault(e => e.IsExitPoint && e.SectorId == startRoom.ExitPoint.SectorId);

                selectedPoints.Add(FindPath(startPathPoints, startRoom.ExitPoint, exitPoint));


                Floor additionalFloor;
                if (startFloor.Number > 0)
                {
                    additionalFloor = await floorRepository.FindByNumberWithDetailsAsync(startFloor.Number - 1);
                }
                else
                {
                    additionalFloor = await floorRepository.FindByNumberWithDetailsAsync(startFloor.Number + 1);
                }

                var additionalPathPoints = await pathPointRepository.FindByFloorIdAsync(additionalFloor.Id);
                var additionalStartPoints = additionalPathPoints.FirstOrDefault(e => e.SectorId == startRoom.ExitPoint.SectorId && e.IsExitPoint);
                var additionalEndPoints = additionalPathPoints.FirstOrDefault(e => e.SectorId == endRoom.ExitPoint.SectorId && e.IsExitPoint);

                selectedPoints.Add(FindPath(additionalPathPoints, additionalStartPoints, additionalEndPoints));
            }

            var startPoint = endFloor.PathPoints.FirstOrDefault(e => e.IsExitPoint && e.SectorId == endRoom.ExitPoint.SectorId);

            selectedPoints.Add(FindPath(endPathPoints, startPoint, endRoom.ExitPoint));

            return mapper.Map<PathDto>(selectedPoints);
        }

        private List<PathPoint> FindPath(IEnumerable<PathPoint> pathPoints, PathPoint startPoint, PathPoint endPoint, List<PathPoint> selectedPoints = null)
        {
            if (selectedPoints == null)
            {
                selectedPoints = new List<PathPoint>();
            }

            selectedPoints.Add(startPoint);

            foreach (var nextPoint in startPoint.SourcePathPoints)
            {
                if (selectedPoints.All(e => e.Id != nextPoint.NextPointId))
                {
                    var currentPoint = pathPoints.FirstOrDefault(e => e.Id == nextPoint.NextPointId);

                    if (currentPoint.Id == endPoint.Id)
                    {
                        selectedPoints.Add(currentPoint);
                        return selectedPoints;
                    }

                    var path = FindPath(pathPoints, currentPoint, endPoint, selectedPoints);
                    if (path != null)
                    {
                        return path;
                    }
                    else
                    {
                        selectedPoints.Remove(currentPoint);
                    }
                }
            }
            return null;
        }

        private bool CheckSectorConnection(Floor floor, int Sector1Id, int Sector2Id)
        {
            if (Sector1Id == Sector2Id)
            {
                return true;
            }

            foreach (var sectorConnection in floor.SectorConnections)
            {
                if (sectorConnection.Sector1Id == Sector1Id && sectorConnection.Sector2Id == Sector2Id ||
                    sectorConnection.Sector1Id == Sector2Id && sectorConnection.Sector2Id == Sector1Id)
                {
                    return true;
                }
            }
            return false;
        }  
    }
}
