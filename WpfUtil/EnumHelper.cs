using System;
using System.ComponentModel;
using System.Reflection;

namespace WpfUtil
{
    public static class EnumHelper
    {
        private static T GetEnumAttribute<T>(Enum source) where T : Attribute
        {
            Type type = source.GetType();
            var sourceName = Enum.GetName(type, source);
            FieldInfo field = type.GetField(sourceName);
            object[] attributes = field.GetCustomAttributes(typeof(T), false);
            foreach (var o in attributes)
            {
                if (o is T)
                    return (T)o;
            }
            return null;
        }

        public static string GetDescription(Enum source)
        {
            var str = GetEnumAttribute<DescriptionAttribute>(source);
            return str == null ? null : str.Description;
        }

    }
}
