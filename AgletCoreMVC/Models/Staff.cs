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
        public Departments Department;

        [Required]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal Salary;

        [Required]
        public JobTitles JobTitle;

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