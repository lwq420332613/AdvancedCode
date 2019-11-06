using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOO.Interface
{
    /// <summary>
    /// 接口：没有任何具体实现  全部默认public 不能写访问修饰符
    /// </summary>
    public interface IExtend
    {
        void Video();
        ////string Remark;//no
        //string Description { get; set; }

        ////delegate void Action();//no

        ////class Test { }//no

        //event Action ActionHandler;

        //int this[int index] { get; }

    }
    public interface IExtendAdvanced
    {
        void Photo();
    }
}
