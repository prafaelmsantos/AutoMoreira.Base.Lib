namespace AutoMoreira.Base.Lib.Grpc.Notifications.Models.SendClientEmail.Request
{
    [DataContract]
    public class SendClientEmailRequestGrpc
    {
        [DataMember(Order = 1)]
        public string Name { get; set; } = null!;

        [DataMember(Order = 2)]
        public string Address { get; set; } = null!;
    }
}
