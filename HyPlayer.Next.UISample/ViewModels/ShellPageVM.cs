using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HyPlayer.Next.UISample.Interfaces;
using HyPlayer.Next.UISample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyPlayer.Next.UISample.ViewModels;
public partial class ShellPageVM :ObservableObject
{

    [RelayCommand]
    public void GoBack()
    {
        NavigationService.GoBack();
    }
}

