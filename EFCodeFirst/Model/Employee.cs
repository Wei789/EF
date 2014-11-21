using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EFDemo1.Model
{
    class Employee
    {
        [Key]
        public int empNo { get; set; }
        [MaxLength(10)]
        public string empName { get; set; }

        public int depId { get; set; }
        public virtual Department department { get; set; }
    }
}
