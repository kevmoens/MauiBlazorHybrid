using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBlazorHybrid.Coupling.App
{
    internal static class MessageBoxResultAdapter
    {
        public static string ToMessageString(this MessageBoxResult result)
        {
            return result switch
            {
                MessageBoxResult.None => "None",
                MessageBoxResult.OK => "OK",
                MessageBoxResult.Cancel => "Cancel",
                MessageBoxResult.Yes => "Yes",
                MessageBoxResult.No => "No",
                _ => throw new ArgumentOutOfRangeException(nameof(result), result, null)
            };
        }
    }
}
