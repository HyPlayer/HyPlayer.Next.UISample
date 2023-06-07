using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyPlayer.Next.UISample.ViewModels.Interfaces;

public interface IScrollableViewModel
{
    double ScrollValue { get; set; }
}

