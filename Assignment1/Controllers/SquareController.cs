using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Squares the input number
        /// <example>Get api/Square/2 - > 4</example>
        /// </summary>
        /// <param name="id">The input number to be squared</param>
        /// <returns>Square of the input number</returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
