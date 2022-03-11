/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹T_app_applyinfoController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using TOP.ZMZB.IServices;
namespace TOP.ZMZB.Controllers
{
    [Route("api/T_app_applyinfo")]
    [PermissionTable(Name = "T_app_applyinfo")]
    public partial class T_app_applyinfoController : ApiBaseController<IT_app_applyinfoService>
    {
        public T_app_applyinfoController(IT_app_applyinfoService service)
        : base(service)
        {
        }
    }
}

