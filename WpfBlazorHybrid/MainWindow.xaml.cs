using BlazorShared;
using HybridCoupling.Native.App;
using Microsoft.AspNetCore.Components.WebView.Wpf;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfBlazorHybrid.Coupling.App;

namespace WpfBlazorHybrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] _fileData = [];
        public MainWindow()
        {
            InitializeComponent();


            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddBlazorShared();
            serviceCollection.AddMudServices();
            serviceCollection.AddTransient<IMessageBox, WpfMessageBox>();
            Resources.Add("services", serviceCollection.BuildServiceProvider());


        }


        private void Window_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
                _fileData = (string[])e.Data.GetData(DataFormats.FileDrop);
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = true;
        }
    }
}