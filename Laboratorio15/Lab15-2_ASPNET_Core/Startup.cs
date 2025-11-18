using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace Lab15_2 {
    public class Startup {
        public void Configure(IApplicationBuilder app) {
            app.Run(async context => {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
