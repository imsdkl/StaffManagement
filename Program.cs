using StaffManagement.Models;

var builder = WebApplication.CreateBuilder(args);

// MVC servis xizmatini qo'shish;
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

// Interfeys servisining xizmat muddatini qo'shish
builder.Services.AddSingleton<IStaffRepository, MockStaffRepository>();

var app = builder.Build();

app.UseStaticFiles();

// Avtomatik tarzda Home Controllerga murojaat qilish uchun;
app.UseMvcWithDefaultRoute();

app.Run();
