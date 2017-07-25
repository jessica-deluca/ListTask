using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ListTask.Models
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        [Display(Name = "List Title")]
        public string ListTitle { get; set; }
        [Display(Name = "List Created")]
        public DateTime ListCreateDate { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}