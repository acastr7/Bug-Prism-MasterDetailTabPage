using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterDetailTabPageBug.ViewModels
{
	public class PageCViewModel : ViewModelBase
	{
        public PageCViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Page C";
        }
    }
}
