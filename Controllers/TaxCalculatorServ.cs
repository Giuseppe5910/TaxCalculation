using System;
using TaxCalculatorGlobalBlue.Models;

namespace TaxCalculatorGlobalBlue.Controllers
{
    public class TaxCalculatorServ : ITaxCalculator
    {
        public TaxInput GetGrossTotal(TaxInput info)
        {
            info.Gross = (double)(info.Net * (info.VAT / 100));
            info.Total = info.Gross + info.Net;
            return info;
        }

        public TaxInput GetNetGross(TaxInput info)
        {
            info.Net = (double)(info.Total * (info.VAT / 100));
            info.Gross = info.Total - info.Net;
            return info;
        }

        public TaxInput GetTotalNet(TaxInput info)
        {
            info.Net = (double)(info.Gross * (100 / info.VAT));
            info.Total = info.Gross + info.Net;
            return info;
        }
    }
}
