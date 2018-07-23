using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ctoMentors.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public List<stringval> Get(int id)
        {
            List<stringval> valu = new List<stringval>();
            valu.Add(new stringval("Name1", "url1"));
            valu.Add(new stringval("Name2", "url2"));
            valu.Add(new stringval("Name3", "url3"));
            return valu;
        }

        public class stringval
        {
           public stringval(string name, string url)
            {
                this.name = name;
                this.url = url;
            }
            public string name { get; set; }
            public string url { get; set; }
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
