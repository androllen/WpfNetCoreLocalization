using System.ComponentModel;
using WpfUtil.Extension;

namespace ModuleA.Models
{
    [TypeConverter(typeof(EnumDefaultValueTypeConverter))]
    public enum RequestTypeValue
    {
        [Description("zh-CN"), DefaultValue("中文")]
        zhCN,
        [Description("en-US"), DefaultValue("英文")]
        enUS,
        [Description("ja-JP"), DefaultValue("日文")]
        jaJP
    }
}
