using Microsoft.EntityFrameworkCore;
using stockAPI.Data; 
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<ApiContext>(
    opt =>
    {
        //opt.UseNpgsql("Server=localhost;Port=5432;Database=dbstock;Username=postgres;Password=0606");
        opt.UseNpgsql("Server=localhost;Port=5432;Database=dbstock;Username=postgres;Password=0606;Pooling=true;");
        //opt.UseNpgsql("User ID=postgres;Password=0606;Host=localhost;Port=5432;Database=dbstock;Pooling=true;");

        //opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));

    });
builder.Services.AddRazorPages();

//builder.Services.AddSwaggerGen();

//register

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    /*
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json","test");
    });
    */
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseAuthentication();
//app.UseAuthorization();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
