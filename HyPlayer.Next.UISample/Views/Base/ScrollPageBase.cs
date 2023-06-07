using HyPlayer.Next.UISample.Interfaces;
using HyPlayer.Next.UISample.ViewModels;
using HyPlayer.Next.UISample.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HyPlayer.Next.UISample.Views.Base;

public abstract class ScrollPageBase<TViewModel> : CachePageBase<TViewModel>
    where TViewModel : class, IScrollableViewModel, new()
{
    public abstract ScrollViewer GetScrollViewer();

    public override void PageLoaded(object sender, RoutedEventArgs e)
    {
        base.PageLoaded(sender, e);
        var scrollViewer = GetScrollViewer();
        scrollViewer.ChangeView(0, ViewModel.ScrollValue, 1,true);
    }
    public override void Cache()
    {
        base.Cache();
        var scrollViewer = GetScrollViewer();
        ViewModel.ScrollValue = scrollViewer.VerticalOffset;
    }
}

