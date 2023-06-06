using HyPlayer.Next.UISample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace HyPlayer.Next.UISample.Views.Base;

public abstract class ConnectedPageBase<TViewModel> : ScrollPageBase<TViewModel> where TViewModel : ViewModelBase, new()
{
    public abstract UIElement GetConnectedElement();
    public override void PageLoaded(object sender, RoutedEventArgs e)
    {
        ConnectedAnimation animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("forwardAnimation");
        if (animation != null)
        {
            animation.TryStart(GetConnectedElement());
        }
        base.PageLoaded(sender, e);
    }
    protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
    {
        if (e.NavigationMode == NavigationMode.Back)
        {
            ConnectedAnimation animation =
                ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("backAnimation", GetConnectedElement());

            animation.Configuration = new DirectConnectedAnimationConfiguration();
        }
        base.OnNavigatingFrom(e);
    }
}

