using System.Text.Json.Serialization;
using OpenAI.GPT3.ObjectModels.SharedModels;

namespace OpenAI.GPT3.ObjectModels.ResponseModels
{
    public class CreateModerationResponse : BaseResponse, IOpenAiModels.IModel, IOpenAiModels.IId
    {
        [JsonPropertyName("results")] public List<Result> Results { get; set; }

        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("model")] public string Model { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("categories")] public Categories Categories { get; set; }

        [JsonPropertyName("category_scores")] public CategoryScores CategoryScores { get; set; }

        [JsonPropertyName("flagged")] public bool Flagged { get; set; }
    }

    public class Categories
    {
        [JsonPropertyName("hate")] public bool Hate { get; set; }

        [JsonPropertyName("hatethreatening")] public bool HateThreatening { get; set; }

        [JsonPropertyName("selfharm")] public bool Selfharm { get; set; }

        [JsonPropertyName("sexual")] public bool Sexual { get; set; }

        [JsonPropertyName("sexualminors")] public bool Sexualminors { get; set; }

        [JsonPropertyName("violence")] public bool Violence { get; set; }

        [JsonPropertyName("violencegraphic")] public bool Violencegraphic { get; set; }
    }

    public class CategoryScores
    {
        [JsonPropertyName("hate")] public float Hate { get; set; }

        [JsonPropertyName("hatethreatening")] public float HateThreatening { get; set; }

        [JsonPropertyName("selfharm")] public float Selfharm { get; set; }

        [JsonPropertyName("sexual")] public float Sexual { get; set; }

        [JsonPropertyName("sexualminors")] public float SexualMinors { get; set; }

        [JsonPropertyName("violence")] public float Violence { get; set; }

        [JsonPropertyName("violencegraphic")] public float Violencegraphic { get; set; }
    }
}