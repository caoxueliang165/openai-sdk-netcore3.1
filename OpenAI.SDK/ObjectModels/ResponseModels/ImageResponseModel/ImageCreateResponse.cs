﻿using System.Text.Json.Serialization;
using OpenAI.GPT3.ObjectModels.SharedModels;

namespace OpenAI.GPT3.ObjectModels.ResponseModels.ImageResponseModel
{
    public class ImageCreateResponse : BaseResponse, IOpenAiModels.ICreatedAt
    {
        [JsonPropertyName("data")] public List<ImageDataResult> Results { get; set; }

        [JsonPropertyName("created")] public int CreatedAt { get; set; }

        public class ImageDataResult
        {
            [JsonPropertyName("url")] public string Url { get; set; }
            [JsonPropertyName("b64_json")] public string B64 { get; set; }
        }
    }
}