using MyOO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOO.Service
{
    /// <summary>
    /// 平板 继承BasePhone 能省略代码  代码不会错
    /// 但是语义错了，平板 is 手机
    /// </summary>
    public class iPad : BasePhone, IExtend, IExtendAdvanced
    {
        public void Photo()
        {
            throw new NotImplementedException();
        }

        public override void System()
        {
            throw new NotImplementedException();
        }

        public void Video()
        {
            throw new NotImplementedException();
        }
    }

    public class Camara : IExtendAdvanced
    {
        public void Photo()
        {
            throw new NotImplementedException();
        }
    }
}
