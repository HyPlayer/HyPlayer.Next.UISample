using CommunityToolkit.Mvvm.ComponentModel;
using HyPlayer.Next.UISample.Services;
using HyPlayer.Next.UISample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace HyPlayer.Next.UISample.Interfaces;
public interface IPageCache<T>
{
    public NavigationParameter NavigateParameter { get; set; }
}
