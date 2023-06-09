using HyPlayer.Next.UISample.Interfaces;
using HyPlayer.Next.UISample.Services;
using HyPlayer.Next.UISample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace HyPlayer.Next.UISample.Views.Base;
public class CachePageBase<TViewModel>:Page where TViewModel: class,new()
{
    public TViewModel ViewModel { get; set; }

    //public NavigationParameter NavigateParameter { get; set; }
    protected NavigationEventArgs _navigationEventArgs;

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        Loaded += OnPageLoaded;
        Unloaded += OnPageUnloaded;
        _navigationEventArgs = e;
        var vm = e.Parameter as TViewModel;

        if (vm != null)
        {
            ReadCache(vm);
        }
        else
        {
            ViewModel = new TViewModel();//创建新的ViewModel
        }
    }
    protected virtual void OnPageLoaded(object sender, RoutedEventArgs e)
    {
        Loaded -= OnPageLoaded;
    }

    protected virtual void OnPageUnloaded(object sender, RoutedEventArgs e)
    {

    }

    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
        base.OnNavigatedFrom(e);
        Cache();
    }
    /// <summary>
    /// 缓存当前页面
    /// </summary>
    protected virtual void Cache()
    {
        ViewModel = ViewModel;
    }
    /// <summary>
    /// 读取当前页面的缓存
    /// </summary>
    /// <param name="e"></param>
    protected virtual void ReadCache(TViewModel vm)
    {
        ViewModel = vm;
    }
}

