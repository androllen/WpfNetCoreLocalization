using System.Threading;
using WpfNetCoreLocalization.Strings;

namespace WpfNetCoreLocalization
{
    public class MainWindowViewModel : Prism.Mvvm.BindableBase
    {
        //根据系统的语言
        //Message = SR.ResourceManager.GetString("Message", Thread.CurrentThread.CurrentCulture);
        //根据项目设置的语言
        private string _message = SR.ResourceManager.GetString("Message", Thread.CurrentThread.CurrentUICulture);
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        public MainWindowViewModel()
        {
        }
    }
}
