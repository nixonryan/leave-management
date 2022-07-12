﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace leave_management.Models
{
    public class LeaveHistoryVm
    {
        public int Id { get; set; }
        public EmployeeVm RequestingEmployee { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

        public string RequestingEmployeeId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public LeaveTypeVm LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public EmployeeVm ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }
}
