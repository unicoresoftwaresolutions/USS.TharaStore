namespace USS.TharaStore.Service
{
    public class MainHTTPClient
    {
        public readonly HttpClient client;
        public MainHTTPClient(HttpClient http)
        {
            client = http;
        }

    }
}
