# coreGateway

This project is a Ocelot API Gateway on .net core 2.1

## Reference

Ocelot  

## Install and Setting

Create project

```bash  
dotnet new web  
```

Install package

```bash  
dotnet add package Ocelot  
```

Injection Ocelot (Startup.cs)

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

Configuration

```json
{
    "ReRoutes": [],
    "GlobalConfiguration": {}
}
```

ReRoute example

```json
{
    "DownstreamPathTemplate": "/api/test?paras=0",
    "DownstreamScheme": "https",
    "DownstreamHostAndPorts": [
        {
            "Host": "10.0.0.1",
            "Port": 443
        }
    ],
    "UpstreamPathTemplate": "/v1/api",
    "UpstreamHttpMethod": [ "Get" ],
    "UpstreamHost": "*.domain.com"
}
```

## Deploy

### Host on IIS

#### IIS

1. Install Hosting Bundle for Windows

2. Add Website

    ![Alt text](/doc/iis_website.png)

3. Edit Website Pool

    ![Alt text](/doc/iis_pool.png)

#### SSL

1. Getting an SSL certificate from a Certificate Authority

2. Install certificate

3. Import certificate

    ![Alt text](/doc/iis_certificate.png)

4. Binding a Website

    ![Alt text](/doc/iis_port.png)

    ![Alt text](/doc/iis_ssl.png)

    >SNI(Server Name Indication )
    >
    >if you needed SSL on the subdomain level of a current site/domain
    >
    >Check - Require Server Name Indication(需要伺服器名稱指示)
