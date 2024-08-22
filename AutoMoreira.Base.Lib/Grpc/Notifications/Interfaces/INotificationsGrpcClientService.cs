namespace AutoMoreira.Base.Lib.Grpc.Notifications.Interfaces
{
    public interface INotificationsGrpcClientService
    {
        Task SendWelcomeEmailAsync(SendWelcomeEmailRequestGrpc request);

        Task SendUserProfileUpdatedEmailAsync(SendUserProfileUpdatedEmailRequestGrpc request);

        Task SendPasswordChangedEmailAsync(SendPasswordChangedEmailRequestGrpc request);

        Task SendPasswordResetEmailAsync(SendPasswordResetEmailRequestGrpc request);
    }
}
