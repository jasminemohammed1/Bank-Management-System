using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GNET14_EF03_EF04.models
{
    internal class Manager
    {
        public int Id { get; set; }
        public string ?Email { get; set; }
        public string FullName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;

        public DateTime HireDate { get; set; }
        public Branch ManagedBranch { get; set; }

    }
}
