using MinskGuide.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinskGuide.Core.Services
{
    public interface INavigationService
    {
        Task NavigateTo(BaseViewModel vm);
        Task NavigateTo(BaseViewModel vm, object parameter);
    }
}
