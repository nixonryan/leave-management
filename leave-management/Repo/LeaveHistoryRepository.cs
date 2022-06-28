using leave_management.Contracts;
using leave_management.Data;
using System.Collections.Generic;
using System.Linq;

namespace leave_management.Repo
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public LeaveHistoryRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public bool Create(LeaveHistory entity)
        {
            _dbcontext.LeaveHistory.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _dbcontext.LeaveHistory.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            return _dbcontext.LeaveHistory.ToList();
        }

        public LeaveHistory FindById(int id)
        {
            return _dbcontext.LeaveHistory.Find(id);
        }

        public bool Save()
        {
            return _dbcontext.SaveChanges() > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _dbcontext.LeaveHistory.Update(entity);
            return Save();
        }
    }
}
