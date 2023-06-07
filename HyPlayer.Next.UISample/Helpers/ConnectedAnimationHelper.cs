using CommunityToolkit.Mvvm.ComponentModel;
using HyPlayer.Next.UISample.Interfaces;
using HyPlayer.Next.UISample.ViewModels;
using HyPlayer.Next.UISample.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Composition;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace HyPlayer.Next.UISample.Helpers;

public static class ConnectedAnimationHelper
{
    public static void PlayBackAnimation(UIElement element)
    {
        var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("backAnimation");
        animation?.TryStart(element);
    }
    public static void PlayBackAnimation(ListViewBase listElement, int index)
    {
        var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("backAnimation");
        var container = listElement.ContainerFromIndex(index);
        animation?.TryStart((UIElement)container);
    }
    public static void PlayForwardAnimation(UIElement element)
    {
        var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("forwardAnimation");
        animation?.TryStart(element);
    }
    public static void PrepareForwardAnimation(IConnectedViewModel viewModel,FrameworkElement element)
    {
        viewModel.ConnectedElementName = element.Name;

        ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("forwardAnimation", element);
    }
    public static void PrepareForwardAnimation(IConnectedViewModel viewModel, ListViewBase listElement, object clicked/*Clicked Item*/)
    {
        viewModel.ConnectedElementName = listElement.Name;
        var container = listElement.ContainerFromItem(clicked);
        viewModel.ConnectedItemIndex = listElement.IndexFromContainer(container);
        ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("forwardAnimation", (UIElement)container);
    }
    public static void PrepareBackAnimation(UIElement element)
    {
        var animation = ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("backAnimation", element);
        animation.Configuration = new DirectConnectedAnimationConfiguration();
    }
}

