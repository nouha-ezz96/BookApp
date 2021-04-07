using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Controllers
{
    public class BillboardController : Controller
    {
        public string GetBillboards()
        {
            return "All Ad Billboard";
        }
        public string GetBillboard(int id)
        {
            return $"Add One Billboard with id ={id}";
        }
        public string SearchBillboard(string billboardName, string billboardOwner)
        {
            return $"Add Billboard titled: {billboardName} setted by {billboardOwner}";
        }
    }
}
