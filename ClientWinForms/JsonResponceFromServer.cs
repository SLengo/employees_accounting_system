using Newtonsoft.Json;
namespace ClientWinForms
{
    class JsonResponceFromServer
    {
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
