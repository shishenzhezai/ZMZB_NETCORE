/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹T_app_kindInfoController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using TOP.ZMZB.IServices;
namespace TOP.ZMZB.Controllers
{
    [Route("api/T_app_kindInfo")]
    [PermissionTable(Name = "T_app_kindInfo")]
    public partial class T_app_kindInfoController : ApiBaseController<IT_app_kindInfoService>
    {
        public T_app_kindInfoController(IT_app_kindInfoService service)
        : base(service)
        {
        }
    }
}

