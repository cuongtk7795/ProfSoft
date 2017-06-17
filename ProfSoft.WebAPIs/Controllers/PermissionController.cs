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
        public List<DTO.Permission> GetList()
        {
            List<DTO.Permission> listDto = null;
            using (ProfSoftEntities context = new ProfSoftEntities())
            {
                var listItem = context.Permissions.OrderBy(o => o.Id).ToList<Permission>();
                if (listItem.Count > 0)
                {
                    listDto = new List<DTO.Permission>();
                    foreach (var item in listItem)
                    {
                        DTO.Permission dto = new DTO.Permission();
                        dto.Id = item.Id;
                        dto.Code = item.Code;
                        dto.Name = item.Name;
                        listDto.Add(dto);
                    }
                }
            }
            return listDto;
        }
    }
}
