
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Tasarim3B.Veri.Erisim
{
    public class VeriYonetici
    {
        #region Kurucu

        public VeriYonetici()
        {
            VeriTabaniOlustur();
        }

        #endregion Kurucu

        #region Alanlar

        private static string VeriTabaniAdi = "Tasarim3BVeri.vt";
        static string yol = AppDomain.CurrentDomain.BaseDirectory + "Veri\\";
        private Tasarim3BDBContext VeriTabani;

        #endregion Alanlar

        #region Ozellikler

        public static string VeriTabaniYolu => AppDomain.CurrentDomain.BaseDirectory + "Veri\\";


        private static string VeritabaniTamAdi => VeriTabaniYolu + VeriTabaniAdi;
      
        private static string VeritabaniSifresi
        {
            get { return "stur8891"; }
        }

        public static string BaglantiMetni
        {
            get
            {
                SqliteConnectionStringBuilder sb = new SqliteConnectionStringBuilder();
                sb.ConnectionString = string.Format("Data Source={0}", VeritabaniTamAdi);
                return sb.ToString();
            }
        }


        private bool VeriTabaniVar()
        {
            return File.Exists(VeritabaniTamAdi);
        }


        #endregion Ozellikler

        #region Yontemler

        public static (bool , DbContext) VeriTabaniOlustur()
        {

            if (!Directory.Exists(yol))
            {
                Directory.CreateDirectory(yol);
                Directory.CreateDirectory(yol + "Resimler\\");
            }

            var VeriTabani = new Tasarim3BDBContext(BaglantiMetni);

            bool vtyeni = VeriTabani.Database.EnsureCreated();
            return (vtyeni, VeriTabani);
        }

        #endregion Yontemler
    }
}
