using Umbraco.Headless.Client.Net.Services;

namespace UmBlazor.Server.Helpers
{
    public static class AuthenticationHelpers
    {
        public static PublishedContentService GetAuthd()
        {
            return new PublishedContentService(
                  GetSiteUrl(),
                  string.Empty, // Username goes here
                  string.Empty // password goes here;
        }

        public static string GetSiteUrl()
        {
            return "https://gaprogmans-affable-beaver.s1.umbraco.io";
        }
    }
}