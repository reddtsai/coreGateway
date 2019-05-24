# coreGateway

## Start

```bash
dotnet new web
dotnet add package Ocelot
```

```c#
public void ConfigureServices(IServiceCollection services)
{
    services.AddOcelot(Configuration);
}
```

```c#
public void Configure(IApplicationBuilder app)
{
    app.UseOcelot().Wait();
}
```