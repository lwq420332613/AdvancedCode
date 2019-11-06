using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyLinq
{
    /// <summary>
    /// 扩展方法：静态类里面的静态方法，第一个参数类型前面加上this
    /// 用途：可以不修改类，增加方法；也就是方便一点
    /// 缺陷：优先调用类型的实例方法(有隐患)
    ///       扩展基类型，导致任何子类都有这个方法，而且还可能被覆盖啥的
    ///      
    /// 指定类型扩展，不要对基类型 否则成本太高
    /// 
    /// 没有扩展属性
    /// </summary>
    public static class ExtendMethod
    {
        /// <summary>
        /// 1 基于委托封装解耦，去掉重复代码，完成通用代码
        /// 2 泛型，应对各种数据类型
        /// 3 加迭代器，按需获取
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        //public static List<T> ElevenWhere<T>(this List<T> source, Func<T, bool> func)
        //{
        //    var list = new List<T>();
        //    foreach (var item in source)
        //    {
        //        if (func.Invoke(item))
        //        {
        //            list.Add(item);
        //        }
        //    }
        //    return list;
        //}
        public static IEnumerable<T> ElevenWhere<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            if (source == null)
            {
                throw new Exception("source is null");
            }
            if (func == null)
            {
                throw new Exception("func is null");
            }

            foreach (var item in source)
            {
                if (func.Invoke(item))
                {
                    yield return item;
                }
            }
        }




        public static void Show<T>(this T t)//最好加约束
        { }

        public static void Sing(this Student student)
        {
            Console.WriteLine($"{student.Name} Sing a Song");
        }

        /// <summary>
        /// null默认是defaultValue,默认是0
        /// </summary>
        /// <param name="iValue"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int ToInt(this int? iValue, int defaultValue = 0)
        {
            return iValue ?? defaultValue;
        }

        public static bool Than(this int value1, int value2)
        {
            return value1 > value2;
        }


        /// <summary>
        /// 扩展基类型，导致任何子类都有这个方法，而且还可能被覆盖啥的
        /// </summary>
        /// <param name="iValue"></param>
        /// <returns></returns>
        public static int Length(this object oValue)
        {
            return oValue == null ? 0 : oValue.ToString().Length;
        }

    }

    public static class ExtendMethod1
    {
        /// <summary>
        /// 重复扩展方法  编译无措  调用的地方错了  二义性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void Show<T>(this T t)//最好加约束
        { }
    }
}
