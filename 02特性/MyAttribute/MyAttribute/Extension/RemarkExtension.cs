using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute.Extension
{
    /// <summary>
    /// 用户状态
    /// </summary>
    public enum UserState
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Remark("正常")]
        Normal = 0,//左边是字段名称  右边是数据库值   哪里放描述？  注释
        /// <summary>
        /// 冻结
        /// </summary>
        [Remark("冻结")]
        Frozen = 1,
        /// <summary>
        /// 删除
        /// </summary>
        //[Remark("删除")]
        Deleted = 2
    }
    //枚举项加一个描述   实体类的属性也可以Display  
    //别名   映射  
    public class RemarkAttribute : Attribute
    {
        public RemarkAttribute(string remark)
        {
            this._Remark = remark;
        }
        private string _Remark = null;
        public string GetRemark()
        {
            return this._Remark;
        }
    }


    public static class RemarkExtension
    {
        public static string GetRemark(this Enum value)
        {
            Type type = value.GetType();
            FieldInfo field = type.GetField(value.ToString());
            if (field.IsDefined(typeof(RemarkAttribute), true))
            {
                RemarkAttribute attribute = (RemarkAttribute)field.GetCustomAttribute(typeof(RemarkAttribute), true);
                return attribute.GetRemark();
            }
            else
            {
                return value.ToString();
            }
        }

    }
}
