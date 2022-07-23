using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace leave_management.Models
{
    public class LeaveAllocationVm
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }
        public EmployeeVm Employee { get; set; }
        public string EmployeeId { get; set; }
        public LeaveTypeVm LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

    }

    public class CreateLeaveAllocationVm
    {
        public int NumberUpdated { get; set; }
        public List<LeaveTypeVm> LeaveTypes { get; set; }
    }

    public class ViewAllocationsVM
    {
        public EmployeeVm Employee { get; set; }

        public List<LeaveAllocationVm> LeaveAllocations { get; set; }
    }

    public class EditLeaveAllocationVm
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public EmployeeVm Employee { get; set; }
        [Display(Name ="Number of Days")]
        public int NumberOfDays { get; set; }
        public LeaveTypeVm LeaveType { get; set; }
    }
}
