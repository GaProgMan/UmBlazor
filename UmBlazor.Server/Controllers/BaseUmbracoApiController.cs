using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Umbraco.Headless.Client.Net.Services;
using UmBlazor.Server.Helpers;
using Umbraco.Headless.Client.Net.Models;

namespace UmBlazor.Server.Controllers
{
    public class BaseUmbracoApiController : Controller
    {

        protected PublishedContentService Authenticate()
        {
            return AuthenticationHelpers.GetAuthd();
        }

        protected async Task<ContentItem> GetContentItemById (int id)
        {
            return await Authenticate().GetContentById(id);
        }
    }
}
