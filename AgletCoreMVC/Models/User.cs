using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Depending on whether or not the user is a customer or 
/// staff, the information they are prompted to supply will vary. 
/// A customer will be asked to provide their address and 
/// payment card, whereas a staff member doesn't need to provide this 
/// information unless they decide to also be a customer.
/// - Hayden
/// </summary>
namespace AgletCoreMVC.Models
{
    public class User
    {
        public int UserID { get; set; }

        [StringLength(50)]
        public string MicrosoftID { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "First Name cannot be empty or exceed 20 characters.")]
        [Display(Name = "First Name")]       
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Surname cannot be empty or exceed 20 characters.")]
        public string Surname { get; set; }

        [Required]
        public Boolean IsStaff { get; set; }

        [Required]
        public Boolean IsCustomer { get; set; }


        //  Navigation Properties (relationships)

        public virtual Contact Contact { get; set; }

        public virtual PaymentCard PaymentCard { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Address Address { get; set; }


        public User()
        {
            IsCustomer = true;
            IsStaff = false;
        }


    }
}