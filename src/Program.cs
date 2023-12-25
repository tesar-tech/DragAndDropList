using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DragAndDropList;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

public static class WebsiteKeys
{
    public const string GitHubRepo = "https://github.com/tesar-tech/DragAndDropList";
    public const string Twitter = "https://twitter.com/";
    public const string Title = "Blazor Drag and Drop List";

}
