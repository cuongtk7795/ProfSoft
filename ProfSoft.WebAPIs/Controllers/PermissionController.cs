using ProfSoft.WebAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProfSoft.WebAPIs.Controllers
{
    [RoutePrefix("api/Permission")]
    public class PermissionController : ApiController
    {
        [HttpGet]
        [Route("GetList")]
        public IEnumerable<Permission> GetList()
        {
            using (ProfSoftEntities context = new ProfSoftEntities())
            {
                return context.Permissions.ToList();
            }
        }
    }
}
