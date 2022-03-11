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
    [Entity(TableCnName = "用血信息",TableName = "T_app_kindInfo")]
    public class T_app_kindInfo:BaseEntity
    {
        /// <summary>
       ///编号
       /// </summary>
       [Key]
       [Display(Name ="编号")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int tak_id { get; set; }

       /// <summary>
       ///退费申请编号
       /// </summary>
       [Display(Name ="退费申请编号")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       public string taa_ApplyID { get; set; }

       /// <summary>
       ///产品码
       /// </summary>
       [Display(Name ="产品码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tak_proc_code { get; set; }

       /// <summary>
       ///血品种名称
       /// </summary>
       [Display(Name ="血品种名称")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tak_proc_name { get; set; }

       /// <summary>
       ///用血量
       /// </summary>
       [Display(Name ="用血量")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? tak_amount { get; set; }

       /// <summary>
       ///用血单位
       /// </summary>
       [Display(Name ="用血单位")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tak_prod_unit { get; set; }

       /// <summary>
       ///ABO血型
       /// </summary>
       [Display(Name ="ABO血型")]
       [MaxLength(10)]
       [Column(TypeName="varchar(10)")]
       public string tak_abo_type { get; set; }

       /// <summary>
       ///RH血型
       /// </summary>
       [Display(Name ="RH血型")]
       [MaxLength(4)]
       [Column(TypeName="varchar(4)")]
       public string tak_rh_type { get; set; }

       /// <summary>
       ///发血人
       /// </summary>
       [Display(Name ="发血人")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string tak_bldOperter { get; set; }

       /// <summary>
       ///血液来源
       /// </summary>
       [Display(Name ="血液来源")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string tak_user_code { get; set; }

       /// <summary>
       ///用血时间
       /// </summary>
       [Display(Name ="用血时间")]
       [Column(TypeName="datetime")]
       public DateTime? tak_useBloodTime { get; set; }

       /// <summary>
       ///用血科室
       /// </summary>
       [Display(Name ="用血科室")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string tak_useDept { get; set; }

       /// <summary>
       ///用血医生
       /// </summary>
       [Display(Name ="用血医生")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string tak_useBldDoc { get; set; }

       /// <summary>
       ///血袋号
       /// </summary>
       [Display(Name ="血袋号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string tak_don_id { get; set; }

       /// <summary>
       ///血费
       /// </summary>
       [Display(Name ="血费")]
       [DisplayFormat(DataFormatString="10,4")]
       [Column(TypeName="decimal")]
       public decimal? tak_bldKindMoney { get; set; }

       /// <summary>
       ///插入时间
       /// </summary>
       [Display(Name ="插入时间")]
       [Column(TypeName="datetime")]
       [Required(AllowEmptyStrings=false)]
       public DateTime tak_regdate { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? tak_createdate { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tak_createuser { get; set; }

       /// <summary>
       ///金额
       /// </summary>
       [Display(Name ="金额")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? tak_money { get; set; }

       /// <summary>
       ///可抵扣类型（年龄、全部）
       /// </summary>
       [Display(Name ="可抵扣类型（年龄、全部）")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tak_deduction_type { get; set; }

       /// <summary>
       ///是否有效
       /// </summary>
       [Display(Name ="是否有效")]
       [Column(TypeName="int")]
       public int? tak_isvalid { get; set; }

       /// <summary>
       ///血液名称编码
       /// </summary>
       [Display(Name ="血液名称编码")]
       [MaxLength(5)]
       [Column(TypeName="varchar(5)")]
       public string tak_prod_name_code { get; set; }

       
    }
}