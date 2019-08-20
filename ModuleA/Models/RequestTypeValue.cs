using System.ComponentModel;
using WpfUtil.Extension;

namespace ModuleA.Models
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum RequestTypeValue
    {
        [Description("中文")]
        zhCN,
        [Description("英文")]
        enUS
    }
}
