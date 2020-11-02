using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using TaxCalculatorGlobalBlue.Models;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using Microsoft.Ajax.Utilities;

namespace TaxCalculatorGlobalBlue.Controllers
{
    public class HomeController : Controller
    {
        private TaxDBContext _context;
        public HomeController()
        {
            _context = new TaxDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculate([Bind(Exclude ="Id")]TaxInput info)
        {
            /*ModelState.Remove("Gross");
            ModelState.Remove("Net");
            ModelState.Remove("Total");*/
            /*if ((info.Gross == info.Net) && (info.Net== info.Total) && (info.Total == info.Gross) && info.Gross==null)
            {
                return View("Index", info);
            }*/
            if (!ModelState.IsValid)
            {
                return View("Index", info);
            }
            TaxCalculator taxCalculator = new TaxCalculator();
            TaxInput outCome = new TaxInput();
            if (info.Gross > 0)
            {
                info.Net = 0;
                info.Total = 0;
                outCome = taxCalculator.getTotalNet(new TaxCalculatorServ(), info);
            }
            else if (info.Net > 0)
            {
                info.Total = 0;
                info.Gross = 0;
                outCome = taxCalculator.getGrossTotal(new TaxCalculatorServ(), info);
            }
            else if(info.Total>0)
            {
                info.Net = 0;
                info.Gross = 0;
                outCome = taxCalculator.getNetGross(new TaxCalculatorServ(), info);
            }
            
            _context.TaxInputs.Add(outCome);
            _context.SaveChanges();

            
            
            return View("Results",outCome);
        }
    }
}