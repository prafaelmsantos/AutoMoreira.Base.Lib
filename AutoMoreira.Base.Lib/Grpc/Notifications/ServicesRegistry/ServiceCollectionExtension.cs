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

            MethodConfig defaultMethodConfig = new()
            {
                Names = { MethodName.Default },
                RetryPolicy = new RetryPolicy
                {
                    MaxAttempts = 5,
                    InitialBackoff = TimeSpan.FromSeconds(1),
                    MaxBackoff = TimeSpan.FromSeconds(5),
                    BackoffMultiplier = 1.5,
                    RetryableStatusCodes = { StatusCode.Unavailable, StatusCode.Internal }
                }
            };

            services.AddCodeFirstGrpcClient<INotificationsGrpcServerService>(o =>
            {
                o.Address = new Uri("http://localhost:81");
                o.ChannelOptionsActions.Add(channelOptions => channelOptions.ServiceConfig = new ServiceConfig
                {
                    MethodConfigs = { defaultMethodConfig }
                });
            });

            services.AddScoped<INotificationsGrpcClientService, NotificationsGrpcClientService>();
            return services;
        }
    }
}