using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrieTechnologies.Razor.Vibration
{
    public class VibrationService: IAsyncVibrationService
    {
        private readonly IJSRuntime jSRuntime;
        private const string vibrateFunction = "window.CurrieTechnologies.Razor.Vibration.Vibrate";
        private const string supportFunction = "window.CurrieTechnologies.Razor.Vibration.VibrationSupported";
        public VibrationService(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        /// <summary>
        /// The VibrateAsync() method pulses the vibration hardware on the device, if such hardware exists.
        /// If the device doesn't support vibration, this method has no effect.
        /// If a vibration pattern is already in progress when this method is called, the previous pattern is halted and the new one begins instead.
        /// <para>
        /// If the method was unable to vibrate because of invalid parameters, it will return false, else it returns true.
        /// If the pattern leads to a too long vibration, it is truncated: the max length depends on the implementation.
        /// </para>
        /// </summary>
        /// <param name="duration">Vibrate once for that many milliseconds</param>
        /// <returns>
        /// If the method was unable to vibrate because of invalid parameters, it will return false, else it returns true.
        /// If the pattern leads to a too long vibration, it is truncated: the max length depends on the implementation.
        /// </returns>
        public Task<bool> VibrateAsync(int duration)
        {
            return this.jSRuntime.InvokeAsync<bool>(vibrateFunction, duration);
        }

        /// <summary>
        /// The VibrateAsync() method pulses the vibration hardware on the device, if such hardware exists.
        /// If the device doesn't support vibration, this method has no effect.
        /// If a vibration pattern is already in progress when this method is called, the previous pattern is halted and the new one begins instead.
        /// <para>
        /// If the method was unable to vibrate because of invalid parameters, it will return false, else it returns true.
        /// If the pattern leads to a too long vibration, it is truncated: the max length depends on the implementation.
        /// </para>
        /// </summary>
        /// <param name="pattern">Provides a pattern of vibration and pause intervals.
        /// Each value indicates a number of milliseconds to vibrate or pause, in alternation.
        /// An array of values to alternately vibrate, pause, then vibrate again.</param>
        /// <returns>
        /// If the method was unable to vibrate because of invalid parameters, it will return false, else it returns true.
        /// If the pattern leads to a too long vibration, it is truncated: the max length depends on the implementation.
        /// </returns>
        public Task<bool> VibrateAsync(IEnumerable<int> pattern)
        {
            return this.jSRuntime.InvokeAsync<bool>(vibrateFunction, pattern);
        }

        public Task<bool> BrowserSupportsVibrationAsync()
        {
            return this.jSRuntime.InvokeAsync<bool>(supportFunction);
        }
    }
}
