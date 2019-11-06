using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq
{
    /// <summary>
    /// 1 匿名方法 lambda表达式 
    /// 2 匿名类 var 扩展方法
    /// 3 linq to object  
    /// 4 yield迭代器
    /// 5 linq常用方法介绍
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班vip课程，今天是Eleven老师为大家带来的linq课程");

                //{
                //    Console.WriteLine("***************Lambda*****************");
                //    LambdaShow lambdaShow = new LambdaShow();
                //    lambdaShow.Show();
                //}

                #region 匿名类 var
                //{
                //    Student student = new Student()
                //    {
                //        Id = 1,
                //        Name = "大水治禹",
                //        Age = 25,
                //        ClassId = 2
                //    };
                //    student.Study();

                //    //匿名类 3.0
                //    object model = new//3.0
                //    {
                //        Id = 2,
                //        Name = "undefined",
                //        Age = 25,
                //        ClassId = 2
                //    };
                //    //Console.WriteLine(model.Id);//object 编译器不允许
                //    var varModel = new//3.0  编译后是有一个真实的类
                //    {
                //        Id = 2,
                //        Name = "undefined",
                //        Age = 25,
                //        ClassId = 2
                //    };
                //    Console.WriteLine(varModel.Id);
                //    //varModel.Id = 123;//只能get 没有set
                //    //反射可以找到

                //dynamic dModel = new//4.0
                //{
                //    Id = 2,
                //    Name = "undefined",
                //    Age = 25,
                //    ClassId = 2
                //};
                //var s = dModel;
                //    ////dModel.Id = 3;//实例是只读的，所以不能赋值
                //    Console.WriteLine(dModel.Id);
                //    ////Console.WriteLine(dModel.Eleven);

                //    int i2 = 2;
                //    var i1 = 1;//var就是个语法糖，由编译器自动推算
                //    var s = "Eleven";

                //    //var aa;//var必须在声明的时候就确定类型
                //    //s = 123;//确定类型后是不能改的

                //    //1 var 配合匿名类型使用
                //    //2 var 偷懒，复杂类型的使用
                //    //var varModel = new//3.0
                //    //{
                //    //    Id = 2,
                //    //    Name = "undefined",
                //    //    Age = 25,
                //    //    ClassId = 2
                //    //};
                //    //Console.WriteLine(varModel.Id);

                //    //var和object 和dynamic
                //}
                #endregion

                #region 扩展方法 3.0
                {
                    //Student student = new Student()
                    //{
                    //    Id = 1,
                    //    Name = "大水治禹",
                    //    Age = 25,
                    //    ClassId = 2
                    //};
                    
                    //string s = null;
                    //student.Study();
                    //student.StudyHard();
                    ////又要增加方法  又不想(不能)修改
                    //student.Sing();

                    //ExtendMethod.Sing(student);
                    //Nullable<int>
                    int? iValue1 = null;
                    //int? iValue = 2;
                    //iValue1.ToInt();

                    //iValue1.Length();
                    //student.Length();
                    //s.Length();

                    //123.Than(234);
                }
                #endregion

                #region linq
                {
                    Console.WriteLine("***************Linq*****************");
                    LinqShow show = new LinqShow();
                    show.Show();
                }
                #endregion

                #region yield
                {
                    Console.WriteLine("***************Yield*****************");
                }

                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
