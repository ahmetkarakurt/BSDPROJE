using NetSatis.Entities.Tools.LoadingTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSDPROJE.Entities.Extensions
{
    public static class ExtensionMethod
    {
        /// <summary>
        /// Sayının istenilen sayı ile çarpımı
        /// </summary>
        /// <param name="Sayi">Nokta bastınca çalışacak veri tipi ve kullanılacak değişken</param>
        /// <param name="KaclaCarpilacak">Girilecek ilk sayı parametresi</param>
        /// <returns>Çapımının int tipinde</returns>
        public static void Ac(this Form A)
        {
            LoadingTool animasyon = new LoadingTool();

            animasyon.AnimasyonBaslat();
            A.Show();

            animasyon.AnimasyonBitir();


        }
        public static void AcDiyalog(this Form A)
        {
            LoadingTool animasyon = new LoadingTool();

            animasyon.AnimasyonBaslat();
            A.AcDiyalog();
            animasyon.AnimasyonBitir();


        }

        public static void HandleException(Action action)
        {
            try
            {

                action.Invoke();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
        }



    }
}
