using BankManagement.BLL;
using BankManagement.BLL.Services.Concrete;
using BankManagement.DAL;
using BankManagement.DAL.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDatabaseContext();  // DbContext

builder.Services.AddBLLServices();  // BLL Services

builder.Services.Scan(scan =>  // Auto Service Registration
{
    scan.FromAssembliesOf(typeof(CardService), typeof(UserRepository))
    .AddClasses()
    .AsMatchingInterface()
    .WithScopedLifetime();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
