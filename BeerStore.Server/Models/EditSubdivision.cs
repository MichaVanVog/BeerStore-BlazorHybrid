using System.ComponentModel.DataAnnotations;

namespace BeerStore.Server.Models
{
    public class EditSubdivision
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название магазина обязательно")]
        public required string Name { get; set; }
        public string NameOnWebsite { get; set; } = string.Empty;
        public string TelegramChatIdIntern { get; set; } = string.Empty;
        public bool Active { get; set; } = false;
        public string TelegramChatIdExtern { get; set; } = string.Empty;
        public string WhatsAppContact { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string TelegramChannel { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string OpenTime { get; set; } = string.Empty;
        public string StoreImagePath { get; set; } = string.Empty;
    }
}
