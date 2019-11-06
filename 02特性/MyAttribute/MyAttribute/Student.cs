using MyAttribute.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    /// <summary>
    /// 这里是注释，除了让人看懂这里写的是什么，
    /// 对运行没有任何影响
    /// </summary>
    //[Obsolete("请不要使用这个了，请使用什么来代替", true)]//影响编译器的运行
    //[Serializable]//可以序列化和反序列化  可以影响程序的运行
    //MVC filter   ORM table  key  display   wcf 

    //[Custom]
    //[Custom()]
    //[Custom(123), Custom(123, Description = "1234")]
    [Custom(123, Description = "1234", Remark = "2345")]//方法不行
    public class Student
    {
        [CustomAttribute]
        public int Id { get; set; }
        [Leng(5,10)]//还有各种检查
        public string Name { get; set; }
        [Leng(20, 50)]
        public string Accont { get; set; }

        /// <summary>
        /// 10001~999999999999
        /// </summary>
        [Long(10001, 999999999999)]
        public long QQ { get; set; }


        //private long _QQ2 = 0;//解决数据合法性，给属性增加了太多的事儿
        //public long QQ2
        //{
        //    get
        //    {
        //        return this._QQ2;
        //    }
        //    set
        //    {
        //        if (value > 10001 && value < 999999999999)
        //        {
        //            _QQ2 = value;
        //        }
        //        else
        //        {
        //            throw new Exception();
        //        }
        //    }
        //}

        //20：55中场休息+提问
        /// 21:00 开始答疑
        /// 答疑完继续，期间我会关掉声音
        [CustomAttribute]
        public void Study()
        {
            Console.WriteLine($"这里是{this.Name}跟着Eleven老师学习");
        }

        [Custom()]
        [return: Custom()]
        public string Answer([Custom]string name)
        {
            return $"This is {name}";
        }
    }
}
