using HyPlayer.Next.UISample.ViewModels;
using HyPlayer.Next.UISample.Views.Base;
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


namespace HyPlayer.Next.UISample.Views.MenuPages;

public sealed partial class SongListPage : SongListPageBase
{
    public SongListPage()
    {
        this.InitializeComponent();
    }

    public override UIElement GetConnectedElement() => AlbumImage;
    public override ScrollViewer GetScrollViewer() => MainScrollViewer;
}
public abstract class SongListPageBase : ConnectedPageBase<SongListPageVM>
{

}


