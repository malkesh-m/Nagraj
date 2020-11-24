using Abp.AutoMapper;
using Nagraj.Authentication.External;

namespace Nagraj.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ContactId { get; set; }
    }
}
