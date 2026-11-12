using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalconCombineCsharp.attrs
{
    public class Feature
    {
        [Category("特征筛选属性")]
        [Description("特征名称")]
        [TypeConverter(typeof(FeaturesConver))]
        public string FeatureName { get; set; }="area";
        [Category("特征筛选属性")]
        [Description("操作符号")]
        [TypeConverter(typeof(OperationConver))]
        public string Operation { get; set; }="and";
        [Category("特征筛选属性")]
        [Description("最小值")]            
        public double Min { get; set; }
        [Category("特征筛选属性")]
        [Description("最大值")]
        public double Max { get; set; }
        
        
    
    }
    public class FeaturesConver : StringConverter
    {
        //是否设置为下拉列表框
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext? context)
        {
            return true;
        }
        //是否设置支持列表框方式操作

        public override bool GetStandardValuesSupported(ITypeDescriptorContext? context)
        {
            return true;
        }

        //设置列表框需要显示的数据项
        public override StandardValuesCollection? GetStandardValues(ITypeDescriptorContext? context)
        {
            return new StandardValuesCollection(new string[] { "area", "row", "column", "row1", "column1" });
        }
    }
    public class OperationConver : StringConverter
    {
        //是否设置为下拉列表框
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext? context)
        {
            return true;
        }
        //是否设置支持列表框方式操作

        public override bool GetStandardValuesSupported(ITypeDescriptorContext? context)
        {
            return true;
        }

        //设置列表框需要显示的数据项
        public override StandardValuesCollection? GetStandardValues(ITypeDescriptorContext? context)
        {
            return new StandardValuesCollection(new string[] { "and", "or"});
        }
    }
}
