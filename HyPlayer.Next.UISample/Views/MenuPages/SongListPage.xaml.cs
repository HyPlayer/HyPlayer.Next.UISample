using HyPlayer.Next.UISample.Helpers;
using HyPlayer.Next.UISample.ViewModels;
using HyPlayer.Next.UISample.Views.Base;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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


namespace HyPlayer.Next.UISample.Views.MenuPages;

public sealed partial class SongListPage : SongListPageBase
{
    public SongListPage()
    {
        this.InitializeComponent();
    }

    protected override async void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        await Task.Delay(1);
        if(e.NavigationMode == NavigationMode.New)//到达当前页面,播放动画
        {           
            ConnectedAnimationHelper.PlayForwardAnimation(AlbumImage);
        }
    }
    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
        base.OnNavigatedFrom(e);
        ConnectedAnimationHelper.PrepareBackAnimation(AlbumImage);
    }
    //public override UIElement GetConnectedElement() => AlbumImage;
    public override ScrollViewer GetScrollViewer() => MainScrollViewer;
}
public abstract class SongListPageBase : ScrollPageBase<SongListPageVM>
{

}


