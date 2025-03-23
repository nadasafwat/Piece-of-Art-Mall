using Microsoft.EntityFrameworkCore;
using Piece_of_Art_Mall.AppDbContextFolder;
using Piece_of_Art_Mall.Repository_Pattern.Category_Repository;
using Piece_of_Art_Mall.Repository_Pattern.Customer_Repository;
using Piece_of_Art_Mall.Repository_Pattern.LoyalityCard_Repository;
using Piece_of_Art_Mall.Repository_Pattern.PieceOfArt_Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connection = builder.Configuration.GetConnectionString("connection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

builder.Services.AddScoped<ICustomer, CustomerRepo>();
builder.Services.AddScoped<ILoyalityCard, LoyalityCardRepo>();
builder.Services.AddScoped<ICategory, CategoryRepo>();
builder.Services.AddScoped<IPieceOfArt, PieceOfArtRepo>();

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
