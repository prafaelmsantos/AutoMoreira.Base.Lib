using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace AutoMoreira.Base.Lib.Host
{
    public static class KestrelExtension
    {
        public static IWebHostBuilder SetKestrelOptions(this IWebHostBuilder builder, bool withHttps = false, bool withGRPC = false)
        {
            int httpPort = 80;
            int httpsPort = 443;
            int grpcServerPort = 81;

            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? string.Empty;

            IConfigurationRoot configfile = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile($"appsettings.json", optional: false)
                             .AddEnvironmentVariables()
                             .Build();

            if (!string.IsNullOrWhiteSpace(environment))
            {
                configfile = new ConfigurationBuilder()
                                     .SetBasePath(Directory.GetCurrentDirectory())
                                     .AddJsonFile($"appsettings.json", optional: false)
                                     .AddJsonFile($"appsettings.{environment}.json", optional: false)
                                     .AddEnvironmentVariables()
                                     .Build();
            }
            if (configfile.GetValue<int>("HttpPort") > 0)
            {
                httpPort = configfile.GetValue<int>("HttpPort");
            }
            if (configfile.GetValue<int>("HttpsPort") > 0)
            {
                httpsPort = configfile.GetValue<int>("HttpsPort");
            }
            if (configfile.GetValue<int>("GrpcServerPort") > 0)
            {
                grpcServerPort = configfile.GetValue<int>("GrpcServerPort");
            }

            builder.ConfigureKestrel(serverOptions =>
            {
                serverOptions.AddServerHeader = false;
                serverOptions.ListenAnyIP(httpPort, listenOptions =>
                {
                    listenOptions.Protocols = HttpProtocols.Http1;
                });

                if (withHttps)
                {
                    serverOptions.ListenAnyIP(httpsPort, listenOptions =>
                    {
                        listenOptions.UseHttps();
                    });
                }

                if (withGRPC)
                {
                    serverOptions.ListenAnyIP(grpcServerPort, listenOptions =>
                    {
                        listenOptions.Protocols = HttpProtocols.Http2;
                    });
                }
            });

            return builder;
        }

    }
}
