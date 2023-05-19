var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
