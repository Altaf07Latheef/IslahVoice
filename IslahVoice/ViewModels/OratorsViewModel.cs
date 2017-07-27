using IslahVoice.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IslahVoice.Model.CategoryModel;

namespace IslahVoice.ViewModels
{
    public class OratorsViewModel : BindableBase
    {
        public List<CategoryList> orators { get; set; }
        INavigationService _navigation;
        public OratorsViewModel(INavigationService navigationService)
        {
            _navigation = navigationService;
            getCategory();
        }

        public async Task getCategory()
        {
            var remoteContent = new CategoryService();
            var result = await remoteContent.getCategory();
            orators = result.ToList()[0].CategoryList;
            RaisePropertyChanged("orators");
        }
    }
}
