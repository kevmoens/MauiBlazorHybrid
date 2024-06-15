using HybridCoupling.Native.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBlazorHybrid.Coupling.App
{
    public class WpfMessageBox : IMessageBox
    {
        public Task<string> Show(string message)
        {
            var result = MessageBox.Show(message);
            
            return Task.FromResult<string>(result.ToMessageString());
        }

    }
}
