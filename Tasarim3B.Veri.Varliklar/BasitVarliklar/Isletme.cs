
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tasarim3B.Veri.Varliklar.Arayuzler;

namespace Tasarim3B.Veri.Varliklar.BasitVarliklar
{
    [Table("Firmalar")]
    public class Isletme : IEntity
    {

        [Required, Key]
        public virtual int ID { get; set; }

        [Required, MaxLength(100)]
        public virtual string? IsletmeAdi { get; set; }

        [Required, MaxLength(300)]
        public virtual string? Adres { get; set; }

        [Required, MaxLength(11)]
        public virtual string? VergiNo { get; set; }

        [Required, MaxLength(250)]
        public virtual string? EPosta { get; set; }

        [MaxLength(1000)]
        public virtual string? Aciklama { get; set; }

        [MaxLength(10)]
        public virtual string? TelefonNo1 { get; set; }

        [MaxLength(10)]
        public virtual string? TelefonNo2 { get; set; }

        public virtual IEnumerable<Levha>? Levhalar { get; set; }

    }
}
