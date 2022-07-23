using leave_management.Contracts;
using leave_management.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace leave_management.Repo
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public LeaveAllocationRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public bool CheckAllocation(int leaveTypeId, string employeeId)
        {
            var period = DateTime.Now.Year;
            return FindAll()
                .Where(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId && q.Period == period)
                .Any();
        }

        public bool Create(LeaveAllocation entity)
        {
            _dbcontext.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _dbcontext.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            return _dbcontext.LeaveAllocations.Include(q => q.LeaveType)
                                                .Include(q => q.LeaveType)
                                               .ToList();
        }

        public LeaveAllocation FindById(int id)
        {
            return _dbcontext.LeaveAllocations
                                        .Include(q => q.Employee)
                                        .Include(q => q.LeaveType)
                                        .FirstOrDefault(q => q.Id == id);
        }

        public ICollection<LeaveAllocation> GetLeaveAllocationByEmployee(string id)
        {
            var period = DateTime.Now.Year;
            return FindAll().Where(q => q.EmployeeId == id && q.Period == period).ToList();
        }

        public bool IsExists(int id)
        {
            var exists = _dbcontext.LeaveAllocations.Any(x => x.Id == id);
            return exists;
        }

        public bool Save()
        {
            return _dbcontext.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _dbcontext.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}
