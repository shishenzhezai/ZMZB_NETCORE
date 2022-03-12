/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹ICD_10_CodeRepository编写代码
 */
using TOP.ZMZB.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace TOP.ZMZB.Repositories
{
    public partial class ICD_10_CodeRepository : RepositoryBase<ICD_10_Code> , IICD_10_CodeRepository
    {
    public ICD_10_CodeRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IICD_10_CodeRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IICD_10_CodeRepository>(); } }
    }
}
