# CurrieTechnologies.Razor.Vibration
This package provides Blazor applications with access to the browser's [Vibration API](https://developer.mozilla.org/en-US/docs/Web/API/Vibration_API)

## This package is for Client-side and Server-side Blazor. [CurrieTechnologies.Blazor.Vibration](https://github.com/Basaingeal/Blazor.Vibration) is now deprecated.

## Usage
1) In your Blazor app, add the `CurrieTechnologies.Razor.Vibration` [NuGet package](https://www.nuget.org/packages/CurrieTechnologies.Razor.Vibration/)

    ```
    Install-Package CurrieTechnologies.Razor.Vibration
    ```

2) In your Blazor app's `Startup.cs`, register the 'VibrationService'.

    ```
    public void ConfigureServices(IServiceCollection services)
    {
        ...
        services.AddVibration();
        ...
    }
    ```

3) Add this script tag in  your root html file (Likely _Host.cshtml for Server-side Blazor or index.html for Client-side Blazor), right under the framework script tag. (i.e `<script src="_framework/blazor.server.js"></script>` for Server-side Blazor or `<script src="_framework/blazor.webassembly.js"></script>` for Client-side Blazor)
    ```html
    <script src="_content/CurrieTechnologies.Razor.Vibration/vibration.js"></script>
    ```

4) Now you can inject the VibrationService into any Blazor page and use it like this:

    ```
    @using CurrieTechnologies.Razor.Vibration
    @inject VibrationService vibrationService
    
    <button @onclick="async e => await vibrationService.VibrateAsync(1000)">Vibrate for 1 second</button>
    <button @onclick="async e => await vibrationService.VibrateAsync(new int[] { 200, 100, 200 })">
      Vibrate on and off
    </button>
    ```
