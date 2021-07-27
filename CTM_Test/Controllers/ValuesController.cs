using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CTM_Test.Controllers
{
    public class ValuesController : ApiController
    {
        //GET api/values/5
        public List<string> Get(int id)
        {
            var result = new List<string>();

            if (id >= 1 && id <= 100)
            {
                for (int i = 1; i <= id; i++)
                {
                    result.Add(CheckMultiple(i));
                }
            }

            return result;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        private string CheckMultiple(int n)
        {
            bool multiple3 = false;
            bool multiple5 = false;
            
            if ((n % 3) == 0)
                multiple3 = true;

            if ((n % 5) == 0)
                multiple5 = true;

            if (multiple3 && multiple5) 
            {
                return "FizzBuzz";
            }
            else if (multiple5)
            {
                return "Buzz";
            }
            else if (multiple3)
            {
                return "Fizz";
            }

            return n.ToString();
        }

    }
}
