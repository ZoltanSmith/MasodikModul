namespace Idojaras.Model.Geo
{
    internal interface IGeocodingProvider
    {
        protected string BaseUrl { get; }
        protected HttpClient Client { get; set; }

        public abstract Task<HttpResponseMessage> GetCoordinatesByNameAsync(string location);
        public Coordinates GetCoordinatesByName(string location);
    }
}
