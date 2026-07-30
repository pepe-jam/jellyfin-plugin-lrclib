using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.LrcLib.Configuration;

/// <summary>
/// Configuration for LrcLib.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Gets or sets a value indicating whether to use strict search.
    /// </summary>
    public bool UseStrictSearch { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether to exclude artist name.
    /// </summary>
    public bool ExcludeArtistName { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether to exclude album name.
    /// </summary>
    public bool ExcludeAlbumName { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether synced lyrics should be preferred over
    /// plain lyrics. When true, and a synced version is available, the plain version is
    /// not even offered as a candidate.
    /// </summary>
    public bool PreferSyncedLyrics { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether tracks should be skipped when they appear
    /// to be instrumental (either flagged as such by LrcLib, or matching one of the
    /// <see cref="InstrumentalKeywords"/>).
    /// </summary>
    public bool SkipInstrumentalTracks { get; set; } = true;

    /// <summary>
    /// Gets or sets a comma-separated list of case-insensitive keywords. If a track's title
    /// contains any of these, no lyric search is performed at all. Only used when
    /// <see cref="SkipInstrumentalTracks"/> is true.
    /// </summary>
    public string InstrumentalKeywords { get; set; } = "instrumental";
}
