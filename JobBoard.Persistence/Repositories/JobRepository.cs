﻿using JobBoard.Core.Models;
using JobBoard.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.Persistence.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly JobBoardContext _context;

        public JobRepository(JobBoardContext context)
        {
            _context = context;
        }

        public async Task<Job> GetJob(long id)
        {
            var job = await _context.Jobs
                .Include(j => j.Country)
                .Include(j => j.State)
                .Include(j => j.EmploymentType)
                .Include(j => j.SalaryType)
                .Include(j => j.Category)
                .Include(j => j.JobBoard)
                .Include(j => j.JobOccupations)
                .ThenInclude(e => e.Occupation)
                .FirstOrDefaultAsync(j => j.Id == id);

            return job;

        }

        public async Task<IEnumerable<Job>> GetJobs()
        {
            var jobs = await _context.Jobs
                .Include(j => j.Country)
                .Include(j => j.State)
                .Include(j => j.EmploymentType)
                .Include(j => j.SalaryType)
                .Include(j => j.Category)
                .Include(j => j.JobBoard)
                .Include(j => j.JobOccupations)
                .ThenInclude(e => e.Occupation)
                .ToListAsync();

            return jobs;
        }

        public void Add(Job job)
        {
            _context.Jobs.Add(job);
            _context.ChangeTracker.DetectChanges();
        }
    }
}
