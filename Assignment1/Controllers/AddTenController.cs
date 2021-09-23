using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds 10 to the input number
        /// <example>Get api/AddTen/21 - > 31</example>
        /// </summary>
        /// <param name="id">The input number to add to</param>
        /// <returns>The input number plus 10</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
