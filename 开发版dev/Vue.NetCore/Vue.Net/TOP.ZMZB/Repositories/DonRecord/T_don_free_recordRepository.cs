/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹T_don_free_recordRepository编写代码
 */
using TOP.ZMZB.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace TOP.ZMZB.Repositories
{
    public partial class T_don_free_recordRepository : RepositoryBase<T_don_free_record> , IT_don_free_recordRepository
    {
    public T_don_free_recordRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IT_don_free_recordRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IT_don_free_recordRepository>(); } }
    }
}
