using ReviewGenerator;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Configure your services and dependencies
builder.Services.AddScoped<IReviewDataService, ReviewDataService>();
builder.Services.AddScoped<IReviewGeneratorService, ReviewGeneratorService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger v1");
        //c.RoutePrefix = String.Empty;
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
