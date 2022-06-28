using AutoMapper;
using leave_management.Data;
using leave_management.Models;

namespace leave_management.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Employee, EmployeeVm>().ReverseMap();
            CreateMap<LeaveType, DetailsLeaveTypeVm>().ReverseMap();
            CreateMap<Employee, CreateLeaveTypeVm>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVm>().ReverseMap();
        }
    }
}
