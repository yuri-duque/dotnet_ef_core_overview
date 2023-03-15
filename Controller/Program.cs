using Controller;
using Repository.Context;
using Repository.Interfaces;
using Repository.Repositories;
using Service.Interfaces;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(provider => builder.Configuration);
builder.Services.AddDbContext<BaseContext>();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AutoMapping));


#region Repository

builder.Services.AddScoped<IUserRepository, UserRepository>();

#endregion

#region Service

builder.Services.AddScoped<IUserService, UserService>();

#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<BaseContext>();

    DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
