using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    /// <summary>
    /// 特性：就是一个类，直接/间接继承自attribute
    ///       一般以Attribute结尾，声明时候可以省略掉
    ///       
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class CustomAttribute : Attribute
    {
        public CustomAttribute()
        { }

        public CustomAttribute(int id)
        {
            Console.WriteLine("********************");
        }


        public string Description { get; set; }

        public string Remark = null;

        public void Show()
        {
            Console.WriteLine($"This is {nameof(CustomAttribute)}");
        }

        //委托  事件 都没问题

    }
}
