namespace AutoMoreira.Base.Lib.Grpc.Base.Response
{
    [DataContract]
    public class BaseResponseListGrpc
    {
        [DataMember(Order = 1)]
        public List<BaseResponseGrpc> Responses { get; set; } = new();
    }
}
