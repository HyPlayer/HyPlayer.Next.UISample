using HyPlayer.Next.UISample.Interfaces;
using HyPlayer.Next.UISample.Services;
using HyPlayer.Next.UISample.ViewModels;
using HyPlayer.Next.UISample.Views.MenuPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace HyPlayer.Next.UISample.Views;
public sealed partial class ShellPage : Page
{
    public ShellPageVM ViewModel;
    public ShellPage()
    {
        this.InitializeComponent();
        NavigationService.Initialize(MainFrame);
        ViewModel = new();
        MainFrame.Navigate(typeof(MainPage),new MainPageVM("SONGNAME","AAA"));
        Window.Current.SetTitleBar(AppTitleBar);
    }
    private void NavigationView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
    {
        ViewModel.GoBack();
    }
}

