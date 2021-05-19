﻿using AEIMapMobile.DAL.Entities;
using AEIMapMobile.Services.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Mapper.Profiles
{
    public class FilterValueProfile : Profile
    {
        public FilterValueProfile()
        {
            CreateMap<FilterValue, FilterValueDto>();
        }
    }
}
