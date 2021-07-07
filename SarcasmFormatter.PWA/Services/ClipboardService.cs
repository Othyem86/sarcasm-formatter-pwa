using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace SarcasmFormatter.PWA.Services
{
    public class ClipboardService
    {
        public readonly IJSRuntime _JsRuntime;

        public ClipboardService(IJSRuntime jsRuntime)
        {
            _JsRuntime = jsRuntime;
        }

        public ValueTask WriteTextAsync(string text)
        {
            return _JsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
        }
    }
}
