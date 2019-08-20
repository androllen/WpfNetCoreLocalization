using ModuleB.Strings;
using Prism.Mvvm;

namespace ModuleB.ViewModels
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
            Message = SR.ResourceManager.GetString("Message");
        }
    }
}
