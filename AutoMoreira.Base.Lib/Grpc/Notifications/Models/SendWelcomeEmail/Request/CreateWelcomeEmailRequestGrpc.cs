namespace AutoMoreira.Base.Lib.Grpc.Notifications.Models.SendWelcomeEmail.Request
{
    [DataContract]
    public class SendWelcomeEmailRequestGrpc
    {
        [DataMember(Order = 1)]
        public string Name { get; set; } = null!;

        [DataMember(Order = 2)]
        public string Address { get; set; } = null!;

        [DataMember(Order = 3)]
        public string Password { get; set; } = null!;
    }
}
