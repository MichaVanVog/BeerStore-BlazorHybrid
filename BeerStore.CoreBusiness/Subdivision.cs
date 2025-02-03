namespace BeerStore.CoreBusiness
{
    public class Subdivision
    {
        //GainUp
        public int Id { get; set; }
        public required string Name { get; set; }

        //eigene
        public string NameOnWebsite { get; set; } = string.Empty;
        public bool Active { get; set; } = false;
        public string TelegramChatIdExtern { get; set; } = string.Empty;
        public string TelegramChatIdIntern { get; set; } = string.Empty;
        public string WhatsAppContact { get; set; } = string.Empty;
        public string TelegramChannel { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string OpenTime { get; set; } = string.Empty;
        public string StoreImagePath { get; set; } = "/images/image.jpg";

        //public Storage? Storage { get; set; }
    }

    public class SubdivisionRoot
    {
        public required List<Subdivision> Subdivisions { get; set; }
    }
}
