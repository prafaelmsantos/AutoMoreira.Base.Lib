namespace AutoMoreira.Base.Lib.Grpc.Base.Request
{
    [DataContract]
    public class BaseRequestListGrpc
    {
        [DataMember(Order = 1)]
        public List<long> Ids { get; set; } = new();
    }
}
