﻿namespace OBSStudioClient.Messages
{
    using System.Text.Json.Serialization;
    using OBSStudioClient.Classes;
    using OBSStudioClient.Interfaces;

    public class SceneListResponseData : IResponseData
    {
        [JsonPropertyName("currentProgramSceneName")]
        public string CurrentProgramSceneName { get; set; }

        [JsonPropertyName("currentPreviewSceneName")]
        public string? CurrentPreviewSceneName { get; set; }

        [JsonPropertyName("scenes")]
        public Scene[] Scenes { get; set; }

        [JsonConstructor]
        public SceneListResponseData(string currentProgramSceneName, string? currentPreviewSceneName, Scene[] scenes)
        {
            this.CurrentProgramSceneName = currentProgramSceneName;
            this.CurrentPreviewSceneName = currentPreviewSceneName;
            this.Scenes = scenes;
        }
    }
}
