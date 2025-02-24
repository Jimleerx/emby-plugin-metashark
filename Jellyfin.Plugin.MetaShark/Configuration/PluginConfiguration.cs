using MediaBrowser.Model.Plugins;
using System.Net;
using System.Reflection;

namespace Jellyfin.Plugin.MetaShark.Configuration;

/// <summary>
/// The configuration options.
/// </summary>
public enum SomeOptions
{
    /// <summary>
    /// Option one.
    /// </summary>
    OneOption,

    /// <summary>
    /// Second option.
    /// </summary>
    AnotherOption
}

/// <summary>
/// Plugin configuration.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    public const int MAX_CAST_MEMBERS = 15;
    public const int MAX_SEARCH_RESULT = 5;

    public string Version { get; } = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? string.Empty;

    public string DoubanCookies { get; set; } = string.Empty;
    /// <summary>
    /// 开启防封禁
    /// </summary>
    public bool EnableDoubanAvoidRiskControl { get; set; } = false;
    /// <summary>
    /// 背景图使用原图
    /// </summary>
    public bool EnableDoubanBackdropRaw { get; set; } = false;

    public bool EnableTmdb { get; set; } = true;

    public bool EnableTmdbSearch { get; set; } = false;

    public bool EnableTmdbBackdrop { get; set; } = false;
    /// <summary>
    /// 是否获取电影系列信息
    /// </summary>
    public bool EnableTmdbCollection { get; set; } = false;
    /// <summary>
    /// 是否获取tmdb分级信息
    /// </summary>
    public bool EnableTmdbOfficialRating { get; set; } = false;

    public string TmdbApiKey { get; set; } = string.Empty;

    public string TmdbHost { get; set; } = string.Empty;



    public int MaxCastMembers { get; set; } = 15;

    public int MaxSearchResult { get; set; } = 5;



}
