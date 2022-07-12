using leave_management.Contracts;
using leave_management.Data;
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
            return _dbcontext.LeaveAllocations.ToList();
        }

        public LeaveAllocation FindById(int id)
        {
            return _dbcontext.LeaveAllocations.Find(id);
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
