using AutoMapper;
using RobotArena.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotArena.Tests.Mocks
{
    public static class MockAutoMapper
    {
        static MockAutoMapper()
        {
            Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());
        }

        public static IMapper GetAutoMapper() => Mapper.Instance;
    }
}
