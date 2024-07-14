namespace AutoMoreira.Base.Lib.Grpc.Base.Response
{
    [DataContract]
    public class BaseResponseGrpc
    {
        [DataMember(Order = 1)]
        public long Id { get; set; }

        [DataMember(Order = 2)]
        public bool Success { get; set; }

        [DataMember(Order = 3)]
        public string? ErrorMessage { get; set; }
    }
}
