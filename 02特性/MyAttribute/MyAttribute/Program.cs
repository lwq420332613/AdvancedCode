using MyAttribute.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    /// <summary>
    /// 1 特性attribute，和注释有什么区别
    /// 2 声明和使用attribute，AttributeUsage
    /// 3 运行中获取attribute：额外信息 额外操作
    /// 4 Remark封装、attribute验证
    /// 5 作业部署
    /// 
    /// 特性：中括号声明 
    /// 
    /// 错觉：每一个特性都可以带来对应的功能
    /// 
    /// 实际上特性添加后，编译会在元素内部产生IL，但是我们是没办法直接使用的，
    /// 而且在metadata里面会有记录
    /// 
    /// 特性，本身是没用的
    /// 程序运行的过程中，我们能找到特性，而且也能应用一下
    /// 任何一个可以生效的特性，都是因为有地方主动使用了的
    /// 
    /// 没有破坏类型封装的前提下，可以加点额外的信息和行为
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班vip课程，今天的内容是特性和AOP");
                {
                    Student student = new Student();
                    student.Id = 123;
                    student.Name = "MrSorry";
                    student.QQ = 123456;
                    student.Study();
                    string result = student.Answer("Eleven");


                    Manager.Show(student);

                    student.Name = "布墨";
                    student.QQ = 9999;
                    Manager.Show(student);

                }
                {
                    UserState userState = UserState.Normal;
                    //if (userState == UserState.Normal)
                    //{
                    //    Console.WriteLine("正常状态");
                    //}
                    //else if (userState == UserState.Frozen)
                    //{ }
                    //else
                    //{ }
                    Console.WriteLine(userState.GetRemark());
                    Console.WriteLine(RemarkExtension.GetRemark(userState));
                }
                {
                    Console.WriteLine(UserState.Frozen.GetRemark());
                    Console.WriteLine(UserState.Deleted.GetRemark());
                }
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
