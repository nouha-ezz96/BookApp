using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class BillboardModel
    {
        public int Id { get; set; }

        public string BillboardName { get; set; }
        public string BillboardOwner { get; set; }
    }
}
