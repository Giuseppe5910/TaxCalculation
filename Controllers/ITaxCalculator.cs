using TaxCalculatorGlobalBlue.Models;

namespace TaxCalculatorGlobalBlue.Controllers
{
    public interface ITaxCalculator
    {
        TaxInput GetNetGross(TaxInput info);
        TaxInput GetGrossTotal(TaxInput info);
        TaxInput GetTotalNet(TaxInput info);
    }
}
