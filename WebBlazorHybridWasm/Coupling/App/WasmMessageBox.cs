using HybridCoupling.Native.App;
using MudBlazor;

namespace WebBlazorHybridWasm.Coupling.App
{
    public class WasmMessageBox : IMessageBox
    {
        private IDialogService _dialogService;

        public WasmMessageBox(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }
        public async Task<string> Show(string message)
        {

            bool? result = await _dialogService.ShowMessageBox("Warning", message);
            return "OK";
            
        }
    }
}
