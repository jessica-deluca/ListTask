using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListTask.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        [Display(Name ="Task Description")]
        public string TaskDescription { get; set; }
        [Display(Name = "Task Complete")]
        public bool TaskIsDone { get; set; }
        [Display(Name = "Task Due Date")]
        public DateTime TaskDueDate { get; set; }

        [ForeignKey("List")]
        public int ListID { get; set; }
        public virtual List List { get; set; }
}
}