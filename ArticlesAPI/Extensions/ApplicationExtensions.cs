using Microsoft.AspNetCore.Builder;
using ArticlesAPI.Common;

namespace ArticlesAPI.Extensions
{
    public static class ApplicationExtensions
    {
        public static void UseMyExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(err => err.Run(MyExceptionHandler.HandleAsync));
        }
    }
}