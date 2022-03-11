/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹T_don_free_recordController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using TOP.ZMZB.IServices;
namespace TOP.ZMZB.Controllers
{
    [Route("api/T_don_free_record")]
    [PermissionTable(Name = "T_don_free_record")]
    public partial class T_don_free_recordController : ApiBaseController<IT_don_free_recordService>
    {
        public T_don_free_recordController(IT_don_free_recordService service)
        : base(service)
        {
        }
    }
}

