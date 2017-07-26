using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslahVoice.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware , INavigationPageOptions
    {
        public bool ClearNavigationStackOnNavigation
        {
            get { return false; }
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}
