using System;

namespace Nagraj.Authentication.External
{
    public class ExternalLoginProviderInfo
    {
        public string Name { get; set; }

        public string ContactId { get; set; }

        public string ContactSecret { get; set; }

        public Type ProviderApiType { get; set; }

        public ExternalLoginProviderInfo(string name, string clientId, string clientSecret, Type providerApiType)
        {
            Name = name;
            ContactId = clientId;
            ContactSecret = clientSecret;
            ProviderApiType = providerApiType;
        }
    }
}
