namespace AutoMoreira.Base.Lib.Grpc.Notifications.ServicesRegistry
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddAuthorizationGrpcService(this IServiceCollection services)
        {
            return services.AddNotificationsGrpcService(services.BuildServiceProvider().GetRequiredService<IConfiguration>());
        }
        private static IServiceCollection AddNotificationsGrpcService(this IServiceCollection services, IConfiguration configuration)
        {

            /*MethodConfig defaultMethodConfig = new()
            {
                Names = { MethodName.Default },
                RetryPolicy = new RetryPolicy
                {
                    MaxAttempts = configuration.GetValue<int>("GrpcClient:BackOff:MaxAttempts").GetEnvironment("GRPCCLIENT_BACKOFF_MAXATTEMPTS"),
                    InitialBackoff = TimeSpan.FromSeconds(configuration.GetValue<int>("GrpcClient:BackOff:InitialBackoff").GetEnvironment("GRPCCLIENT_BACKOFF_INITIALBACKOFF")),
                    MaxBackoff = TimeSpan.FromSeconds(configuration.GetValue<int>("GrpcClient:BackOff:MaxBackoff").GetEnvironment("GRPCCLIENT_BACKOFF_MAXBACKOFF")),
                    BackoffMultiplier = configuration.GetValue<double>("GrpcClient:BackOff:BackoffMultiplier").GetEnvironment("GRPCCLIENT_BACKOFF_BACKOFFMULTIPLIER"),
                    RetryableStatusCodes = { StatusCode.Unavailable, StatusCode.Internal }
                }
            };

            string grpcUrl = configuration.GetValue<string>("GrpcClient:Authorization:Url").GetEnvironment("GRPCCLIENT_AUTHORIZATION_URL");
            services.AddCodeFirstGrpcClient<INotificationsGrpcServerService>(o =>
            {
                o.Address = new Uri(grpcUrl);
                o.ChannelOptionsActions.Add(channelOptions => channelOptions.ServiceConfig = new ServiceConfig
                {
                    MethodConfigs = { defaultMethodConfig }
                });
            });*/
            services.AddScoped<INotificationsGrpcClientService, NotificationsGrpcClientService>();
            return services;
        }
    }
}