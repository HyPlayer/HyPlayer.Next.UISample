using CommunityToolkit.Mvvm.ComponentModel;
using HyPlayer.UITest.Services;
using HyPlayer.UITest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace HyPlayer.UITest.Interfaces;
public interface IPageCache<T>
{
    public NavigationParameter NavigateParameter { get; set; }
}
