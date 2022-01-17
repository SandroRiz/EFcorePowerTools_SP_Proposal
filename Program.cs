using EFcorePowerTools_SP_Proposal.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("db")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/products", async (NorthwindContext db) => await db.Products.ToListAsync());

app.MapGet("/discontinuedproducts", async (NorthwindContext db) => await db.Procedures.GetDiscontinuedProductsAsync());

//it fails with a "Unable to determine the relationship represented by navigation..."
app.MapGet("/discontinuedproducts2", async (NorthwindContext db) => await db.Procedures.GetDiscontinuedProductsAsync2());


app.Run();

