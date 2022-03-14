/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("ICD_10_Code",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.Entity.DomainModels;
using TOP.ZMZB.IServices;
using VOL.Core.Enums;
using VOL.Core.Filters;

namespace TOP.ZMZB.Controllers
{
    public partial class ICD_10_CodeController
    {
        private readonly IICD_10_CodeService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public ICD_10_CodeController(
            IICD_10_CodeService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("GetICD10List")]    
        public IActionResult GetICD10List([FromBody] PageDataOptions options)
        {
            return Json(Service.GetPageData(options));
        }
    }
}
