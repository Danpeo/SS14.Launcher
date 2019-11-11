using System.Net.Http;

namespace SS14.Launcher
{
    public static class Global
    {
        public const string JenkinsBaseUrl = "https://builds.spacestation14.io/jenkins";
        public const string JenkinsJobName = "SS14 Content";
        public const string CurrentLauncherVersion = "1";
        public const ushort DefaultServerPort = 1212;

        /// <summary>
        ///     Global HTTP client with correct User-Agent set.
        /// </summary>
        public static HttpClient GlobalHttpClient { get; }

        static Global()
        {
            GlobalHttpClient = new HttpClient();
            GlobalHttpClient.DefaultRequestHeaders.Add("User-Agent", $"SS14.Launcher v{CurrentLauncherVersion}");
        }
    }
}