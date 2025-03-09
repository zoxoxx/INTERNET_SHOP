namespace INTERNET_SHOP.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? IP { get; set; }
        public string? ExternalIp { get; set; }
        public string? OS { get; set; }
        public string? PcName { get; set; }
        public string? ManufacturerProcessor { get; set; }

        public User() { }

        public User(string PcName, string OS, string IP, string ManufacturerProcessor, string ExternalIp)
        {
            this.PcName = PcName;
            this.OS = OS;
            this.IP = IP;
            this.ManufacturerProcessor = ManufacturerProcessor;
            this.ExternalIp = ExternalIp;
        }
    }
}
