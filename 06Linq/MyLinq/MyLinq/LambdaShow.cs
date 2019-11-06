using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq
{
    public delegate void NoReturnNoParaOutClass();
    public delegate void GenericDelegate<T>();
    public class LambdaShow
    {
        //public int Id => 3;
        //public void ShowLambda() => Console.WriteLine("123");

        public delegate void NoReturnNoPara();
        public delegate void NoReturnWithPara(int x, int y);//1 声明委托
        public delegate int WithReturnNoPara();
        public delegate string WithReturnWithPara(out int x, ref int y);

        public void Show()
        {
            int k = 1;
            {
                //1.0  1.1
                NoReturnNoPara method = new NoReturnNoPara(this.DoNothing);
            }
            {
                //2.0 匿名方法 
                NoReturnNoPara method = new NoReturnNoPara(delegate ()
                {
                    Console.WriteLine(k);//能直接用到这里的变量
                Console.WriteLine("This is DoNothing1");
                });
            }
            {
                //3.0 lambda:左边是参数列表 goes to  右边是方法体   本质就是一个方法
                NoReturnNoPara method = new NoReturnNoPara(() =>//goes to
                {
                    Console.WriteLine("This is DoNothing2");
                });
            }
            {
                NoReturnWithPara method = new NoReturnWithPara((int x, int y) => { Console.WriteLine("This is DoNothing3"); });
            }
            {//可以省略掉参数类型  自动推算的
                NoReturnWithPara method = new NoReturnWithPara((x, y) => { Console.WriteLine("This is DoNothing4"); });
            }
            {//方法体只有一行，可以去掉大括号和分号
                NoReturnWithPara method = new NoReturnWithPara((x, y) => Console.WriteLine("This is DoNothing5"));
            }


            {
                //可以省略  编译器推算的
                NoReturnWithPara method = (x, y) => Console.WriteLine("This is DoNothing6");
            }//lambda表达式是个什么呢？
             //首先不是委托  委托是类型
             //然后也不是委托的实例  因为这里是省略new 委托()
             //只是一个方法(作用)
             //实际上是一个类中类，里面的一个internal方法，然后被绑定到静态的委托类型字段

            {
                NoReturnWithPara method = new NoReturnWithPara((x, y) => { Console.WriteLine("This is DoNothing4"); });
                method += new NoReturnWithPara((x, y) => { Console.WriteLine("This is DoNothing4"); });
                method -= new NoReturnWithPara((x, y) => { Console.WriteLine("This is DoNothing4"); });
                method.Invoke(123, 234);//还是执行2遍  lambda的注册是去不掉的
            }


            {
                Action<int> act = i => { };
            }
        }

        private void DoNothing()
        {
            Console.WriteLine("This is DoNothing");
        }
    }
}
