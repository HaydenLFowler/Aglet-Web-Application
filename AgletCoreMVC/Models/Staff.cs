using System;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Hayden
/// </summary>
namespace AgletCoreMVC.Models
{
    public class Staff
    {
        public int StaffID { get; set; }

        [Required]
        public Departments Department { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public string Salary { get; set; }

        [Required]
        public JobTitles JobTitle { get; set; }

        // Navigation
        public virtual User UserID {get; set;}

        public enum Departments
        {
            HQ,
            HR,
            Sales,
            Finance,
            Support
        }

        public enum JobTitles
        {
            Supervisor,
            Manager,
            SalesStaff,
            Accountant,
            CustomerAssistant
        }
    }
}