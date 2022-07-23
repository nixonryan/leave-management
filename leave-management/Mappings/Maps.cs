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
            CreateMap<LeaveType, LeaveTypeVm>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVm>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVm>().ReverseMap();
            CreateMap<LeaveAllocation, EditLeaveAllocationVm>().ReverseMap();
        }
    }
}
