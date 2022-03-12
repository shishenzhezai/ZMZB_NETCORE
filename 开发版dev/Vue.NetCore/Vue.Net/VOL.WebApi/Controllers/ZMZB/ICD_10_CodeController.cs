/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ICD_10_CodeController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using TOP.ZMZB.IServices;
namespace TOP.ZMZB.Controllers
{
    [Route("api/ICD_10_Code")]
    [PermissionTable(Name = "ICD_10_Code")]
    public partial class ICD_10_CodeController : ApiBaseController<IICD_10_CodeService>
    {
        public ICD_10_CodeController(IICD_10_CodeService service)
        : base(service)
        {
        }
    }
}

