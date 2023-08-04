using LaptopCenter.Models;

namespace LaptopCenter.Services
{
    public interface ILaptopServices
    {
        Task<List<Laptop>?> GetAllLaptops();
        Task<Laptop?> GetLaptop(int id);
        Task<List<Laptop>?> AddLaptop(Laptop laptop);
        Task<List<Laptop>?> UpdateLaptop(int id, Laptop req);
        Task<List<Laptop>?> DeleteLaptop(int id);
        
    }
}
