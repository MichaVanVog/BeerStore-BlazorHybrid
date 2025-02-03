using System.ComponentModel.DataAnnotations;

namespace BeerStore.Server.Models
{
    public class AddSubdivision
    {
        [Required(ErrorMessage = "Название магазина обязательно")]
        public string Name { get; set; } = string.Empty;
        public string NameOnWebsite { get; set; } = string.Empty;
        public long? TelegramChatIdIntern { get; set; } = 0;
        public bool Active { get; set; } = false;
        public long? TelegramChatIdExtern { get; set; }
        public string? WhatsAppContact { get; set; } = string.Empty;
        public int? Phone { get; set; } = 0;
        public string? Address { get; set; } = string.Empty;
        public string? OpenTime { get; set; } = string.Empty;
        public IFormFile? UploadedFile { get; set; }
    }
}
