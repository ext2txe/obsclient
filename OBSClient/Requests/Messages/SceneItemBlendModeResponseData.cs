﻿namespace OBSStudioClient.Messages
{
    using OBSStudioClient.Enums;
    using OBSStudioClient.Interfaces;
    using System.Text.Json.Serialization;

    public class SceneItemBlendModeResponseData : IResponseData
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("sceneItemBlendMode")]
        public BlendMode SceneItemBlendMode { get; set; }

        [JsonConstructor]
        public SceneItemBlendModeResponseData(BlendMode sceneItemBlendMode)
        {
            this.SceneItemBlendMode = sceneItemBlendMode;
        }
    }
}
