using WPFBootstrapper.Application.Interfaces;

namespace WPFBootstrapper.Application.ViewModels
{
    class MainViewModel : ViewModelBase, IMainViewModel
    {
        private string _text = "Hello";

        public string Text
        {
            get => _text;
            set
            {
                if (value == _text) return;
                _text = value;
                NotifyOfPropertyChange();
            }
        }
    }
}
