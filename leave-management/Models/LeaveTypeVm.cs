using System;
using System.ComponentModel.DataAnnotations;

namespace leave_management.Models
{
    public class DetailsLeaveTypeVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeVm
    {
        [Required]
        public string Name { get; set; }
    }
}
