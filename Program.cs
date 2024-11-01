using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 25000;
            string sifre = "ab18";

        giris:
            Console.WriteLine("HOSGELDINIZ");
            Console.WriteLine("Kartli islem icin 1'i kartsiz islem icin 2'yi tuslayiniz: ");
            string islem = Console.ReadLine();
            if (islem == "1")
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Kart sifrenizi giriniz. 3 hakkiniz bulunmaktadir");
                    Console.WriteLine("Kart sifrenizi giriniz(" + (3 - i) + "hakkiniz kaldi):");
                    string kullanicisifresi = Console.ReadLine();
                    if (kullanicisifresi == sifre)
                    {
                        Console.WriteLine("Giris Yapildi");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Yanlis sifre!");
                    }
                }

            anamenu:

                Console.WriteLine("ANA MENU");
                Console.WriteLine("Para Cekmek Icin 1'i " +
                    "Para Yatirmak icin 2'yi" +
                    " Para Transferi Icin 3'u" +
                    " Egitim odemeleri Icin 4'u " +
                    "Odemeler Icin 5'i" +
                    " Bilgi Guncellemeleri Icin 6'yi tuslayiniz");
                int anamenu = Convert.ToInt32(Console.ReadLine());

                if (anamenu == 1)
                {
                    Console.WriteLine("Bakiye yeterli ise para cekilecek, degilse bakiye yetersizdir");


                    Console.WriteLine("Cekmek istediginiz para tutarini giriniz:  ");
                    int cekilecektutar = Convert.ToInt32(Console.ReadLine());

                    if (cekilecektutar <= bakiye)
                    {
                        bakiye = bakiye - cekilecektutar;
                        Console.WriteLine(cekilecektutar + " tutarinda para cekildi");
                        Console.WriteLine("Kalan Bakiye: " + bakiye);

                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye!!");
                    }

                    Console.WriteLine("Ana Menuye donmek icin 9'u " +
                        "Cikmak icin 0'i tuslayiniz");
                    int islem1 = Convert.ToInt32(Console.ReadLine());
                    if (islem1 == 9)
                    {
                        goto anamenu;
                    }

                    else if (islem1 == 0)
                    {
                        goto giris;
                    }

                }

                else if (anamenu == 2)

                {
                secim2:

                    Console.WriteLine("Kredi kartina para yatirmak icin 1'i, Kendi hesabiniza para yatirmak icin 2'yi tuslayiniz.");
                    int secim2 = Convert.ToInt32(Console.ReadLine());

                    if (secim2 == 1)

                    {
                        Console.WriteLine("Kartinizin 12 haneli kart numarasini lutfen giriniz");
                        string kartno = Console.ReadLine();

                        if (kartno.Length == 12)
                        {
                            Console.WriteLine("Karttiniza yatirmak istediginiz tutari giriniz:  ");
                            int kartayatirilacaktutar = Convert.ToInt32(Console.ReadLine());

                            if (kartayatirilacaktutar <= bakiye)
                            {
                                bakiye = bakiye + kartayatirilacaktutar;
                                Console.WriteLine(kartayatirilacaktutar + " TL kartiniza basariyla yatirildi. Guncel bakiye:  " + bakiye);
                                Console.WriteLine("Ana Menuye donmek icin 9'u " +
                       "Cikmak icin 0'i tuslayiniz");

                                string islem4 = Console.ReadLine();

                                if (islem4 == "9")
                                { goto anamenu; }

                                else if (islem4 == "0")
                                { goto giris; }

                            }

                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye!");
                                Console.WriteLine("Ana Menuye donmek icin 9'u " +
                       "Cikmak icin 0'i tuslayiniz");

                                string islem22 = Console.ReadLine();

                                if (islem22 == "9")
                                { goto anamenu; }

                                else if (islem22 == "0")
                                { goto giris; }

                            }
                        }

                        else
                        {
                            Console.WriteLine("Kart numarasi hatali. Lutfen gecerli bir kart numarasi giriniz: ");
                            goto secim2;
                        }
                        Console.WriteLine("Ana Menuye donmek icin 9'u " +
                      "Cikmak icin 0'i tuslayiniz");

                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu; }

                        else if (islem3 == "0")
                        { goto giris; }
                    }

                    else if (secim2 == 2)
                    {
                        Console.WriteLine("Hesabiniza yatirmak istediginiz tutari giriniz:  ");
                        int yatirilacaktutar = Convert.ToInt32(Console.ReadLine());

                        bakiye = bakiye + yatirilacaktutar;

                        Console.WriteLine(yatirilacaktutar + "TL hesabiniza basariyla yatirildi. Guncel Bakiye:  " + bakiye);
                    }

                    Console.WriteLine("Ana Menuye donmek icin 9'u  " +
                      "Cikmak icin 0'i tuslayiniz");

                    string islem2 = Console.ReadLine();

                    if (islem2 == "9")
                    { goto anamenu; }

                    else if (islem2 == "0")
                    { goto giris; }

                }

                else if (anamenu == 3)
                {
                islem3:

                    Console.WriteLine("Baska hesaba EFT icin 1'i, Baska hesaba havale icin 2'yi tuslayiniz: ");
                    string efthavale = Console.ReadLine();

                    if (efthavale == "1")
                    {
                    islemeft:

                        Console.WriteLine("EFT icin 12 haneli basinda TR olacak sekilde paranin gonderilecegi hesap numarasini lutfen dogru bir sekilde giriniz:  ");
                        string eftno = Console.ReadLine();

                        if (eftno.StartsWith("TR") && eftno.Length == 14)
                        {
                        efttutar:

                            Console.WriteLine("Hesaba gondermek istediginiz tutari giriniz:  ");
                            int efttutar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye > efttutar)
                            {
                                bakiye = bakiye - efttutar;
                                Console.WriteLine(efttutar + " TL  karsi tarafa basariyla gonderildi. Guncel Bakiye: " + bakiye);

                                Console.WriteLine("Ana Menuye donmek icin 9'u  " +
                          "Cikmak icin 0'i tuslayiniz");

                                string islem3 = Console.ReadLine();

                                if (islem3 == "9")
                                { goto anamenu; }

                                else if (islem3 == "0")
                                { goto giris; }
                            }

                            else
                            {
                                Console.WriteLine("YETERSIZ BAKIYE!");
                                Console.WriteLine("Tekrar denemek icin 1'i, Ana Menuye donmek icin 9'u " +
                          "Cikmak icin 0'i tuslayiniz");

                                string islem3 = Console.ReadLine();

                                if (islem3 == "9")
                                { goto anamenu; }

                                else if (islem3 == "0")
                                { goto giris; }

                                else if (islem3 == "1")
                                { goto efttutar; }

                            }
                        }

                        else

                        {
                            Console.WriteLine("EFT numarasini hatali girdiniz. Lutfen tekrar deneyiniz: ");
                            goto islemeft;
                        }



                    }
                    else if (efthavale == "2")
                    {
                    havaletutar:

                        Console.WriteLine("Havale yapilacak 11 haneli hesap numarasini tuslayiniz:  ");
                        int havaletutar = Convert.ToInt32(Console.ReadLine());

                        if (havaletutar <= bakiye)
                        {
                            bakiye = bakiye - havaletutar;

                            Console.WriteLine(havaletutar + "TL havale gonderildi. Guncel Bakiye: " + bakiye);
                           
                            
                            Console.WriteLine(" Ana Menuye donmek icin 9'u" +
                          "Cikmak icin 0'i tuslayiniz");

                            string islem1 = Console.ReadLine();

                            if (islem1 == "9")
                            { goto anamenu; }

                            else if (islem1 == "0")
                            { goto giris; }

                            

                        }

                        else
                        {
                            Console.WriteLine("YETERSIZ BAKIYE!");
                            Console.WriteLine("Tekrar denemek icin 1'i, Ana Menuye donmek icin 9'u" +
                              "Cikmak icin 0'i tuslayiniz");

                            string islem2 = Console.ReadLine();

                            if (islem2 == "9")
                            { goto anamenu; }

                            else if (islem2 == "0")
                            { goto giris; }

                            else if (islem2 == "1")
                            { goto havaletutar; }
                        }
                    }
                }

                else if (anamenu == 4)
                {
                    Console.WriteLine("BU SAYFA GECICI OLARAK KULLANILAMAMAKTADIR");

                    Console.WriteLine("Ana Menuye donmek icin 9'u" +
                      "Cikmak icin 0'i tuslayiniz");

                    string islem3 = Console.ReadLine();

                    if (islem3 == "9")
                    { goto anamenu; }

                    else if (islem3 == "0")
                    { goto giris; }

                }

                else if (anamenu == 5)
                {
                    Console.WriteLine("Elektrik faturasi icin 1'i, Telefon Faturasi icin 2'yi, Internet faturasi icin 3'u, Su faturasi icin 4'u, OGS odemeleri icin 5'i tuslayiniz: ");
                    int fatura = Convert.ToInt32(Console.ReadLine());

                    if (fatura == 1)
                    {
                        Console.WriteLine("Elektrik faturasinin tutarini giriniz:  ");
                        int elektrikf = Convert.ToInt32(Console.ReadLine());

                        if (elektrikf <= bakiye)
                        {
                            bakiye = bakiye - fatura;

                            Console.WriteLine(elektrikf + "TL elektrik faturasi odendi. Guncel Bakiye:  " + bakiye);

                        }

                        else
                        {
                            Console.WriteLine("YETERSIZ BAKIYE!");
                        }

                        Console.WriteLine("Ana Menuye donmek icin 9'u" +
                      "Cikmak icin 0'i tuslayiniz");

                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu; }

                        else if (islem3 == "0")
                        { goto giris; }

                    }

                    else if (fatura == 2)
                    {
                        Console.WriteLine("Telefon faturasinin tutarini giriniz:  ");
                        int telfatura = Convert.ToInt32(Console.ReadLine());

                        if (telfatura <= bakiye)
                        {
                            bakiye = bakiye - telfatura;

                            Console.WriteLine(telfatura + "TL telefon faturasi odendi. Guncel Bakiye:  " + bakiye);
                        }

                        else
                        {
                            Console.WriteLine("YETERSIZ BAKIYE!");


                        }
                        Console.WriteLine(" Ana Menuye donmek icin 9'u" +
                      "Cikmak icin 0'i tuslayiniz");

                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu; }

                        else if (islem3 == "0")
                        { goto giris; }
                    }

                    else if (fatura == 3)
                    {
                        Console.WriteLine("Internet faturasi tutarini giriniz: ");
                        int intfatura = Convert.ToInt32(Console.ReadLine());

                        if (intfatura <= bakiye)
                        {
                            bakiye = bakiye - intfatura;
                            Console.WriteLine(intfatura + "TL internet faturasi odendi. Guncel Bakiye: " + bakiye);
                        }

                        else
                        {
                            Console.WriteLine("YETERSIZ BAKIYE!");
                        }

                        Console.WriteLine(" Ana Menuye donmek icin 9'u" +
                      "Cikmak icin 0'i tuslayiniz");

                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu; }

                        else if (islem3 == "0")
                        { goto giris; }



                    }

                    else if (fatura == 4)
                    {
                        Console.WriteLine("Su faturasi tutarini giriniz: ");
                        int sufaturasi = Convert.ToInt32(Console.ReadLine());

                        if (sufaturasi <= bakiye)
                        {
                            bakiye = bakiye - sufaturasi;

                            Console.WriteLine(sufaturasi + "TL su faturasi odendi. Guncel Bakiye:" + bakiye);
                        }

                        else
                        { Console.WriteLine("YETERSIZ BAKIYE!"); }
                        Console.WriteLine(" Ana Menuye donmek icin 9'u" +
                      "Cikmak icin 0'i tuslayiniz");

                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu; }

                        else if (islem3 == "0")
                        { goto giris; }



                    }

                    else if (fatura == 5)
                    {
                        Console.WriteLine("OGM odeme tutarini giriniz: ");
                        int ogmfatura = Convert.ToInt32(Console.ReadLine());

                        if (ogmfatura <= bakiye)
                        {
                            bakiye = bakiye - ogmfatura;
                            Console.WriteLine(ogmfatura + "TL OGM odemeniz gerceklesti. Guncel Bakiye: " + bakiye);

                        }

                        else
                        {
                            Console.WriteLine("YETERSIZ BAKIYE!");
                        }
                        Console.WriteLine(" Ana Menuye donmek icin 9'u" +
                      "Cikmak icin 0'i tuslayiniz");

                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu; }

                        else if (islem3 == "0")
                        { goto giris; }
                    }
                }

                else if (anamenu == 6)
                {

                    Console.WriteLine("Sifrenizi degistirmek icin 1'i tuslayiniz");
                    int sifreislem = Convert.ToInt32(Console.ReadLine());

                    if (sifreislem == 1)
                    {




                    }

                    else { }
                }
            }

            else if (islem == "2")

            {
            anamenu2:

                Console.WriteLine("ANA MENU");
                Console.WriteLine("Cepbank Para Cekmek icin 1'i, Para yatirmak icin 2'yi, Kredi karti odemesi icin 3'u, Egitim odemeleri icin 4'u, Odemeler icin 5'i tuslayiniz: ");
                int kartsizislem = Convert.ToInt32(Console.ReadLine());

                //if (kartsizislem == 1)

                //    { Console.WriteLine("Lutfen TC kimlik numaranizi ve cep telefonunuzu dogru bir sekilde giriniz:");

                if (kartsizislem == 2)
                {
                    Console.WriteLine("Nakit odeme icin 1'i, Hesaptan odeme icin 2'yi' Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz:  ");
                    int kartsizsecim = Convert.ToInt32(Console.ReadLine());
                    if (kartsizsecim == 1)

                    {
                    nakitkartno:

                        Console.WriteLine("Kredi kartinizin 12 haneli kart numarasini giriniz: ");
                        string kartno2 = Console.ReadLine();

                        if (kartno2.Length == 12)
                        {
                        tcno:

                            Console.WriteLine("TC numaranizi giriniz: ");
                            string tcno = Console.ReadLine();

                            if (tcno.Length == 11)
                            {
                                Console.WriteLine("Yatirmak istediginiz tutari giriniz: ");
                                int nakittutar = Convert.ToInt32(Console.ReadLine());
                                bakiye = bakiye + nakittutar;

                                Console.WriteLine(nakittutar + "TL hesabiniza yatirildi. Guncel Bakiye: " + bakiye);
                                Console.WriteLine("Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz");
                                string islem3 = Console.ReadLine();

                                if (islem3 == "9")
                                { goto anamenu2; }

                                else if (islem3 == "0")
                                { goto giris; }

                            }

                            else
                            {
                                Console.WriteLine("Hatali TC numarasi girdiniz. Lutfen Tekrar deneyiniz.");
                                goto tcno;
                            }

                        }
                        else

                        {
                            Console.WriteLine("Hatali kart numarasi girdiniz. Lutfen tekrar deneyiniz.");
                            goto nakitkartno;

                        }
                    }

                    else if (kartsizsecim == 2)
                    {
                    kartno3:
                        Console.WriteLine("Kredi kartinizin 12 haneli kart numarasini giriniz: ");
                        string kartno2 = Console.ReadLine();
                        if (kartno2.Length == 12)
                        {

                            Console.WriteLine("Hesap numaranizi giriniz: ");
                            string hesapno = Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("Hatali kart numarasi girdiniz. Lutfen tekrar deneyiniz: ");
                            goto kartno3;
                        }

                        Console.WriteLine("Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz: ");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 9)
                        { goto anamenu2; }
                        else if (secim2 == 0)
                        { goto giris; }

                    }
                }

                else if (kartsizislem == 3)
                {
                    Console.WriteLine("Baska hesaba EFT icin 1'i, Baska hesaba havale icin 2'yi tuslayiniz: ");
                    int efthavale2 = Convert.ToInt32(Console.ReadLine());
                    if (efthavale2 == 1)
                    {
                        Console.WriteLine("Basinda TR olacak sekilde 12 haneli EFT numarasini giriniz: ");
                        string eftno = Console.ReadLine();
                        if (eftno.Length == 14)
                        {
                            Console.WriteLine("Gondermek istediginiz tutari giriniz: ");
                            int efttutar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(efttutar + "TL EFT tutari gonderilmistir.");

                        }

                        else
                        {
                            Console.WriteLine("Hatali EFT numarasi girdiniz. Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz: ");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 9) { goto anamenu2; }
                            else if (secim == 0) { goto giris; }
                        }



                    }
                    else if (efthavale2 == 2)
                    {
                        Console.WriteLine("Havale icin 11 haneli hesap numarasini giriniz: ");
                        string havaleno = Console.ReadLine();
                        if (havaleno.Length == 11)
                        {

                            Console.WriteLine("Gondermek istediginiz tutari giriniz: ");
                            int havaletutar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(havaletutar + "TL Havale tutari gonderilmistir.");
                        }

                        else
                        {
                            Console.WriteLine("Hatali hesap numarasi girdiniz. Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 9) { goto anamenu2; }
                            else if (secim == 0) { goto giris; }
                        }
                    }

                }

                else if (kartsizislem == 4)
                {
                    Console.WriteLine("BU SAYFA GECICI OLARAK KULLANILAMAMAKTADIR");


                    Console.WriteLine("Ana Menuye donmek icin 9'u" +
                      "Cikmak icin 0'i tuslayiniz");

                    string islem3 = Console.ReadLine();

                    if (islem3 == "9")
                    { goto anamenu2; }

                    else if (islem3 == "0")
                    { goto giris; }

                }

                else if (kartsizislem == 5)
                {
                    Console.WriteLine("Elektrik faturasi icin 1'i, Telefon Faturasi icin 2'yi, Internet faturasi icin 3'u, Su faturasi icin 4'u, OGS odemeleri icin 5'i tuslayiniz: ");
                    string kartsizfatura = Console.ReadLine();

                    if (kartsizfatura == "1")
                    {
                        Console.WriteLine("Elektrik faturasinin tutarini giriniz: ");
                        int efatura = Convert.ToInt32(Console.ReadLine());
                        if (efatura <= bakiye)
                        {
                            Console.WriteLine(efatura + "TL elektrik faturasi odendi.");
                        }

                        else
                        { Console.WriteLine("YETERSIZ BAKIYE"); }

                        Console.WriteLine("Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz");
                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu2; }

                        else if (islem3 == "0")
                        { goto giris; }


                    }

                    else if (kartsizislem == 2)
                    {
                        Console.WriteLine("Telefon faturasinin tutarini giriniz: ");
                        int tfatura = Convert.ToInt32(Console.ReadLine());
                        if (tfatura <= bakiye)
                        {
                            Console.WriteLine(tfatura + "TL telefon faturasi odendi.");
                        }

                        else
                        { Console.WriteLine("YETERSIZ BAKIYE"); }

                        Console.WriteLine("Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz");
                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu2; }

                        else if (islem3 == "0")
                        { goto giris; }

                    }

                    else if (kartsizislem == 3)
                    {
                        Console.WriteLine("Internet faturasinin tutarini giriniz: ");
                        int ifatura = Convert.ToInt32(Console.ReadLine());
                        if (ifatura <= bakiye)
                        {
                            Console.WriteLine(ifatura + "TL internet faturasi odendi.");
                        }

                        else
                        { Console.WriteLine("YETERSIZ BAKIYE"); }

                        Console.WriteLine("Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz");
                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu2; }

                        else if (islem3 == "0")
                        { goto giris; }


                    }

                    else if (kartsizislem == 4)
                    {
                        Console.WriteLine("Su faturasinin tutarini giriniz: ");
                        int sfatura = Convert.ToInt32(Console.ReadLine());
                        if (sfatura <= bakiye)
                        {
                            Console.WriteLine(sfatura + "TL su faturasi odendi.");
                        }

                        else
                        { Console.WriteLine("YETERSIZ BAKIYE"); }

                        Console.WriteLine("Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz");
                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu2; }

                        else if (islem3 == "0")
                        { goto giris; }
                    }

                    else if (kartsizislem == 5)
                    {
                        Console.WriteLine("OGS odemesinin tutarini giriniz: ");
                        int ogsodemenakit = Convert.ToInt32(Console.ReadLine());
                        if (ogsodemenakit <= bakiye)
                        {
                            Console.WriteLine(ogsodemenakit + "TL OGS odemesi odendi.");
                        }

                        else
                        { Console.WriteLine("YETERSIZ BAKIYE"); }

                        Console.WriteLine("Ana Menuye donmek icin 9'u, Cikmak icin 0'i tuslayiniz");
                        string islem3 = Console.ReadLine();

                        if (islem3 == "9")
                        { goto anamenu2; }

                        else if (islem3 == "0")
                        { goto giris; }
                    }
                }




            }
        }
    }
}
   








