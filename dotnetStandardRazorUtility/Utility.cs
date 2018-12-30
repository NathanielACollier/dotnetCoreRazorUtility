


using System.Threading.Tasks;

namespace dotnetStandardRazorUtility
{
    public static class Utility
    {
        public static async Task<string> RenderView<T>(string viewPath, T model)
        {
            return await shared.Renderer.RenderViewToStringAsync<T>(viewPath, model);
        }
    }
}
