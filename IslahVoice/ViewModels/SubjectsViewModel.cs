using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using static IslahVoice.Model.CategoryModel;
using System.Threading.Tasks;
using IslahVoice.Services;

namespace IslahVoice.ViewModels
{
    public class SubjectsViewModel : BindableBase
    {
        public List<CategoryList> subject { get; set; }
        INavigationService _navigationService; 

        public SubjectsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            getCategory();
        }

        public async Task getCategory()
        {
            var remoteContent = new CategoryService();
            var result = await remoteContent.getCategory();
            subject = result.ToList()[1].CategoryList;
            RaisePropertyChanged("subject");
        }

    }
}
