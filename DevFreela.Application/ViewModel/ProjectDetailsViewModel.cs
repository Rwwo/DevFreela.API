﻿using System;

namespace DevFreela.Application.ViewModel
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, string description
            , decimal totalCost, DateTime? createdAt, DateTime? finishedAt
            , string clientFullName, string freelanceFullName)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCost = totalCost;
            StartedAt = createdAt;
            FinishedAt = finishedAt;
            FreelanceFullName = freelanceFullName;
            ClientFullName = clientFullName;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ClientFullName { get; private set; }
        public string FreelanceFullName { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
    }
}
