using Nancy;

namespace NancyAspNetHostWithRazor1.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };
        }
    }
}