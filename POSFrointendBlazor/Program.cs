using POSFrontendBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var connectedApiAddress = "https://localhost:7051";
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(connectedApiAddress) });
builder.Services.AddScoped<HttpClientService>();
builder.Services.AddScoped<InjectService>();
builder.Services.AddMudServices();
await builder.Build().RunAsync();
