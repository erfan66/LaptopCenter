using LaptopCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace LaptopCenter.Services
{
    public class LaptopServices : ILaptopServices
    {
        private readonly DataContext _context;

        public LaptopServices(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Laptop>?> AddLaptop(Laptop laptop)
        {
            var lap = await _context.Laptops.AddAsync(laptop);
            if (lap is null)
                return null;
            await _context.SaveChangesAsync();
            return await _context.Laptops.ToListAsync();
        }

        public async Task<List<Laptop>?> DeleteLaptop(int id)
        {
            var laptop = await _context.Laptops.FindAsync(id);
            if (laptop is null) return null;
            _context.Laptops.Remove(laptop);
            await _context.SaveChangesAsync();
            return await _context.Laptops.ToListAsync();
            
        }

        public async Task<List<Laptop>?> GetAllLaptops()
        {
            var laptops = await _context.Laptops.ToListAsync();
            return laptops;
        }

        public async Task<Laptop?> GetLaptop(int id)
        {
            var laptop = await _context.Laptops.FindAsync(id);
            if (laptop is null)
                return null;
            return laptop;
        }

        public async Task<List<Laptop>?> UpdateLaptop(int id, Laptop req)
        {
            var laptop = await _context.Laptops.FindAsync(id);
            if (laptop is null)
                return null;
            laptop.Brand = req.Brand;
            laptop.ScreenSize = req.ScreenSize;
            laptop.CpuModel = req.CpuModel;
            laptop.CpuDetails = req.CpuDetails;
            laptop.GpuModel = req.GpuModel;
            laptop.GpuDetails = req.GpuDetails;
            laptop.HDModel = req.HDModel;
            laptop.HD = req.HD;
            laptop.Ram = req.Ram;
            laptop.Weight = req.Weight;
            laptop.Price = req.Price;

            await _context.SaveChangesAsync();
            return await _context.Laptops.ToListAsync();
        }
    }
}
