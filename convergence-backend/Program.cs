using convergence_backend.Data;
using convergence_backend.Helpers;
using convergence_backend.Services;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

{
    // Add AutoMapper
    builder.Services.AddAutoMapper(typeof(Program));

    // Add services to the container.
    builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Connect to the database
    string connectionString = builder.Configuration.GetConnectionString("DBConnection");
    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
    });

    // Use lowercase for controller routes
    builder.Services.AddRouting(options => options.LowercaseUrls = true);

    // Configure strongly typed settings object
    builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

    // Configure DI for application services
    builder.Services.AddScoped<IUserService, UserService>();
}

WebApplication app = builder.Build();

{
    // Custom JWT auth middleware
    app.UseMiddleware<JwtMiddleware>();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    // app.UseHttpsRedirection();
    app.MapControllers();
}

app.Run();
