interface Window {
  CurrieTechnologies: any;
}

namespace CurrieTechnologies.Razor.Vibration {
  declare var DotNet: any;

  window.CurrieTechnologies = window.CurrieTechnologies || {};
  window.CurrieTechnologies.Razor = window.CurrieTechnologies.Razor || {};
  window.CurrieTechnologies.Razor.Vibration =
    window.CurrieTechnologies.Razor.Vibration || {};

  window.CurrieTechnologies.Razor.Vibration.Vibrate = (
    pattern: number | number[],
  ): boolean => {
    return window.navigator.vibrate(pattern);
  };

  window.CurrieTechnologies.Razor.Vibration.VibrationSupported = (): boolean => {
    return window.navigator.vibrate !== undefined;
  };
}
