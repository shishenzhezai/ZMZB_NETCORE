/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下T_don_free_recordService与IT_don_free_recordService中编写
 */
using TOP.ZMZB.IRepositories;
using TOP.ZMZB.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace TOP.ZMZB.Services
{
    public partial class T_don_free_recordService : ServiceBase<T_don_free_record, IT_don_free_recordRepository>
    , IT_don_free_recordService, IDependency
    {
    public T_don_free_recordService(IT_don_free_recordRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IT_don_free_recordService Instance
    {
      get { return AutofacContainerModule.GetService<IT_don_free_recordService>(); } }
    }
 }
