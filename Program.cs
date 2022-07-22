using Microsoft.EntityFrameworkCore;
using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Repositories;
using OnlineHotelManagementAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<HotelContext>
    (x => x.UseSqlServer(builder.Configuration.GetConnectionString("HotelConnection")));

builder.Services.AddTransient<IInventory, InventoryRepo>();
builder.Services.AddTransient<InventoryService, InventoryService>();

builder.Services.AddTransient<IStaff, StaffRepo>();
builder.Services.AddTransient<StaffService, StaffService>();

builder.Services.AddTransient<IRate, RateRepo>();
builder.Services.AddTransient<RateService, RateService>();

builder.Services.AddTransient<IRoom, RoomRepo>();
builder.Services.AddTransient<RoomService, RoomService>();

builder.Services.AddTransient<IGuest, GuestRepo>();
builder.Services.AddTransient<GuestService, GuestService>();

builder.Services.AddTransient<IReservation, ReservationRepo>();
builder.Services.AddTransient<ReservationService, ReservationService>();

builder.Services.AddTransient<IPayment, PaymentRepo>();
builder.Services.AddTransient<PaymentService, PaymentService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
