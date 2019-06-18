"use strict";
window.CurrieTechnologies = window.CurrieTechnologies || {};
window.CurrieTechnologies.Razor = window.CurrieTechnologies.Razor || {};
window.CurrieTechnologies.Razor.Vibration = window.CurrieTechnologies.Razor.Vibration || {};
window.CurrieTechnologies.Razor.Vibration.Vibrate = function (pattern) {
    return window.navigator.vibrate(pattern);
};
window.CurrieTechnologies.Razor.Vibration.VibrationSupported = function () {
    return window.navigator.vibrate !== undefined;
};
