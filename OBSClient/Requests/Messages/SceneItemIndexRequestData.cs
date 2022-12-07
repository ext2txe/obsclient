﻿namespace OBSStudioClient.Messages
{
    using System.Text.Json.Serialization;

    public class SceneItemIndexRequestData
    {
        [JsonPropertyName("sceneName")]
        public string SceneName { get; set; }

        [JsonPropertyName("sceneItemId")]
        public int SceneItemId { get; set; }

        [JsonPropertyName("sceneItemIndex")]
        public int SceneItemIndex { get; set; }

        [JsonConstructor]
        public SceneItemIndexRequestData(string sceneName, int sceneItemId, int sceneItemIndex)
        {
            this.SceneName = sceneName;
            this.SceneItemId = sceneItemId;
            this.SceneItemIndex = sceneItemIndex;
        }
    }
}
