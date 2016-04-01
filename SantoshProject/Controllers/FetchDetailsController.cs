using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Antlr.Runtime;
using SantoshProject.DataContext;
using SantoshProject.Models;

namespace SantoshProject.Controllers
{
    public class FetchDetailsController : ApiController
    {
        public List<EfilingTemplates> GetDetails()
        {
            using (var context = new NewDataContext())
            {

                return context.DetailsDbSet.ToList();
            }
        }
    [HttpPost]
        public List<EfilingTemplates> GetDetails([FromBody]Criteria criteria)
        {
            using (var context = new NewDataContext())
            {

                return context.DetailsDbSet.ToList();
            }
        }
    }
}
