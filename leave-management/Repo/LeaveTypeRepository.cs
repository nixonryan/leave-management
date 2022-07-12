using leave_management.Contracts;
using leave_management.Data;
using System.Collections.Generic;
using System.Linq;

namespace leave_management.Repo
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public LeaveTypeRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public bool Create(LeaveType entity)
        {
            _dbcontext.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _dbcontext.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            return _dbcontext.LeaveTypes.ToList();
        }

        public LeaveType FindById(int id)
        {
            return _dbcontext.LeaveTypes.FirstOrDefault(x => x.Id == id);
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int Id)
        {
            throw new System.NotImplementedException();
        }

        public bool IsExists(int id)
        {
            var exists = _dbcontext.LeaveTypes.Any(x => x.Id == id);
            return exists;
        }

        public bool Save()
        {
            return _dbcontext.SaveChanges() > 0;
        }

        public bool Update(LeaveType entity)
        {
            _dbcontext.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
