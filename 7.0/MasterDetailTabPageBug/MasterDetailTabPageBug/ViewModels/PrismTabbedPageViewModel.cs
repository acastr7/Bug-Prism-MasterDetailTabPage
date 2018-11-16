using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace MasterDetailTabPageBug.ViewModels
{
	public class PrismTabbedPageViewModel : ViewModelBase
	{
	    public PrismTabbedPageViewModel(INavigationService navigationService) : base(navigationService)
	    {
	    }
	}
}
