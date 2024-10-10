var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // Habilita el soporte para controladores
builder.Services.AddEndpointsApiExplorer(); // Habilita la exploración de endpoints
builder.Services.AddSwaggerGen(); // Habilita Swagger

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Habilita Swagger en desarrollo
    app.UseSwaggerUI(); // Habilita la interfaz de usuario de Swagger
}

app.UseHttpsRedirection(); // Redirige solicitudes HTTP a HTTPS

app.MapControllers(); // Mapea los controladores a las rutas

app.Run(); // Ejecuta la aplicación
