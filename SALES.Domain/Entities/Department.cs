using System;
using System.Collections.Generic;

namespace SALES.Domain.Entities
{
    public partial class Department
    {
        public Department()
        {
            Provinces = new HashSet<Province>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public int State { get; set; }

        public virtual ICollection<Province> Provinces { get; set; }
    }
}
