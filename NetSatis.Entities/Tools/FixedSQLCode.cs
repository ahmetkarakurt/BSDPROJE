using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tools
{
    public static   class FixedSQLCode
    {
        public static string BankaGenelDurumBorcAlacak = @"SELECT        HESAPTIPI, HESAPTIPLERI, DOVIZTIPI, SUM(BORCBAKIYEDOVIZ) AS BORCBAKIYEDOVIZ, 
                                                        SUM(ALACAKBAKIYEDOVIZ) AS ALACAKBAKIYEDOVIZ, SUM(BORCBAKIYE) AS BORCBAKIYE, SUM(ALACAKBAKIYE) 
                                                        AS ALACAKBAKIYE , SUM(BAKIYE) AS BAKIYE
                                                        FROM            dbo.ZZZ_BANK_BAKIYE WHERE RAPORKODU IS NOT NULL
                                                        GROUP BY HESAPTIPI, HESAPTIPLERI, DOVIZTIPI";
        public static string KasaGenelDurum = @"SELECT KSMAS_NAME, SUM(GIRIS) AS GELIR, SUM(CIKIS) AS GIDER, SUM(GIRIS) - SUM(CIKIS) AS KALAN,

                                                             SUM(CASE WHEN DOVIZLI = 'E' AND IO = 'C' THEN DOVIZTUT ELSE 0 END) AS DOVIZCIKIS,
                                                             SUM(CASE WHEN DOVIZLI = 'E' AND IO = 'G' THEN DOVIZTUT ELSE 0 END) AS DOVIZGIRIS,

                                                            SUM(CASE WHEN DOVIZLI = 'E' AND IO = 'G' THEN DOVIZTUT ELSE 0 END) -
                                                             SUM(CASE WHEN DOVIZLI = 'E' AND IO = 'C' THEN DOVIZTUT ELSE 0 END) AS DOVKALAN,
                                                             DOVIZLI, DOVIZTIPI
                                    FROM            dbo.ZZZ_KASAHAR
                                    GROUP BY KSMAS_NAME, DOVIZLI, DOVIZTIPI";


        public static string CariGenelBorcAlacak = @"SELECT        SUM(TRA.SBORC) AS SBORC, SUM(TRA.SALACAK) AS SALACAK, SUM(TRA.SDBORC) AS SDBORC, 
			                                        SUM(TRA.SDALACAK) AS SDALACAK, KUR.SIRA, KUR.ISIM AS KURISIM, 
		                                        CASE WHEN CARI_TIP='A' THEN 'ALICI'
			                                         WHEN CARI_TIP='S' THEN 'SATICI'
			                                          WHEN CARI_TIP='T' THEN 'TOPTANCI'
			                                           WHEN CARI_TIP='M' THEN 'MUSTAHSIL'
			                                           WHEN CARI_TIP='V' THEN 'AVUKAT'
			                                         ELSE 'DIGER' END	 	AS	CARI_TIP
                            FROM            dbo.TBLCASABIT LEFT OUTER JOIN
                                                         (SELECT        CARI_KOD, DOVIZ_TURU, SUM(CASE WHEN BORC > 0 THEN BORC ELSE 0 END) AS SBORC, SUM(CASE WHEN ALACAK > 0 THEN ALACAK ELSE 0 END) AS SALACAK, 
                                                                                     SUM(CASE WHEN BORC > 0 THEN DOVIZ_TUTAR ELSE 0 END) AS SDBORC, SUM(CASE WHEN ALACAK > 0 THEN DOVIZ_TUTAR ELSE 0 END) AS SDALACAK
                                                           FROM            dbo.TBLCAHAR
                                                           WHERE        (DOVIZ_TURU BETWEEN 0 AND 20) AND (HAREKET_TURU BETWEEN 'A' AND 'L') AND (TARIH BETWEEN '01/01/2022' AND '12/31/2022')
                                                           GROUP BY CARI_KOD, DOVIZ_TURU) AS TRA ON dbo.TBLCASABIT.CARI_KOD = TRA.CARI_KOD LEFT OUTER JOIN
                                                     NETSIS.dbo.KUR AS KUR ON KUR.SIRA = TRA.DOVIZ_TURU
                            WHERE        (dbo.TBLCASABIT.CM_BORCT + dbo.TBLCASABIT.CM_ALACT <> 0)
                            GROUP BY KUR.SIRA, KUR.ISIM,CARI_TIP";
        public static string StokGenelDurumBorcAlacak = @"SELECT        SUM(dbo.TBLSTSABIT.ALIS_FIAT1 * CASE WHEN STHAR_GCKOD = 'G' THEN STHAR_GCMIK ELSE STHAR_GCMIK * - 1 END) AS GENEL_ALIS, 
                                                         SUM(dbo.TBLSTSABITEK.SON_SATAL_FIAT * CASE WHEN STHAR_GCKOD = 'G' THEN STHAR_GCMIK ELSE STHAR_GCMIK * - 1 END) AS GENEL_SON_SATINAL, 
                                                         SUM(dbo.BSD_SON_GIRIS_FIYATLARI.SON_GIR_FIYAT * CASE WHEN STHAR_GCKOD = 'G' THEN STHAR_GCMIK ELSE STHAR_GCMIK * - 1 END) AS GENEL_GIR
                                FROM            dbo.TBLSTHAR LEFT OUTER JOIN
                                                         dbo.TBLSTSABITEK ON dbo.TBLSTHAR.STOK_KODU = dbo.TBLSTSABITEK.STOK_KODU LEFT OUTER JOIN
                                                         dbo.BSD_SON_GIRIS_FIYATLARI ON dbo.TBLSTHAR.STOK_KODU = dbo.BSD_SON_GIRIS_FIYATLARI.STOK_KODU LEFT OUTER JOIN
                                                         dbo.TBLSTSABIT ON dbo.TBLSTHAR.STOK_KODU = dbo.TBLSTSABIT.STOK_KODU
                                WHERE         (dbo.TBLSTHAR.STOK_KODU NOT like '720-%'  and dbo.TBLSTHAR.STOK_KODU NOT like '253-%'  and dbo.TBLSTHAR.STOK_KODU NOT like '600-%'  and dbo.TBLSTHAR.STOK_KODU NOT like 'HIZ-%' )";
        


        public static string CeksenetGenel = @"SELECT        SUM(TUTAR) AS TUTAR, DURUM, YERI, TIPI, KURISIM
                                                    FROM            dbo.BSD_VW_CEKSEN_SONISLEM
                                                    GROUP BY DURUM, YERI, TIPI, KURISIM";




         public static string vadesiGelenCek = @"SELECT        SUM(TUTAR) AS TUTAR, DOVTIP, SUM(DOVTUT) AS DOVTUT
                                            FROM            (SELECT        ISNULL(SC_ODETRH, VADETRH) AS SC_ODETRH, SC_NO, TUTAR, DOVTIP, DOVTUT, SC_VERILENK AS CARI_KODU, SC_GIRTRH
                                                                      FROM            dbo.TBLBCEK
                                                                      WHERE        (SC_SONDUR = 'B') AND (SC_YERI = 'C')) AS XX
                                            WHERE        (SC_ODETRH >= CONVERT(DATETIME, GETDATE(), 102))
                                            GROUP BY DOVTIP";

         public static string MusteriCekleriPortfoy = @"SELECT        SUM(TUTAR) AS TUTAR, DOVTIP, SUM(DOVTUT) AS DOVTUT
                            FROM            (SELECT        ISNULL(SC_ODETRH, VADETRH) AS SC_ODETRH, SC_NO, TUTAR, DOVTIP, DOVTUT, SC_VERILENK AS CARI_KODU, SC_GIRTRH
                                                      FROM            dbo.TBLMCEK
                                                      WHERE        (SC_SONDUR = 'B') AND (SC_YERI = 'P')) AS XX
                            WHERE        (SC_ODETRH >= CONVERT(DATETIME, GETDATE(), 102))
                            GROUP BY DOVTIP";

        public static string MusteriCekleriTahsil = @"SELECT        SUM(TUTAR) AS TUTAR, DOVTIP, SUM(DOVTUT) AS DOVTUT
                            FROM            (SELECT        ISNULL(SC_ODETRH, VADETRH) AS SC_ODETRH, SC_NO, TUTAR, DOVTIP, DOVTUT, SC_VERILENK AS CARI_KODU, SC_GIRTRH
                                                      FROM            dbo.TBLMCEK
                                                      WHERE        (SC_SONDUR = 'B') AND (SC_YERI = 'T')) AS XX
                            WHERE        (SC_ODETRH >= CONVERT(DATETIME, GETDATE(), 102))
                            GROUP BY DOVTIP";

        // dbo.TBLBSEN
        public static string vadesiGelensenet = @"SELECT        SUM(TUTAR) AS TUTAR, DOVTIP, SUM(DOVTUT) AS DOVTUT
                                            FROM            (SELECT        ISNULL(SC_ODETRH, VADETRH) AS SC_ODETRH, SC_NO, TUTAR, DOVTIP, DOVTUT, SC_VERILENK AS CARI_KODU, SC_GIRTRH
                                                                      FROM            dbo.TBLBSEN
                                                                      WHERE        (SC_SONDUR = 'B') AND (SC_YERI = 'C')) AS XX
                                            WHERE        (SC_ODETRH >= CONVERT(DATETIME, GETDATE(), 102))
                                            GROUP BY DOVTIP";

        public static string MusteriSenetleriPortfoy = @"SELECT        SUM(TUTAR) AS TUTAR, DOVTIP, SUM(DOVTUT) AS DOVTUT
                                            FROM            (SELECT        ISNULL(SC_ODETRH, VADETRH) AS SC_ODETRH, SC_NO, TUTAR, DOVTIP, DOVTUT, SC_VERILENK AS CARI_KODU, SC_GIRTRH
                                                                      FROM            dbo.TBLBSEN
                                                                      WHERE        (SC_SONDUR = 'B') AND (SC_YERI = 'P')) AS XX
                                            WHERE        (SC_ODETRH >= CONVERT(DATETIME, GETDATE(), 102))
                                            GROUP BY DOVTIP";
        public static string MusteriSenetleriTahsil = @"SELECT        SUM(TUTAR) AS TUTAR, DOVTIP, SUM(DOVTUT) AS DOVTUT
                            FROM            (SELECT        ISNULL(SC_ODETRH, VADETRH) AS SC_ODETRH, SC_NO, TUTAR, DOVTIP, DOVTUT, SC_VERILENK AS CARI_KODU, SC_GIRTRH
                                                      FROM            dbo.TBLBSEN
                                                      WHERE        (SC_SONDUR = 'B') AND (SC_YERI = 'T')) AS XX
                            WHERE        (SC_ODETRH >= CONVERT(DATETIME, GETDATE(), 102))
                            GROUP BY DOVTIP";




        public static string CariOZBorcAlacakGenelDokumu = @"SELECT         SUM(TRA.SBORC) AS SBORC, SUM(TRA.SALACAK) AS SALACAK, SUM(TRA.SDBORC) AS SDBORC, SUM(TRA.SDALACAK) AS SDALACAK, KUR.SIRA, KUR.ISIM AS KURISIM
FROM            dbo.TBLCASABIT LEFT OUTER JOIN
                             (SELECT        CARI_KOD, DOVIZ_TURU, SUM(CASE WHEN BORC > 0 THEN BORC ELSE 0 END) AS SBORC, SUM(CASE WHEN ALACAK > 0 THEN ALACAK ELSE 0 END) AS SALACAK, 
                                                         SUM(CASE WHEN BORC > 0 THEN DOVIZ_TUTAR ELSE 0 END) AS SDBORC, SUM(CASE WHEN ALACAK > 0 THEN DOVIZ_TUTAR ELSE 0 END) AS SDALACAK
                               FROM            dbo.TBLCAHAR
                               WHERE        (DOVIZ_TURU BETWEEN 0 AND 20) AND (HAREKET_TURU BETWEEN 'A' AND 'L')
                               GROUP BY CARI_KOD, DOVIZ_TURU) AS TRA ON dbo.TBLCASABIT.CARI_KOD = TRA.CARI_KOD LEFT OUTER JOIN
                         NETSIS.dbo.KUR AS KUR ON KUR.SIRA = TRA.DOVIZ_TURU
WHERE        (dbo.TBLCASABIT.CM_BORCT + dbo.TBLCASABIT.CM_ALACT <> 0)
GROUP BY KUR.SIRA, KUR.ISIM
ORDER BY KURISIM";


        public static string GenelCokodemesiOz = @"SELECT        SUM(TUTAR) AS TUTAR, DOVTIP, SUM(DOVTUT) AS DOVTUT
                                            FROM            (SELECT        ISNULL(SC_ODETRH, VADETRH) AS SC_ODETRH, SC_NO, TUTAR, DOVTIP, DOVTUT, SC_VERILENK AS CARI_KODU, SC_GIRTRH
                                                                      FROM            dbo.TBLBCEK
                                                                      WHERE        (SC_SONDUR = 'B') AND (SC_YERI = 'C')) AS XX
                                            WHERE        (SC_ODETRH >= CONVERT(DATETIME, GETDATE(), 102))
                                            GROUP BY DOVTIP";


        public static string GenelODemePlaniOz = @"SELECT        OdemeTuru, SUM(TUTAR) AS TUTAR, KURISIM
                                FROM            dbo.BSD_ODEME_PLANI
                                WHERE        (VADETRH >= GETDATE())
                                GROUP BY OdemeTuru, KURISIM";


        public static string KasaGenelDurumOzel = @"SELECT KSMAS_NAME, SUM(GIRIS) AS GELIR, SUM(CIKIS) AS GIDER, SUM(GIRIS) - SUM(CIKIS) AS KALAN,

                                                             SUM(CASE WHEN DOVIZLI = 'E' AND IO = 'C' THEN DOVIZTUT ELSE 0 END) AS DOVIZCIKIS,
                                                             SUM(CASE WHEN DOVIZLI = 'E' AND IO = 'G' THEN DOVIZTUT ELSE 0 END) AS DOVIZGIRIS,

                                                            SUM(CASE WHEN DOVIZLI = 'E' AND IO = 'G' THEN DOVIZTUT ELSE 0 END) -
                                                             SUM(CASE WHEN DOVIZLI = 'E' AND IO = 'C' THEN DOVIZTUT ELSE 0 END) AS DOVKALAN,
                                                             DOVIZLI, DOVIZTIPI
                                    FROM            "+ SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_KasaSirketi) + ".dbo.ZZZ_KASAHAR  GROUP BY KSMAS_NAME, DOVIZLI, DOVIZTIPI";


        // Admin Paneli İçerisinde 
        public static string TabloYetkileriView = @"SELECT        dbo.BSD_TBL_RAPORLAR_VW.id AS Kategorid, dbo.BSD_TBL_RAPORLAR_VW.VwAdi, dbo.BSD_TBL_KullaniciRolleri.KullaniciAdi, dbo.BSD_TBL_KullaniciRolleri.Yetki, dbo.BSD_TBL_RAPORLAR_ANA.KategoriAdi, 0 AS id
FROM            dbo.BSD_TBL_RAPORLAR_VW LEFT OUTER JOIN
                         dbo.BSD_TBL_KullaniciRolleri ON dbo.BSD_TBL_RAPORLAR_VW.Kategorid = dbo.BSD_TBL_KullaniciRolleri.ParentId LEFT OUTER JOIN
                         dbo.BSD_TBL_RAPORLAR_ANA ON dbo.BSD_TBL_RAPORLAR_VW.Kategorid = dbo.BSD_TBL_RAPORLAR_ANA.id";




    }
}
