﻿namespace OBSStudioClient.Enums
{
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum IconType
    {
        OBS_ICON_TYPE_UNKNOWN,
        OBS_ICON_TYPE_IMAGE,
        OBS_ICON_TYPE_COLOR,
        OBS_ICON_TYPE_SLIDESHOW,
        OBS_ICON_TYPE_AUDIO_INPUT,
        OBS_ICON_TYPE_AUDIO_OUTPUT,
        OBS_ICON_TYPE_DESKTOP_CAPTURE,
        OBS_ICON_TYPE_WINDOW_CAPTURE,
        OBS_ICON_TYPE_GAME_CAPTURE,
        OBS_ICON_TYPE_CAMERA,
        OBS_ICON_TYPE_TEXT,
        OBS_ICON_TYPE_MEDIA,
        OBS_ICON_TYPE_BROWSER,
        OBS_ICON_TYPE_CUSTOM,
        OBS_ICON_TYPE_PROCESS_AUDIO_OUTPUT,
    }
}
