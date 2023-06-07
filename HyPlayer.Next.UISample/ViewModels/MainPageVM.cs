using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HyPlayer.Next.UISample.Interfaces;
using HyPlayer.Next.UISample.Models;
using HyPlayer.Next.UISample.Services;
using HyPlayer.Next.UISample.ViewModels.Interfaces;
using HyPlayer.Next.UISample.Views.MenuPages;
using Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarSymbols;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Animation;

namespace HyPlayer.Next.UISample.ViewModels;
public partial class MainPageVM 
    : ObservableObject , IScrollableViewModel , IConnectedViewModel
{
    public int? ConnectedItemIndex { get; set; }
    public string ConnectedElementName { get ; set; }
    public double ScrollValue { get; set; }

    [ObservableProperty]
    private List<Song> songs;
    [ObservableProperty]
    private List<PlayList> playLists;
    [ObservableProperty]
    private List<PlayList> leaderboards;

    [ObservableProperty]
    private string songName;
    [ObservableProperty]
    private string artist;
    public MainPageVM()
    {
        GetSongs();
    }
    public MainPageVM(string songName,string artist)
    {
        SongName = songName;
        Artist = artist;
        GetSongs();
    }
    [RelayCommand]
    public void GetSongs()
    {
        Songs = Song.CreateSampleList();
        PlayLists = PlayList.CreateSampleList();
        Leaderboards = PlayList.CreateSampleList();
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
        NavigationService.Navigate(typeof(SongListPage),new SongListPageVM(),new ContinuumNavigationTransitionInfo());
    }
}
