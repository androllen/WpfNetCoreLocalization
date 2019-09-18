using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfUtil
{
    public class NewLineConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var s = string.Empty;

            if (!string.IsNullOrEmpty(value as string))
            {
                s = value.ToString();

                if (s.Contains("\\r\\n"))
                    s = s.Replace("\\r\\n", Environment.NewLine);

                if (s.Contains("\\n"))
                    s = s.Replace("\\n", Environment.NewLine);

                if (s.Contains("&#x0a;&#x0d;"))
                    s = s.Replace("&#x0a;&#x0d;", Environment.NewLine);

                if (s.Contains("&#x0a;"))
                    s = s.Replace("&#x0a;", Environment.NewLine);

                if (s.Contains("&#x0d;"))
                    s = s.Replace("&#x0d;", Environment.NewLine);

                if (s.Contains("&#10;&#13;"))
                    s = s.Replace("&#10;&#13;", Environment.NewLine);

                if (s.Contains("&#10;"))
                    s = s.Replace("&#10;", Environment.NewLine);

                if (s.Contains("&#13;"))
                    s = s.Replace("&#13;", Environment.NewLine);

                if (s.Contains("<br />"))
                    s = s.Replace("<br />", Environment.NewLine);

                if (s.Contains("<LineBreak />"))
                    s = s.Replace("<LineBreak />", Environment.NewLine);
            }

            return s;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
