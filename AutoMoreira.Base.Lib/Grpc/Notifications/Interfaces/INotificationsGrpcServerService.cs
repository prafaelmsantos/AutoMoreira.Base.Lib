namespace AutoMoreira.Base.Lib.Grpc.Notifications.Interfaces
{
    [ServiceContract]
    public interface INotificationsGrpcServerService
    {
        [OperationContract]
        Task SendWelcomeEmailAsync(SendWelcomeEmailRequestGrpc request, CallContext context = default);

        [OperationContract]
        Task SendUserProfileUpdatedEmailAsync(SendUserProfileUpdatedEmailRequestGrpc request, CallContext context = default);

        [OperationContract]
        Task SendPasswordChangedEmailAsync(SendPasswordChangedEmailRequestGrpc request, CallContext context = default);

        [OperationContract]
        Task SendPasswordResetEmailAsync(SendPasswordResetEmailRequestGrpc request, CallContext context = default);
    }
}
