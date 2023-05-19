var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMvc();
builder.Services.AddSwaggerGen();


//services
//                .AddScoped<IS3Storage, S3Storage>()
//                .AddScoped<IS3FileRepository, S3FileRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.MapControllers();

app.Run();
