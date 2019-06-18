using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CurrieTechnologies.Razor.Vibration
{
    interface IAsyncVibrationService
    {
        Task<bool> VibrateAsync(int duration);
        Task<bool> VibrateAsync(IEnumerable<int> pattern);
        Task<bool> BrowserSupportsVibrationAsync();
    }
}
