using System;
using LoginAuth.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Areas.Identity.Data;

[assembly: HostingStartup(typeof(ToDoList.Areas.Identity.IdentityHostingStartup))]
namespace ToDoList.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ToDoListContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ToDoListContextConnection")));

                services.AddDefaultIdentity<ToDoListUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ToDoListContext>();
            });
        }
    }
}