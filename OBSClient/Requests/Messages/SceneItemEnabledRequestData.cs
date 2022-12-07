﻿namespace OBSStudioClient.Messages
{
    using System.Text.Json.Serialization;

    public class SceneItemEnabledRequestData
    {
        [JsonPropertyName("sceneName")]
        public string SceneName { get; set; }

        [JsonPropertyName("sceneItemId")]
        public int SceneItemId { get; set; }

        [JsonPropertyName("sceneItemEnabled")]
        public bool SceneItemEnabled { get; set; }

        [JsonConstructor]
        public SceneItemEnabledRequestData(string sceneName, int sceneItemId, bool sceneItemEnabled)
        {
            this.SceneName = sceneName;
            this.SceneItemId = sceneItemId;
            this.SceneItemEnabled = sceneItemEnabled;
        }
    }
}
