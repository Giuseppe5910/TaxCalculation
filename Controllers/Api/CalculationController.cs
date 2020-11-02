using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaxCalculatorGlobalBlue.Models;

namespace TaxCalculatorGlobalBlue.Controllers
{
    public class CalculationController : ApiController
    {
        private TaxDBContext _context;

        public CalculationController()
        {
            _context = new TaxDBContext();
        }

        //GET /api/calculation/1
        public IHttpActionResult GetCalculation (int id)
        {
            var tax = _context.TaxInputs.SingleOrDefault(t => t.Id == id);

            if (tax == null)
            {
                return BadRequest();
            }
            else
                return Created(new Uri(Request.RequestUri+"/"+tax.Id), tax);
        }
    }
}
