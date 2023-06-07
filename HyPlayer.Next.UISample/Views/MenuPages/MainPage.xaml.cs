using HyPlayer.Next.UISample.Interfaces;
using HyPlayer.Next.UISample.Services;
using HyPlayer.Next.UISample.ViewModels;
using HyPlayer.Next.UISample.Views.Base;
using Microsoft.Toolkit.Uwp.UI;
using Microsoft.Toolkit.Uwp.UI.Animations;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using ConnectedAnimationHelper = HyPlayer.Next.UISample.Helpers.ConnectedAnimationHelper;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace HyPlayer.Next.UISample.Views.MenuPages;
/// <summary>
/// 可用于自身或导航至 Frame 内部的空白页。
/// </summary>
public sealed partial class MainPage : MainPageBase
{
    public MainPage() => InitializeComponent();
    public override ScrollViewer GetScrollViewer() => MainScrollViewer;



    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
        base.OnNavigatedFrom(e);
        PlayListView.ItemClick -= ListItemClicked;
        LeaderboardView.ItemClick -= ListItemClicked;
    }

    protected override async void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        await Task.Delay(1);
        PlayListView.ItemClick += ListItemClicked;
        LeaderboardView.ItemClick += ListItemClicked;
        if (e.NavigationMode == NavigationMode.Back)//从上个页面返回到当前页面
        {
            var element = FindName(ViewModel.ConnectedElementName);
            if(element is ListViewBase listView)
            {
                ConnectedAnimationHelper.PlayBackAnimation(listView, ViewModel.ConnectedItemIndex.Value);
            }
            else
            {
                ConnectedAnimationHelper.PlayBackAnimation((UIElement)element);
            }
        }
    }


    private void ListItemClicked(object sender, ItemClickEventArgs e)
    {
        ConnectedAnimationHelper.PrepareForwardAnimation(ViewModel,(ListViewBase)sender, e.ClickedItem);
    }
}
public abstract class MainPageBase : ScrollPageBase<MainPageVM>
{

}
