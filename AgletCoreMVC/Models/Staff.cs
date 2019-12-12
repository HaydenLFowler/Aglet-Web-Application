using System;
/// <summary>
/// Hew
/// </summary>
namespace AgletCoreMVC.Models
{
    public class Staff
    {
        public int StaffID { get; set; }

        public Departments Department;

        public decimal Salary;

        public JobTitles JobTitle;

        // Navigation
	    public virtual User UserID {get; set;}

        public enum Departments
        {
            HQ,
            HR
        }

        public enum JobTitles
        {
            Supervisor,
            Manager
        }
    }
}