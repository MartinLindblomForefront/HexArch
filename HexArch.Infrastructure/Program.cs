using HexArch.Application.Services;
using HexArch.Domain.Repositories;
using HexArch.Domain.Services;
using HexArch.Infrastructure.CommandLine;
using HexArch.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddTransient<ICreateBookService, CreateBookService>();
builder.Services.AddTransient<IGetBookService, GetBookService>();
builder.Services.AddTransient<ICreateAuthorService, CreateAuthorService>();
builder.Services.AddTransient<IGetAuthorService, GetAuthorService>();
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<IAuthorService, AuthorService>();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSingleton<IBookRepository, InMemoryBookRepository>();
    builder.Services.AddSingleton<IAuthorRepository, InMemoryAuthorRepository>();
}
else
{
    builder.Services.AddSingleton<IBookRepository, CosmosBookRepository>();
    builder.Services.AddSingleton<IAuthorRepository, CosmosAuthorRepository>();
}

builder.Services.AddTransient<ICommandLineHandler, CreateAuthorCommandLineHandler>();
builder.Services.AddHostedService<CliReader>();

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();