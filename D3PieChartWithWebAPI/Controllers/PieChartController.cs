using D3PieChartWithWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace D3PieChartWithWebAPI.Controllers
{
    public class PieChartController : ApiController
    {
        NorthwindEntities dataContext = new NorthwindEntities();
        // GET api/piechart
        public IEnumerable<CityPopulationTable> Get()
        {
            return dataContext.CityPopulationTables.ToList();
        }

        // GET api/piechart/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/piechart
        public void Post([FromBody]string value)
        {
        }

        // PUT api/piechart/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/piechart/5
        public void Delete(int id)
        {
        }
    }
}
