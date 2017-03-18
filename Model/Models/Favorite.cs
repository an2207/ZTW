using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Favorite
    {
        public int FavoriteId { get; set; }

        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("OfferId")]
        public int? OfferId { get; set; }
        public Offer Offer { get; set; }
    }
    
}
