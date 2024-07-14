namespace AutoMoreira.Base.Lib.Grpc.Notifications.Services
{
    public class NotificationsGrpcClientService : INotificationsGrpcClientService
    {
        #region Vars
        private readonly INotificationsGrpcServerService _notificationsGrpcServerService;
        #endregion

        #region Constructors
        public NotificationsGrpcClientService(INotificationsGrpcServerService notificationsGrpcServerService)
        {
            _notificationsGrpcServerService = notificationsGrpcServerService;
        }
        #endregion

        #region Public methods
        public async Task SendWelcomeEmailAsync(SendWelcomeEmailRequestGrpc request)
        {
            await _notificationsGrpcServerService.SendWelcomeEmailAsync(request);
        }

        public async Task SendUserProfileUpdatedEmailAsync(SendUserProfileUpdatedEmailRequestGrpc request)
        {
            await _notificationsGrpcServerService.SendUserProfileUpdatedEmailAsync(request);
        }

        public async Task SendClientEmailAsync(SendClientEmailRequestGrpc request)
        {
            await _notificationsGrpcServerService.SendClientEmailAsync(request);
        }

        public async Task SendPasswordChangedEmailAsync(SendPasswordChangedEmailRequestGrpc request)
        {
            await _notificationsGrpcServerService.SendPasswordChangedEmailAsync(request);
        }

        public async Task SendPasswordResetEmailAsync(SendPasswordResetEmailRequestGrpc request)
        {
            await _notificationsGrpcServerService.SendPasswordResetEmailAsync(request);
        }

        #endregion
    }
}
