using System.Text.Json.Serialization;
using OpenAI.GPT3.ObjectModels.SharedModels;

namespace OpenAI.GPT3.ObjectModels.ResponseModels.FineTuneResponseModels
{
    public class FineTuneListEventsResponse : BaseResponse
    {
        [JsonPropertyName("data")] public List<EventResponse> Data { get; set; }
    }
}