namespace AutoMoreira.Base.Lib.Grpc.Base.Request
{
    [DataContract]
    public class BaseRequestGrpc
    {
        [DataMember(Order = 1)]
        public long Id { get; set; }
    }
}
