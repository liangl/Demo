using System;
using System.ComponentModel.DataAnnotations;

namespace Keyyum.Models
{
    /// <summary>
    /// 用户模型
    /// <remarks >
    /// 创建：2014年3月17日
    /// 修改：
    /// </remarks>
    /// </summary>
   public  class User
    {
       [Key]
       public Guid UserID { get; set; }

       /// <summary>
       /// 用户名
       /// </summary>
       [Required(ErrorMessage = "必填")]
       [StringLength(20, MinimumLength = 4, ErrorMessage = "{1}到{0}个字符")]
       [Display(Name = "用户名")]
       public string UserName { get; set; }
      
       /// <summary>
       /// 用户组ID
       /// </summary>
       [Required(ErrorMessage = "必填")]
       [Display(Name = "用户组ID")]
       public Guid GroupID { get; set; }
       
       /// <summary>
       /// 显示名称
       /// </summary>
       [Required(ErrorMessage = "必填")]
       [StringLength(20, MinimumLength = 2, ErrorMessage = "{1}到{0}个字符")]
       [Display(Name = "显示名")]
       public string DisplayName { get; set; }
       
       /// <summary>
       /// 密码
       /// </summary>
       [Required(ErrorMessage = "必填")]
       [Display(Name = "密码")]
       [StringLength(20, MinimumLength = 6, ErrorMessage = "密码必须为{1}到{0}个字符")]
       [DataType(DataType.Password)]
       public string Password { get; set; }

       /// <summary>
       /// 邮箱
       /// </summary>
       /// 
       [Required(ErrorMessage = "必填")]
       [Display(Name = "邮箱")]
       [DataType(DataType.EmailAddress)]
       public string Email { get; set; }
        
       /// <summary>
       /// 用户状态<br/>
       /// 0正常，1锁定，2未通过邮件验证，3未通过管理员
       /// </summary>
       public int Status { get; set; }

       /// <summary>
       /// 注册时间
       /// </summary>
       public DateTime RegistrationTime { get; set; }

       /// <summary>
       /// 上次登陆时间
       /// </summary>
       public DateTime LoginTime { get; set; }

       /// <summary>
       /// 上次登陆IP地址
       /// </summary>
       /// 
       [Display(Name="上次登陆的IP地址")]
       public string LoginIP { get; set; }

       public virtual UserGroup Group { get; set; }


    }
}
