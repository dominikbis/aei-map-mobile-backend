using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Mapper.Configuration
{
    public class AutoMapperConfiguration : MapperConfiguration
    {
        public AutoMapperConfiguration(IEnumerable<Profile> profiles) : base(configuration =>
        {
            foreach (var profile in profiles)
                configuration.AddProfile(profile);
        }) { }
    }
}
