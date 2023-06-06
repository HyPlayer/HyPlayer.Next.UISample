using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyPlayer.Next.UISample.Interfaces;

public interface IConnectedViewModel
{
    /// <summary>
    /// 编号
    /// </summary>
    int ConnectedItemId { get; set; }
    /// <summary>
    /// 元素名称
    /// </summary>
    string ConnectedElementName { get; set; }
}

