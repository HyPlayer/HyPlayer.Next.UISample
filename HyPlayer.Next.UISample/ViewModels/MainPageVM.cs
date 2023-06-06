﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HyPlayer.Next.UISample.Interfaces;
using HyPlayer.Next.UISample.Services;
using HyPlayer.Next.UISample.Views.MenuPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;

namespace HyPlayer.Next.UISample.ViewModels;
public partial class MainPageVM:ViewModelBase, IConnectedViewModel
{
    public int ConnectedItemId { get; set; }
    public string ConnectedElementName { get ; set; }

    [ObservableProperty]
    private string songName;
    [ObservableProperty]
    private string artist;

    public MainPageVM()
    {

    }
    public MainPageVM(string songName,string artist)
    {
        SongName = songName;
        Artist = artist;
    }
    [RelayCommand]
    public void ChangeSong()
    {
        SongName = "UpdatedSongName";
        Artist = "UpdatedArtist";
    }
    [RelayCommand]
    public void OpenSongList()
    {
        NavigationService.Navigate(typeof(SongListPage),new SongListPageVM());
    }
}
