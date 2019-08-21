using ModuleA.Models;
using ModuleA.Strings;
using Prism.Mvvm;
using System.Globalization;
using System.Threading;
using WpfUtil;
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

                TranslationSource.Instance.Language = EnumHelper.GetDescription(requestTypeItem);
                Message = string.Format(SR.ResourceManager.GetString("Message", Thread.CurrentThread.CurrentUICulture), System.DateTime.Now);
            }
        }
    }
}
