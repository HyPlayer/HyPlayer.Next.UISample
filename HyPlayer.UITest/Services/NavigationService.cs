using HyPlayer.UITest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace HyPlayer.UITest.Services;
public static class NavigationService
{
    public static Frame Frame;
    public static void Initialize(Frame frame)
    {
        Frame = frame;
    }
    public static void Navigate(Type pageType, object parameter = null, NavigationTransitionInfo infoOverride = null, bool clearNavigation = false)
    {
        Frame.Navigate(pageType,parameter,infoOverride);    
    }
    
    public static void GoBack()
    {
        Frame.GoBack();
    }

}
public class NavigationParameter
{
    public ViewModelBase ViewModel;
    public object Parameter;
}


