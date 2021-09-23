using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {

        public IEnumerable<string> Get(int id)
        {
            /// <summary>
            /// Calculates total hosting costs by number of fortnights and adding tax
            /// <example>
            /// Get api/HostingCost/28 - >
            /// "3 fortnights at $5.50/FN = $16.50"
            /// "HST 13 % = $2.14 CAD"
            /// "Total = $18.64 CAD"
            /// </example>
            /// </summary>
            /// <param name="id">The number of days elapsed since the beginning of the hosting</param>
            /// <returns>3 strings that describe total hosting cost</returns>
            decimal price = 5.5m;
            int fortnight = (id / 14) + 1;
            decimal totalBeforeTax = Math.Round(fortnight * price, 2);
            decimal tax = Math.Round(totalBeforeTax * 0.13m, 2);
            decimal total = Math.Round(totalBeforeTax + tax, 2);
            return new string[] { 
                fortnight + " fortnights at $" + price.ToString("0.00") + "/FN = $" + totalBeforeTax.ToString("0.00"),
                "HST 13% = $" + tax.ToString("0.00") + " CAD", 
                "Total = $" + total.ToString("0.00") + " CAD"
            };
        }
    }
}
