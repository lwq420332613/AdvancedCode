using MyOO.Interface;
using MyOO.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOO
{
    /// <summary>
    /// 1 面向对象Object Oriented
    /// 2 封装继承多态
    /// 3 重写overwrite(new)  覆写override 重载overload
    /// 4 抽象类接口
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班vip课程，今天是Eleven老师为大家带来的面向对象编程");

                Polymorphism.Poly.Test();


                //Player  手机  游戏
                Console.WriteLine("你得有一个手机");
                Console.WriteLine("开机。。。");
                Console.WriteLine("联网。。。");
                Console.WriteLine("启动游戏。。。");
                Console.WriteLine("一顿操作猛如虎。。。");
                Console.WriteLine("结束游戏。。。");

                //业务不断的复杂下去  
                //面向对象
                Player player = new Player();
                player.Id = 123;
                player.Name = "K";
                player.PlayIphoneGame(new iPhone());
                //封装：数据安全；内部修改保持稳定；提供重用性；分工合作，职责分明；
                //方便构建大型复杂的系统
                //private public internal protected

                //继承：去掉重复代码；可以实现多态
                //侵入性很强的类关系 
                {
                    BasePhone phone = new iPhone();
                    phone.Call();
                    //phone.GetHashCode();
                }
                {
                    BasePhone phone = new Lumia();
                    phone.Call();
                }
                //多态：相同的变量 相同的操作，但是不同的实现
                //方法的重载  接口&实现  抽象类&实现  继承

                //虚方法&抽象方法的选择
                //抽象
                {
                    BasePhone phone = new iPhone();// new BasePhone();
                    phone.Call();
                    phone.System();//运行时多态

                    player.Use<iPhone>(new iPhone());
                    
                    //phone.Video();//BasePhone没有，但是实例化的时候是有的
                    //是因为编译器的限制；实际在运行时是正确的
                    //dynamic dPhone = phone;//避开编译器的检查
                    //dPhone.Video();
                }
                //1 为什么不能调用
                //2 怎么选择接口和抽象类
                //3 为啥不直接iphone i = new phone()
                {
                    IExtend extend = new iPhone(); //new IExtend();
                    extend.Video();//运行时多态

                    //dynamic dPhone = extend;
                    //dPhone.Call();
                    //extend.Call();
                }


                //{
                //    BasePhone phone = new Lumia();
                //    phone.Call();
                //    phone.System();
                //}

                //{
                //    IExtend extend = new Lumia(); 
                //    extend.Video();
                //}

                //  接口：  只能约束          多实现更灵活    can do
                //抽象类：  可以完成通用实现  只能单继承      is a

                //加减乘除四个算法  都继承抽象类 没有共同实现，但是为了表明是算法
                //List<>  Array都有这个接口IEnumerable

                //门： 材质1  猫眼3 门铃3   开门(2)  关门(2)  报警(3)
                //多个国家是多个不同的类型
                //子类都一样的，放在父类；子类都有但是不同，抽象一下;有的有有的没，那就是接口


                //接口用的更多，因为接口更简单灵活  除非有些共有的需要继承
                //IBaseService--BaseService--UserService

                //什么时候用静态方法 什么时候用普通方法
                //能普通就普通，除非这个方法确定没有什么扩展，
                //只是工具类方法  可以静态
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
