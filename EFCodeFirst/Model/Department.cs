using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EFDemo1.Model
{
    class Department
    {
        [Key]
        public int depId { get; set; }
        public string depName { get; set; }

        public virtual List<Employee> employee { get; set; }
        //virtual : 這會啟用 Entity Framework 的「Lazy Load」功能
    }
}
