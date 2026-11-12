using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalconCombineCsharp.attrs
{
    public class Threshold
    {
        //最小灰度值
        [Category("二值化属性")]
        //[DisplayName("最小灰度值")]
        public double MinGray { get; set; }
        //最大灰度值
        [Category("二值化属性")]
        //[DisplayName("最大灰度值")]
        public double MaxGray { get; set; }
    }
}
