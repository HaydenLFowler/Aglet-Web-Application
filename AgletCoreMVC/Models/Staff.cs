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

        public Departments Department { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal Salary { get; set; }

        public JobTitles JobTitle { get; set; }

        // Navigation

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