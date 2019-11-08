namespace CM.Text.Common
{
    public static class Constant
    {
        internal static readonly string TextSdkReference = "text-sdk-dotnet-" +
                                                           typeof(TextClient).Assembly.GetName()
                                                               .Version;
        public const string BusinessMessagingGatewayJsonEndpoint = "https://gw.cmtelecom.com/v1.0/message";
    }
}
