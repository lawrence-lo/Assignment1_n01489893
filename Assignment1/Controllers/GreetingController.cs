using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the string "Hello World!"
        /// <example>Post api/Greeting</example>
        /// </summary>
        /// <returns>"Hello World!"</returns>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Returns the string "Greetings to {id} people!"
        /// <example>Get api/Greeting/3 - > "Greetings to 3 people!"</example>
        /// </summary>
        /// <param name="id">The number of people</param>
        /// <returns>"Greetings to {id} people!"</returns>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }

    }
}
