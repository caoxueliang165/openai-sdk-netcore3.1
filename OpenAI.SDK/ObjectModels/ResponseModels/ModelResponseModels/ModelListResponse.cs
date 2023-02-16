using System.Text.Json.Serialization;

namespace OpenAI.GPT3.ObjectModels.ResponseModels.ModelResponseModels
{
    public class ModelListResponse : BaseResponse
    {
        [JsonPropertyName("data")] public List<ModelResponse> Models { get; set; }
    }
}