using WebApi.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; // Ensure this is present if using builder.Configuration
using Microsoft.EntityFrameworkCore.SqlServer; // Ensure the package is referenced in your project

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Fixes CS1026 by closing the parenthesis and lambda, and fixes CS1061 by providing a connection string and ensuring UseSqlServer is available.
builder.Services.AddDbContext<HMSDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
var app = builder.Build();
app.MapControllers();
app.Run();

