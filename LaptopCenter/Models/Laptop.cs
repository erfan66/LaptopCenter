namespace LaptopCenter.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Brand { get; set; } = "Lenovo";
        public string CpuModel { get; set; } = "Intel";
        public double ScreenSize { get; set; } = 15.6;
        public string CpuDetails { get; set; } = "Core i7";
        public string GpuModel { get; set; } = string.Empty;
        public string GpuDetails { get; set; } = string.Empty;
        public string Ram { get; set; } = "4 Gb";
        public string HDModel { get; set; } = "H.D.D";
        public string HD { get; set; } = "500 gb";
        public double Weight { get; set; } = 2.5;
        public decimal Price { get; set; } = 500.00M;
    }
}
