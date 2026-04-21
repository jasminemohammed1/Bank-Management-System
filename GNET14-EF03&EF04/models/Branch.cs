using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET14_EF03_EF04.models
{
    internal class Branch
    {
        public int BranchCode { get; set; }
        public string Name { get; set; } = default!;

        public string PhoneNumber { get; set; } = default!;

        public string Address { get; set; } = default!;

        public Manager BranchManager { get; set; }

        public int ManagerId { get; set; }

        public  ICollection<Account> Accounts { get; set; } = new List <Account>();

    }
}
