using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOO.Polymorphism
{
    /// <summary>
    /// 
    /// </summary>
    public class Poly
    {
        public static void Test()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");



            ParentClass instance = new ChildClass();

            
            //instance.VirtualMethod("");
            //instance.VirtualMethod();

            Console.WriteLine("下面是instance.CommonMethod()");
            instance.CommonMethod();//普通方法的调用  左边为准；编译时确定；  为了效率
            Console.WriteLine("下面是instance.VirtualMethod()");
            instance.VirtualMethod();//虚方法的调用   右边为准(没有override 还是左边)；运行时确定；  为了灵活
            Console.WriteLine("下面是instance.AbstractMethod()");
            instance.AbstractMethod();//抽象方法的调用  右边为准；运行时确定；  为了灵活

            //ChildClass childClass = new ChildClass();
            //childClass.CommonMethod();
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }
    }

    #region abstract
    public abstract class ParentClass
    {
        /// <summary>
        /// CommonMethod
        /// </summary>
        public void CommonMethod()
        {
            Console.WriteLine("ParentClass CommonMethod");
        }

        /// <summary>
        /// virtual  虚方法  必须包含实现 但是可以被重载
        /// </summary>
        public virtual void VirtualMethod()
        {
            Console.WriteLine("ParentClass VirtualMethod");
        }

        public virtual void VirtualMethod(string name)
        {
            Console.WriteLine("ParentClass VirtualMethod");
        }

        public abstract void AbstractMethod();
    }

    public class ChildClass : ParentClass
    {
        /// <summary>
        /// new 隐藏
        /// 非常不推荐在子类隐藏父类的方法
        /// goto
        /// </summary>
        public new void CommonMethod()
        {
            Console.WriteLine("ChildClass CommonMethod");
            // base this
        }

        //public void CommonMethod(string name)
        //{
        //    Console.WriteLine("ChildClass CommonMethod");
        //}

        //public void CommonMethod(int id, string name = "", string des = "", int size = 0)
        //{
        //    Console.WriteLine("ChildClass CommonMethod");
        //}
        //public void CommonMethod(string name, int id)
        //{
        //    Console.WriteLine("ChildClass CommonMethod");
        //}

        /// <summary>
        /// virtual 可以被覆写
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override void VirtualMethod()
        {
            Console.WriteLine("ChildClass VirtualMethod");
            base.VirtualMethod();
        }

        /// <summary>
        /// 抽象方法必须覆写
        /// </summary>
        public sealed override void AbstractMethod()
        {
            //this.CommonMethod();//this是当前这个类型的实例的方法
            Console.WriteLine("ChildClass AbstractMethod");
        }
    }

    public class GrandChildClass : GrandClass
    {
        public GrandChildClass(int id) : base(id)
        { }
    }
    public class GrandClass : ChildClass
    {
        public GrandClass() : this(13)
        { }

        public GrandClass(int id)
            : base()//父类的构造函数
        { }

        ///// <summary>
        ///// sealed不能再次覆写
        ///// </summary>
        //public override void AbstractMethod()
        //{
        //    base.AbstractMethod();
        //}
        /// <summary>
        /// 多重覆写
        /// </summary>
        public override void VirtualMethod()
        {
            base.VirtualMethod();//指定调用直接父类的这个方法
        }
    }
    #endregion abstract
    
}
