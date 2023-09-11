﻿using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CreateProject
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, int>
    {
        //private readonly DevFreelaDbContext _dbContext;
        //public CreateProjectCommandHandler(DevFreelaDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        private readonly IProjectRepository _projectRepository;
        public CreateProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new Project(request.Title, request.Description, request.IdClient
                , request.IdFreelancer, request.TotalCost);

            await _projectRepository.AddAsync(project);

            return project.Id;
        }
    }
}