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
    [Entity(TableCnName = "献血证信息",TableName = "T_don_free_record")]
    public class T_don_free_record:BaseEntity
    {
        /// <summary>
       ///退费详细记录自增ID
       /// </summary>
       [Key]
       [Display(Name ="退费详细记录自增ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int tdfr_id { get; set; }

       /// <summary>
       ///退费申请编号
       /// </summary>
       [Display(Name ="退费申请编号")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       public string taa_ApplyID { get; set; }

       /// <summary>
       ///退费方式1:年龄，2:本人终生直免 6.其他献血者退费 7：其他（补录错误）
       /// </summary>
       [Display(Name ="退费方式1:年龄，2:本人终生直免 6.其他献血者退费 7：其他（补录错误）")]
       [Column(TypeName="int")]
       public int? tdfr_prop_mode { get; set; }

       /// <summary>
       ///献血证号
       /// </summary>
       [Display(Name ="献血证号")]
       [MaxLength(13)]
       [Column(TypeName="char(13)")]
       public string tdfr_dor_id { get; set; }

       /// <summary>
       ///抵扣的献血血量
       /// </summary>
       [Display(Name ="抵扣的献血血量")]
       [DisplayFormat(DataFormatString="10,4")]
       [Column(TypeName="decimal")]
       public decimal? tdfr_blood_amount { get; set; }

       /// <summary>
       ///抵扣单采血量
       /// </summary>
       [Display(Name ="抵扣单采血量")]
       [DisplayFormat(DataFormatString="10,4")]
       [Column(TypeName="decimal")]
       public decimal? tdfr_blood_amount2 { get; set; }

       /// <summary>
       ///抵扣金额
       /// </summary>
       [Display(Name ="抵扣金额")]
       [DisplayFormat(DataFormatString="10,4")]
       [Column(TypeName="decimal")]
       public decimal? tdfr_money { get; set; }

       /// <summary>
       ///审核状态
       /// </summary>
       [Display(Name ="审核状态")]
       [Column(TypeName="int")]
       public int? tdfr_past { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? tdfr_create { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tdfr_createuser { get; set; }

       /// <summary>
       ///与用血者关系(1-本人、2-父子、3-父女、4-配偶、5-母子、6-母女)
       /// </summary>
       [Display(Name ="与用血者关系(1-本人、2-父子、3-父女、4-配偶、5-母子、6-母女)")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tdfr_relation { get; set; }

       /// <summary>
       ///证明材料(1-身份证、2-户口本、3-社区、4-结婚证、5-派出所、6-出生医学证、7-村委会、8-单位证明)
       /// </summary>
       [Display(Name ="证明材料(1-身份证、2-户口本、3-社区、4-结婚证、5-派出所、6-出生医学证、7-村委会、8-单位证明)")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string tdfr_prove { get; set; }

       /// <summary>
       ///献血者姓名
       /// </summary>
       [Display(Name ="献血者姓名")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tdfr_dor_name { get; set; }

       /// <summary>
       ///证件类型
       /// </summary>
       [Display(Name ="证件类型")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tdfr_dor_identity_type { get; set; }

       /// <summary>
       ///证件号码
       /// </summary>
       [Display(Name ="证件号码")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tdfr_dor_identity_code { get; set; }

       /// <summary>
       ///是否有效
       /// </summary>
       [Display(Name ="是否有效")]
       [Column(TypeName="int")]
       public int? tdfr_isvalid { get; set; }

       /// <summary>
       ///可抵扣的献全血量
       /// </summary>
       [Display(Name ="可抵扣的献全血量")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? tdfr_blood_amount3 { get; set; }

       /// <summary>
       ///可抵扣单采血量
       /// </summary>
       [Display(Name ="可抵扣单采血量")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? tdfr_blood_amount4 { get; set; }

       /// <summary>
       ///数据类型(0:提取到献血员信息,1:提取不到献血员信息)
       /// </summary>
       [Display(Name ="数据类型(0:提取到献血员信息,1:提取不到献血员信息)")]
       [Column(TypeName="int")]
       public int? tdfr_type { get; set; }

       /// <summary>
       ///献血血型
       /// </summary>
       [Display(Name ="献血血型")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string tdfr_dor_blood_rh { get; set; }

       /// <summary>
       ///献血者性别
       /// </summary>
       [Display(Name ="献血者性别")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       public string tdfr_sex { get; set; }

       /// <summary>
       ///年龄
       /// </summary>
       [Display(Name ="年龄")]
       [Column(TypeName="int")]
       public int? tdfr_age { get; set; }

       /// <summary>
       ///年龄单位字典age_unit：1-岁，2-月，3-天
       /// </summary>
       [Display(Name ="年龄单位字典age_unit：1-岁，2-月，3-天")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       public string tdfr_age_unit { get; set; }

       /// <summary>
       ///是否异常
       /// </summary>
       [Display(Name ="是否异常")]
       [Column(TypeName="int")]
       public int? tdfr_isUnusual { get; set; }

       /// <summary>
       ///可抵扣金额
       /// </summary>
       [Display(Name ="可抵扣金额")]
       [Column(TypeName="decimal")]
       public decimal? tdfr_deductible_amoney { get; set; }

       /// <summary>
       ///献血证血液抵扣类型0:全血抵扣 1:血小板抵扣 5:全部抵扣
       /// </summary>
       [Display(Name ="献血证血液抵扣类型0:全血抵扣 1:血小板抵扣 5:全部抵扣")]
       [Column(TypeName="int")]
       public int? tdfr_bldtype { get; set; }

       
    }
}