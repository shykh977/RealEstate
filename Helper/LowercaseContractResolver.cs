using Newtonsoft.Json.Serialization;

namespace PropertyBackend.Helper
{
    public class LowercaseContractResolver : DefaultContractResolver
    {

        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName;//.ToLower();
        }

    }
}
