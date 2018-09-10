using AutoMapper;
using RobotArena.Data;
using System;

namespace RobotArena.Services
{
    public abstract class BaseEFService
    {
        protected BaseEFService(
            RobotContext dbContext,
            IMapper mapper)
        {
            this.DbContext = dbContext;
            this.Mapper = mapper;
        }

        protected RobotContext DbContext { get; private set; }

        protected IMapper Mapper { get; private set; }
    }
}
