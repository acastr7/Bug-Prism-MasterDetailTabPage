using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace MasterDetailTabPageBug.ViewModels
{
	public class PageBViewModel : ViewModelBase
	{
	    public PageBViewModel(INavigationService navigationService) : base(navigationService)
	    {
	        Title = "Page B";
        }
    }
}
