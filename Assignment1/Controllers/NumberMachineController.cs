using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Takes the input number, squares itself, times 5, plus 2 and minus 6
        /// <example>Get api/NumberMachine/10 - > 496</example>
        /// </summary>
        /// <param name="id">The input number to be processed</param>
        /// <returns>Square of the input number multiplied by 5, then plus 2 and minus 6</returns>
        public int Get(int id)
        {
            return ((id * id) * 5) + 2 - 6;
        }
    }
}
