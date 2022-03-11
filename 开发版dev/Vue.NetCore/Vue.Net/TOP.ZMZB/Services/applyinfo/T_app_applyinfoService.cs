/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下T_app_applyinfoService与IT_app_applyinfoService中编写
 */
using TOP.ZMZB.IRepositories;
using TOP.ZMZB.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace TOP.ZMZB.Services
{
    public partial class T_app_applyinfoService : ServiceBase<T_app_applyinfo, IT_app_applyinfoRepository>
    , IT_app_applyinfoService, IDependency
    {
    public T_app_applyinfoService(IT_app_applyinfoRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IT_app_applyinfoService Instance
    {
      get { return AutofacContainerModule.GetService<IT_app_applyinfoService>(); } }
    }
 }
