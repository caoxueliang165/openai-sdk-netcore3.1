using System.Text.Json.Serialization;

namespace OpenAI.GPT3.ObjectModels.ResponseModels.FineTuneResponseModels
{
    public class FineTuneListResponse : BaseResponse
    {
        [JsonPropertyName("data")] public List<FineTuneResponse> Data { get; set; }
    }
}