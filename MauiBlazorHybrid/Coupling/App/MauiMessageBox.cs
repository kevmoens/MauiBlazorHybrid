using HybridCoupling.Native.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorHybrid.Coupling.App
{
    public class MauiMessageBox : IMessageBox
    {
        public async Task<string> Show(string message)
        {
            await Application.Current!.MainPage!.DisplayAlert("Warning", message, "OK");
            return "OK";
        }
    }
}
