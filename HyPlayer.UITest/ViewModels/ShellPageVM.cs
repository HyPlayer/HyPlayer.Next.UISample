using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HyPlayer.UITest.Interfaces;
using HyPlayer.UITest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyPlayer.UITest.ViewModels;
public partial class ShellPageVM : ViewModelBase
{

    [RelayCommand]
    public void GoBack()
    {
        NavigationService.GoBack();
    }
}

