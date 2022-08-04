using BSDPROJE.Entities.Aspect.Attributes;
using BSDPROJE.Entities.Tables;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSDPROJE.BackOffice.Ayarlar
{
    [TryAspect]
    public partial class Saklama : Form
    {
        public Saklama()
        {
            InitializeComponent();
        }

        byte[] As = null;
        string Dosyaninadi = "";
        DosyalarDAL dosdaDAL = new DosyalarDAL();

        private void buttonEdit1_Click(object sender, EventArgs e)
        {


            OpenFileDialog choofdlog = new OpenFileDialog();

            choofdlog.Filter = "All Files (*.*)|*.*";

            choofdlog.FilterIndex = 1;

            byte[] As = null;

            if (choofdlog.ShowDialog() == DialogResult.OK)

            {

                As = System.IO.File.ReadAllBytes(choofdlog.FileName);
                Dosyaninadi = choofdlog.SafeFileName;

                using (var context = new NetSatisContext())
                {

                    BSD_TBL_Dosyalar dosya = new BSD_TBL_Dosyalar();
                    dosya.DostaIcerik = As;
                    dosya.DosyaAdi = Dosyaninadi;

                    dosdaDAL.AddOrUpdate(context, dosya);
                    context.SaveChanges();
                }


            }
        }

        public void SaveStreamToFile(string fileFullPath, Stream stream)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {

                var a = dosdaDAL.GetByFilter(context, c => c.Id == 4);

                FolderBrowserDialog Klasor = new FolderBrowserDialog();
                Klasor.RootFolder = Environment.SpecialFolder.Desktop;

                if (Klasor.ShowDialog() == DialogResult.OK)
                {
                    string path = Klasor.SelectedPath;
                    path += "\\"+a.DosyaAdi;
                    System.IO.FileInfo fi = new System.IO.FileInfo(path);

                    using (System.IO.FileStream fs = fi.OpenWrite())
                    {
                        fs.Write(a.DostaIcerik, 0, a.DostaIcerik.Length);
                    }
                }



                //    SaveFileDialog file = new SaveFileDialog();
                //    // file.Filter = "doc files (*.doc)|*.doc|docx files (*.docx)|*.docx";
                //    file.FileName = a.DosyaAdi;
                //    DialogResult dialogResult = file.ShowDialog();
                //if (dialogResult == DialogResult.OK)
                //{
                //   if (String.IsNullOrEmpty(file.FileName))
                //   {
                //      // T_MesajOlustur.Mesaj(" Kaydedilecek Dosya için bir isim girmelisiniz ", T_Enumerations.MesajTip.UyariMesaj);
                //   }

                //  string path = file.FileName;
                //  file.file

            }
        }
    }
}

