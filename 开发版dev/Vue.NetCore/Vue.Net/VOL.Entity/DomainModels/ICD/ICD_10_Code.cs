/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "ICD字典",TableName = "ICD_10_Code")]
    public class ICD_10_Code:BaseEntity
    {
        /// <summary>
       ///诊断代码
       /// </summary>
       [Key]
       [Display(Name ="诊断代码")]
       [MaxLength(255)]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid CinicalDiagnosisID { get; set; }

       /// <summary>
       ///诊断名称
       /// </summary>
       [Display(Name ="诊断名称")]
       [MaxLength(255)]
       [Column(TypeName="varchar(255)")]
       public string CinicalDiagnosisName { get; set; }

       
    }
}