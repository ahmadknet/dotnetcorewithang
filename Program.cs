using dotnetcorewithang.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DemoDBContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DemoDBCon")));

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();



var app = builder.Build();

//app.AddDbContext<DemoDBContext>(options => options.UseSqlServer(connection));

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // app.UseHsts();

    //app.UseSwagger();
    //app.UseSwaggerUI();


}



app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllers();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller}/{action=Index}/{id?}");

//app.MapFallbackToFile("index.html"); 

app.Run();
