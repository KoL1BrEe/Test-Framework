using ApiTestLearning.ApiManager;
using RestSharp;

namespace ApiTestLearning
{
    public abstract class BaseApiManager
    {
        public BaseApiManager(string baseUri)
        {
            _baseUri = baseUri;
        }
        protected readonly string _baseUri;
        protected RestBuilder Get(string token = default)
        {
            var request = new RestBuilder(_baseUri)
                .Method(Method.Get);

            if (token != null)
            {
                request.AddAuthorizationHeader(token);
            }
            return request;
        }
        protected RestBuilder Post(string token = default)
        {
            var request = new RestBuilder(_baseUri)
                .Method(Method.Post);
            if (token != null)
            {
                request.AddAuthorizationHeader(token);
            }
            return request;
        }

        protected RestBuilder Put(string token = default)
        {
            var request = new RestBuilder(_baseUri)
                .Method(Method.Put);

            if (token != null)
            {
                request.AddAuthorizationHeader(token);
            }
            return request;
        }

        protected RestBuilder Delete(string token = default)
        {
            var request = new RestBuilder(_baseUri)
                .Method(Method.Delete);

            if (token != null)
            {
                request.AddAuthorizationHeader(token);
            }
            return request;
        }
    }
}
