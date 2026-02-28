
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tasarim3B.Veri.Varliklar.Arayuzler;

namespace Tasarim3B.Veri.Varliklar.BasitVarliklar
{
    [Table("Levhalar")]
    public class Levha : IEntity
    {
        [Required, Key]
        public virtual int ID { get; set; }

        [Required]
        public virtual string Adi { get; set; }
        
        [Required]
        public virtual string LevhaTipi { get; set; }

        [Required]
        public virtual string Boyut { get; set; }

        [Required]
        public virtual string OnResim { get; set; }

        [Required]
        public virtual string YanResim { get; set; }

       
        public virtual int StokMiktari { get; set; }


        public virtual int IsletmeID { get; set; }
        public virtual Isletme Isletme { get; set; }

    }

}
