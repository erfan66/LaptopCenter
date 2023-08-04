namespace LaptopCenter.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Brand { get; set; } = "Lenovo";
        public string CpuModel { get; set; } = "Intel";
        public string CpuDatails { get; set; } = "Core i7";
        public string GpuModel { get; set; } = "Nvidia";
        public string Gpu { get; set; } = "1 GB";
        public string Ram { get; set; } = "4 Gb";
        public string HDModel { get; set; } = "H.D.D";
        public string HD { get; set; } = "500 gb";
        public decimal Weight { get; set; } = 200.00M;
        public decimal Price { get; set; } = 500.00M;
    }
}
