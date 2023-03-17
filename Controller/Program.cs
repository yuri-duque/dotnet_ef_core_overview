using Repository.Ioc;
using Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.ConfigureAutoMapper();

builder.Services.ConfigureController();

builder.Services.ConfigureService();

builder.Services.ConfigureRepository();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
