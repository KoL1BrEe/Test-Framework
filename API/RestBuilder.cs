using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serializers;
using RestSharp.Serializers.NewtonsoftJson;
using Client = RestSharp.RestClient;

namespace ApiTestLearning.ApiManager
{
    public class RestBuilder
    {
        private RestRequest _restRequest;
        private readonly JsonSerializerSettings _newtonSoftSerializerSettings;
        private readonly string _baseUri;
        public RestBuilder(string baseUri)
        {
            _baseUri = baseUri;
            _newtonSoftSerializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DefaultValueHandling = DefaultValueHandling.Include,
                TypeNameHandling = TypeNameHandling.None,
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            };
            _restRequest = new RestRequest();
        }


        public RestBuilder AddAuthorizationHeader(string token)
        {
            return AddHeader("Authorization", $"Bearer {token}");
        }
        public RestBuilder AddBody(object contractObject)
        {
            _restRequest.AddBody(contractObject);
            return this;
        }
        public RestBuilder AddHeader(string key, string value)
        {
            _restRequest.AddHeader(key, value);
            return this;
        }

        public RestBuilder Method(Method method)
        {
            _restRequest.Method = method;
            return this;
        }

        public RestBuilder ToEndPoint(string resource)
        {
            _restRequest.Resource = resource;
            return this;
        }

        public async Task<RestResponse<T>> Exec<T>(RestClient client, RestRequest request) where T : new()
        {
            return await client.ExecuteAsync<T>(request);
        }
        private Client GetRestClient()
        {
            var restClient = new Client(_baseUri);
            SerializerConfig config = new SerializerConfig();
            config.UseNewtonsoftJson(_newtonSoftSerializerSettings);
            return restClient;
        }
        public async Task<RestResponse<T>> ExecAsync<T>() where T : new()
        {
            return await Exec<T>(GetRestClient());
        }

        public async Task<RestResponse<T>> Exec<T>(Client client) where T : new()
        {
            RestResponse<T> response = default;

            response = await Exec<T>(client, _restRequest);

            return response;
        }
    }
}
