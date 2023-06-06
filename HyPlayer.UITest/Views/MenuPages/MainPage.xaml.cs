using HyPlayer.UITest.Interfaces;
using HyPlayer.UITest.Services;
using HyPlayer.UITest.ViewModels;
using HyPlayer.UITest.Views.Base;
using Microsoft.Toolkit.Uwp.UI;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace HyPlayer.UITest.Views.MenuPages;
/// <summary>
/// 可用于自身或导航至 Frame 内部的空白页。
/// </summary>
public sealed partial class MainPage : MainPageBase
{
    public MainPage() => InitializeComponent();
    public override ScrollViewer GetScrollViewer() => MainScrollViewer;

    private bool _isBack;
    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        SongView.ItemClick += SongListItemClicked;
        LeaderBoardView.ItemClick += SongListItemClicked;
        if(e.NavigationMode == NavigationMode.Back)
        {
            _isBack = true;
        }
    }
    public override async void PageLoaded(object sender, RoutedEventArgs e)
    {
        base.PageLoaded(sender, e);
        await Task.Delay(1);
        if (!_isBack)
            return;
        var element = FindName(ViewModel.ConnectedElementName);
        var item = ((ListViewBase)element).ContainerFromIndex(ViewModel.ConnectedItemId);
        ConnectedAnimation animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("backAnimation");
        if (animation != null)
        {
            animation.TryStart((UIElement)((GridViewItem)item).Content);
        }

    }

    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
        base.OnNavigatedFrom(e);
        SongView.ItemClick -= SongListItemClicked;
    }
    private void SongListItemClicked(object sender, ItemClickEventArgs e)
    { 
        ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("forwardAnimation", e.ClickedItem as UIElement);
        var view = (ListViewBase)sender;
        var container = view.ContainerFromItem(e.ClickedItem);
        ViewModel.ConnectedItemId = view.IndexFromContainer(container);
        ViewModel.ConnectedElementName = view.Name;
    }
}
public abstract class MainPageBase : ScrollPageBase<MainPageVM>
{

}
