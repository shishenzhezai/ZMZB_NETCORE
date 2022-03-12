/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下ICD_10_CodeService与IICD_10_CodeService中编写
 */
using TOP.ZMZB.IRepositories;
using TOP.ZMZB.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace TOP.ZMZB.Services
{
    public partial class ICD_10_CodeService : ServiceBase<ICD_10_Code, IICD_10_CodeRepository>
    , IICD_10_CodeService, IDependency
    {
    public ICD_10_CodeService(IICD_10_CodeRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IICD_10_CodeService Instance
    {
      get { return AutofacContainerModule.GetService<IICD_10_CodeService>(); } }
    }
 }
