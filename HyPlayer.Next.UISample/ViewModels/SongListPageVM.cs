using HyPlayer.Next.UISample.Interfaces;
using HyPlayer.Next.UISample.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyPlayer.Next.UISample.ViewModels;

public class SongListPageVM : IScrollableViewModel , IConnectedViewModel
{
    public double ScrollValue { get; set; }
    public int? ConnectedItemIndex { get; set; }
    public string ConnectedElementName { get; set; }
}

