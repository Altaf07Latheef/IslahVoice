using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace IslahVoice.ViewModels
{
    public class SubjectsViewModel : BindableBase
    {
        INavigationService _navigationService; 

        public SubjectsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            
        }
        
    }
}
