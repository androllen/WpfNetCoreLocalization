using ModuleA.Models;
using ModuleA.Strings;
using Prism.Mvvm;
using System.Globalization;
using System.Threading;
using WpfUtil.Extension;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel()
        {
            Message = string.Format(SR.ResourceManager.GetString("Message", Thread.CurrentThread.CurrentUICulture), System.DateTime.Now);
        }

        private RequestTypeValue requestTypeItem;
        public RequestTypeValue RequestTypeItem
        {
            get { return requestTypeItem; }
            set
            {
                SetProperty(ref requestTypeItem, value);

                if (requestTypeItem == RequestTypeValue.zhCN)
                {
                    var _culture = new CultureInfo("zh-CN");
                    TranslationSource.Instance.CurrentCulture = _culture;

                    //临时操作 
                    Message = string.Format(SR.ResourceManager.GetString("Message", TranslationSource.Instance.CurrentCulture),System.DateTime.Now);
                }
                else
                {
                    var _culture = new CultureInfo("en-US");
                    TranslationSource.Instance.CurrentCulture = _culture;

                    Message = string.Format(SR.ResourceManager.GetString("Message", _culture), System.DateTime.Now);

                }
            }
        }
    }
}
