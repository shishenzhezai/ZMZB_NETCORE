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
    [Entity(TableCnName = "直免直报",TableName = "T_app_applyinfo")]
    public class T_app_applyinfo:BaseEntity
    {
        /// <summary>
       ///退费申请编号
       /// </summary>
       [Key]
       [Display(Name ="退费申请编号")]
       [MaxLength(20)]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid taa_ApplyID { get; set; }

       /// <summary>
       ///编号
       /// </summary>
       [Display(Name ="编号")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int taa_ID { get; set; }

       /// <summary>
       ///病人姓名
       /// </summary>
       [Display(Name ="病人姓名")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       public string taa_Name { get; set; }

       /// <summary>
       ///住院流水号
       /// </summary>
       [Display(Name ="住院流水号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_HISID { get; set; }

       /// <summary>
       ///病案号
       /// </summary>
       [Display(Name ="病案号")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_PatientID { get; set; }

       /// <summary>
       ///证件类型
       /// </summary>
       [Display(Name ="证件类型")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_identity_type { get; set; }

       /// <summary>
       ///身份证
       /// </summary>
       [Display(Name ="身份证")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_IDCard { get; set; }

       /// <summary>
       ///用血处方
       /// </summary>
       [Display(Name ="用血处方")]
       [MaxLength(2)]
       [Column(TypeName="char(2)")]
       public string taa_IfPrescription { get; set; }

       /// <summary>
       ///用血医嘱
       /// </summary>
       [Display(Name ="用血医嘱")]
       [MaxLength(2)]
       [Column(TypeName="char(2)")]
       public string taa_IfDocAdvice { get; set; }

       /// <summary>
       ///用血通知单
       /// </summary>
       [Display(Name ="用血通知单")]
       [MaxLength(2)]
       [Column(TypeName="char(2)")]
       public string taa_IfNotice { get; set; }

       /// <summary>
       ///用血记录
       /// </summary>
       [Display(Name ="用血记录")]
       [MaxLength(2)]
       [Column(TypeName="char(2)")]
       public string taa_IfUseBlood { get; set; }

       /// <summary>
       ///用血证明
       /// </summary>
       [Display(Name ="用血证明")]
       [MaxLength(2)]
       [Column(TypeName="char(2)")]
       public string taa_IfBldProve { get; set; }

       /// <summary>
       ///确认献血者关系
       /// </summary>
       [Display(Name ="确认献血者关系")]
       [MaxLength(2)]
       [Column(TypeName="char(2)")]
       public string taa_IfConfirmRelation { get; set; }

       /// <summary>
       ///确认人
       /// </summary>
       [Display(Name ="确认人")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       public string taa_Confirmer { get; set; }

       /// <summary>
       ///确认时间
       /// </summary>
       [Display(Name ="确认时间")]
       [Column(TypeName="datetime")]
       public DateTime? taa_ConfirmDate { get; set; }

       /// <summary>
       ///申请单状态：0-待处理，1-报销成功，3-报销失败
       /// </summary>
       [Display(Name ="申请单状态：0-待处理，1-报销成功，3-报销失败")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       public string taa_Status { get; set; }

       /// <summary>
       ///报销确认人
       /// </summary>
       [Display(Name ="报销确认人")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string taa_ConfirmReOper { get; set; }

       /// <summary>
       ///描述
       /// </summary>
       [Display(Name ="描述")]
       [MaxLength(1000)]
       [Column(TypeName="varchar(1000)")]
       public string taa_Descript { get; set; }

       /// <summary>
       ///记录人
       /// </summary>
       [Display(Name ="记录人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_Charger { get; set; }

       /// <summary>
       ///记录时间
       /// </summary>
       [Display(Name ="记录时间")]
       [Column(TypeName="datetime")]
       public DateTime? taa_ApplyDate { get; set; }

       /// <summary>
       ///报销时间
       /// </summary>
       [Display(Name ="报销时间")]
       [Column(TypeName="datetime")]
       public DateTime? taa_AppConfirmDate { get; set; }

       /// <summary>
       ///发票号
       /// </summary>
       [Display(Name ="发票号")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       public string taa_Invoice { get; set; }

       /// <summary>
       ///用血者年龄
       /// </summary>
       [Display(Name ="用血者年龄")]
       [Column(TypeName="int")]
       public int? taa_Age { get; set; }

       /// <summary>
       ///总血费
       /// </summary>
       [Display(Name ="总血费")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? taa_BldMoney { get; set; }

       /// <summary>
       ///退费类型(退费类型:1:献血证退费;2：年龄退费；3：献血证和年龄退费;4:其他)
       /// </summary>
       [Display(Name ="退费类型(退费类型:1:献血证退费;2：年龄退费；3：献血证和年龄退费;4:其他)")]
       [MaxLength(10)]
       [Column(TypeName="varchar(10)")]
       public string taa_refund_type { get; set; }

       /// <summary>
       ///退费金额
       /// </summary>
       [Display(Name ="退费金额")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? taa_refund_total { get; set; }

       /// <summary>
       ///献血证退费金额
       /// </summary>
       [Display(Name ="献血证退费金额")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? taa_refund_dor_total { get; set; }

       /// <summary>
       ///年龄退费金额
       /// </summary>
       [Display(Name ="年龄退费金额")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? taa_refund_age_total { get; set; }

       /// <summary>
       ///填报类型（1：异地、0：本地）
       /// </summary>
       [Display(Name ="填报类型（1：异地、0：本地）")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_reporting_type { get; set; }

       /// <summary>
       ///填报归属地
       /// </summary>
       [Display(Name ="填报归属地")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_reporting_place { get; set; }

       /// <summary>
       ///用血者归属地
       /// </summary>
       [Display(Name ="用血者归属地")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_useBlood_place { get; set; }

       /// <summary>
       ///年龄不可退
       /// </summary>
       [Display(Name ="年龄不可退")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? taa_NoAgeTotal { get; set; }

       /// <summary>
       ///献血证可退
       /// </summary>
       [Display(Name ="献血证可退")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? taa_BloodTotal { get; set; }

       /// <summary>
       ///年龄优先(年龄优先:1,,不是0)
       /// </summary>
       [Display(Name ="年龄优先(年龄优先:1,,不是0)")]
       [MaxLength(2)]
       [Column(TypeName="char(2)")]
       public string taa_AgeFirst { get; set; }

       /// <summary>
       ///年龄优先审核状态 0：待审核，1：通过，2：驳回
       /// </summary>
       [Display(Name ="年龄优先审核状态 0：待审核，1：通过，2：驳回")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_AgeAduitStatus { get; set; }

       /// <summary>
       ///年龄优先驳回说明
       /// </summary>
       [Display(Name ="年龄优先驳回说明")]
       [MaxLength(1000)]
       [Column(TypeName="varchar(1000)")]
       public string taa_AgeAduitMsg { get; set; }

       /// <summary>
       ///年龄优先审核时间
       /// </summary>
       [Display(Name ="年龄优先审核时间")]
       [Column(TypeName="datetime")]
       public DateTime? taa_AgeAduitTime { get; set; }

       /// <summary>
       ///年龄优先审核人
       /// </summary>
       [Display(Name ="年龄优先审核人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_AgeAduitPerson { get; set; }

       /// <summary>
       ///退费审核状态 0：待审核，1：通过，2：驳回
       /// </summary>
       [Display(Name ="退费审核状态 0：待审核，1：通过，2：驳回")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_AduitStatus { get; set; }

       /// <summary>
       ///退费审核时间
       /// </summary>
       [Display(Name ="退费审核时间")]
       [Column(TypeName="datetime")]
       public DateTime? taa_AduitTime { get; set; }

       /// <summary>
       ///退费审核人
       /// </summary>
       [Display(Name ="退费审核人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_AduitPerson { get; set; }

       /// <summary>
       ///报销医院
       /// </summary>
       [Display(Name ="报销医院")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_Hospital { get; set; }

       /// <summary>
       ///登记单位
       /// </summary>
       [Display(Name ="登记单位")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_register_company { get; set; }

       /// <summary>
       ///是否有效
       /// </summary>
       [Display(Name ="是否有效")]
       [Column(TypeName="int")]
       public int? taa_isvalid { get; set; }

       /// <summary>
       ///是否已结算
       /// </summary>
       [Display(Name ="是否已结算")]
       [Column(TypeName="int")]
       public int? taa_isSettle { get; set; }

       /// <summary>
       ///领款人
       /// </summary>
       [Display(Name ="领款人")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_Payee { get; set; }

       /// <summary>
       ///领款人电话
       /// </summary>
       [Display(Name ="领款人电话")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       public string taa_PayeeTel { get; set; }

       /// <summary>
       ///打印次数
       /// </summary>
       [Display(Name ="打印次数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int taa_Printcount { get; set; }

       /// <summary>
       ///凭证路径
       /// </summary>
       [Display(Name ="凭证路径")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       public string taa_Proof { get; set; }

       /// <summary>
       ///性别
       /// </summary>
       [Display(Name ="性别")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       public string taa_Sex { get; set; }

       /// <summary>
       ///年龄单位字典age_unit：1-岁，2-月，3-天
       /// </summary>
       [Display(Name ="年龄单位字典age_unit：1-岁，2-月，3-天")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       public string taa_AgeUnit { get; set; }

       /// <summary>
       ///临床诊断名称(多个用分号“;”分隔)
       /// </summary>
       [Display(Name ="临床诊断名称(多个用分号“;”分隔)")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       public string taa_CinicalDiagnosisName { get; set; }

       /// <summary>
       ///临床诊断代码（主要诊断）
       /// </summary>
       [Display(Name ="临床诊断代码（主要诊断）")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       public string taa_CinicalDiagnosisID { get; set; }

       /// <summary>
       ///是否异常
       /// </summary>
       [Display(Name ="是否异常")]
       [Column(TypeName="int")]
       public int? taa_isUnusual { get; set; }

       /// <summary>
       ///临床诊断名称(多个用分号“;”分隔)
       /// </summary>
       [Display(Name ="临床诊断名称(多个用分号“;”分隔)")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       public string CinicalDiagnosisName { get; set; }

       /// <summary>
       ///临床诊断代码（主要诊断）
       /// </summary>
       [Display(Name ="临床诊断代码（主要诊断）")]
       [MaxLength(500)]
       [Column(TypeName="varchar(500)")]
       public string CinicalDiagnosisID { get; set; }

       /// <summary>
       ///本地献血证退费
       /// </summary>
       [Display(Name ="本地献血证退费")]
       [Column(TypeName="decimal")]
       public decimal? taa_refund_local_dor_total { get; set; }

       /// <summary>
       ///异地献血证退费
       /// </summary>
       [Display(Name ="异地献血证退费")]
       [Column(TypeName="decimal")]
       public decimal? taa_refund_offset_dor_total { get; set; }

       /// <summary>
       ///本地年龄退费
       /// </summary>
       [Display(Name ="本地年龄退费")]
       [Column(TypeName="decimal")]
       public decimal? taa_refund_local_age_total { get; set; }

       /// <summary>
       ///异地年龄退费
       /// </summary>
       [Display(Name ="异地年龄退费")]
       [Column(TypeName="decimal")]
       public decimal? taa_refund_offset_age_total { get; set; }

       
    }
}