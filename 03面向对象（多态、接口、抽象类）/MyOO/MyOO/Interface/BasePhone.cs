using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOO.Interface
{
    /// <summary>
    /// 抽象类:父类+约束
    /// </summary>
    public abstract class BasePhone //: IExtend
    {
        /// <summary>
        /// 手机独有的  平板不可能有
        /// </summary>
        public void Other()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public void Call()
        {
            Console.WriteLine($"Use {this.GetType().Name} Call");
        }
        public virtual void Text()
        {
            Console.WriteLine($"Use {this.GetType().Name} Text");
        }

        /// <summary>
        /// 一方面子类都得有；另一方面又各不相同；
        /// </summary>
        public abstract void System();

        //public void Video() { }


    }
}
