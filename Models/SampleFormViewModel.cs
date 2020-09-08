using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Week6.Models
{
    public class SampleFormViewModel
    {
       
    }

    public class FormOneViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Display(Name = "First Name")]

        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}