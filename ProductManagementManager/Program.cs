using ProductManagementManager.Models.Products.Mapper;
using ProductManagementManager.Models.Products.Repositories;
using ProductManagementManager.Models.Products.Services;
using ProductManagementManager.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddKeyedScoped<IFromKeyExample, EnterMessage>("Enter");
builder.Services.AddKeyedScoped<IFromKeyExample, ExitMessage>("Exit");

builder.Services.AddAutoMapper(typeof(BaseMapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
