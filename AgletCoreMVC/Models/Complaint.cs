using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgletCoreMVC.Models
{
    public class Complaint
    {
        public int ComplaintID { get; set; }

        [Required, StringLength(30)]
        public string Title { get; set; }

        [Required, StringLength(300)]
        public string Body { get; set; }
        public string ImageUrl { get; set; }


    }
}
