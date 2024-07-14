namespace AutoMoreira.Base.Lib.Grpc.Notifications.Models.SendUserProfileUpdatedEmail.Request
{
    [DataContract]
    public class SendUserProfileUpdatedEmailRequestGrpc
    {
        [DataMember(Order = 1)]
        public string Name { get; set; } = null!;

        [DataMember(Order = 2)]
        public string Address { get; set; } = null!;
    }
}
