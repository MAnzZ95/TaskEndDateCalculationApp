using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Model
{
    public class Holyday
    {
        //According to the Task I only consider about holy day lets that's why I include date field only
        [Required]
        public string hDate { get; set; }
       
    }
}
