using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace HyPlayer.UITest.Services; 
public static class InitializeService
{
    public static void InitializeApp()
    {
        InitializeTitleBar();
    }
    public static void InitializeTitleBar()
    {
        var view = ApplicationView.GetForCurrentView();
        CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
        view.TitleBar.BackgroundColor = Colors.Transparent;
        view.TitleBar.InactiveBackgroundColor = Colors.Transparent;
        view.TitleBar.ButtonBackgroundColor = Colors.Transparent;
        view.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
    }
}
