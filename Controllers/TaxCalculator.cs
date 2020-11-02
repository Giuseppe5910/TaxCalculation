using TaxCalculatorGlobalBlue.Models;

namespace TaxCalculatorGlobalBlue.Controllers
{
    public class TaxCalculator
    {
        private ITaxCalculator _tc;
        public TaxInput getGrossTotal(ITaxCalculator serv,TaxInput ti)
        {
            this._tc = serv;
            return this._tc.GetGrossTotal(ti);
        }
        public TaxInput getNetGross(ITaxCalculator serv, TaxInput ti)
        {
            this._tc = serv;
            return this._tc.GetNetGross(ti);
        }
        public TaxInput getTotalNet(ITaxCalculator serv, TaxInput ti)
        {
            this._tc = serv;
            return this._tc.GetTotalNet(ti);
        }
    }
}
