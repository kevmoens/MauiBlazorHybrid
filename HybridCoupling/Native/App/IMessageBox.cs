using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCoupling.Native.App
{
    public interface IMessageBox
    {
        Task<string> Show(string message);
    }
}
