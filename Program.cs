using Parse;

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

ParseClient.Initialize(new ParseClient.Configuration
{
    ApplicationId = "wKfQjv0ENXzdSOpMBtrUAlVQM4h5LdIXrsHfxKhn",
    WindowsKey = "2iRefadXN4gN7vvrfKckYdKeoSGTL6tRNWYMurHv",
    Server = "https://parseapi.back4app.com/"
});

app.Run();
