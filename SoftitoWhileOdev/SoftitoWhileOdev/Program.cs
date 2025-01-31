//WHILE

using System;
class HelloWorld
{
    static void Main()
    {
        #region 1) tek-çift
        //int sayi;
        //int cifttoplam = 0;
        //int tektoplam = 0;
        //int tek = 0;
        //int i = 0;
        //int j = 1;

        //Console.WriteLine("Lütfen bir sayı girin:");
        //sayi = Convert.ToInt32(Console.ReadLine());

        //while (i <= sayi || j <= sayi)
        //{
        //    if (i <= sayi)
        //    {
        //        cifttoplam += i;
        //        i += 2;
        //    }

        //    if (j <= sayi)
        //    {
        //        tektoplam += j;
        //        j += 2;
        //    }
        //}
        //tek = tektoplam - j;

        //Console.WriteLine("Çift Sayıların toplamı: " + cifttoplam);
        //Console.WriteLine("Tek Sayıların toplamı: " + tektoplam);
        #endregion

        #region 2) sayı kadar
        //Console.WriteLine("Lütfen bir sayı giriniz");
        //int girilenSayi = 0;
        //girilenSayi = int.Parse(Console.ReadLine());

        //int i = 1;
        //while (i <= girilenSayi)
        //{
        //    int j = 1;
        //    while (j <= i)
        //    {
        //        Console.Write(i);
        //        j++;
        //    }
        //    i++;
        //}
        #endregion

        #region 3) 4 satır  yıldız

        //int satirSayisi = 4;
        //int i = 0; 

        //while (i < satirSayisi)
        //{
        //    Console.WriteLine("***"); 
        //    i++; 
        //}
        #endregion

        #region 4)  yatık yıldız
        //int total = 5;
        //int space = 4;

        //int i = 0;
        //while (i < total)
        //{
        //    int y = 0;
        //    while (y < space)
        //    {
        //        Console.Write(" ");
        //        y++;
        //    }

        //    y = 0;
        //    while (y < total - space)
        //    {
        //        Console.Write("*");
        //        y++;
        //    }

        //    space -= 1;
        //    Console.Write("\n");

        //    i++;
        //}
        #endregion

        #region  5) çam ağacı
        //int body = int.Parse(Console.ReadLine());
        //int satir;
        //satir = (body * 2) - 1;

        //int i = 1;
        //while (i <= satir)
        //{
        //    Console.WriteLine();
        //    int bosluk = (satir - i) / 2;
        //    int j = 0;
        //    while (j < bosluk)
        //    {
        //        Console.Write(" ");
        //        j++;
        //    }
        //    j = 0;
        //    while (j < i)
        //    {
        //        Console.Write("*");
        //        j++;
        //    }
        //    i += 2;
        //}

        //Console.Write(body);
        //int k = 0;
        //while (k < ((satir - 1) / 2))
        //{
        //    Console.WriteLine();
        //    int j = 0;
        //    while (j < ((satir - 3) / 2))
        //    {
        //        Console.Write(" ");
        //        j++;
        //    }
        //    int m = 0;
        //    while (m < 3)
        //    {
        //        Console.Write("*");
        //        m++;
        //    }
        //    k++;
        //}

        #endregion

        #region  6) elmas
        //Console.WriteLine("orta satırdaki * sayısını girin (tek sayı)");
        //int n;
        //while (true)
        //{
        //    n = int.Parse(Console.ReadLine());
        //    if (n % 2 != 0)
        //    {
        //        break;
        //    }
        //    Console.Write("Lütfen tek sayı girin:  ");
        //}

        //int bosluk, yildiz;
        //int i = 1;
        //while (i <= n)
        //{
        //    bosluk = (n - i) / 2;
        //    yildiz = i;

        //    int j = 0;
        //    while (j < bosluk)
        //    {
        //        Console.Write(" ");
        //        j++;
        //    }

        //    j = 0;
        //    while (j < yildiz)
        //    {
        //        Console.Write("*");
        //        j++;
        //    }

        //    Console.WriteLine();
        //    i += 2;
        //}

        //i = n - 2;
        //while (i >= 1)
        //{
        //    bosluk = (n - i) / 2;
        //    yildiz = i;

        //    int j = 0;
        //    while (j < bosluk)
        //    {
        //        Console.Write(" ");
        //        j++;
        //    }

        //    j = 0;
        //    while (j < yildiz)
        //    {
        //        Console.Write("*");
        //        j++;
        //    }

        //    Console.WriteLine();
        //    i -= 2;
        //}


        #endregion

        #region  7)  Fibonacci
        //Console.Write("Lütfen Fibonacci adım sayısını giriniz: ");
        //int adim = int.Parse(Console.ReadLine());

        //int a = 1, b = 1, c;

        //Console.Write("Fibonacci Dizisi: " + a + " " + b + " ");

        //int i = 2;
        //while (i < adim + 2)
        //{
        //    c = a + b;
        //    Console.Write($"{c} ");
        //    a = b;
        //    b = c;
        //    i++;
        //}

        #endregion

        #region  8)  asalSayi
        //Console.WriteLine("Lütfen bir sayı giriniz.");
        //int girilenSayi = int.Parse(Console.ReadLine());

        //int sayi = 2;  
        //while (sayi <= girilenSayi)
        //{
        //    int bolenSayisi = 0;
        //    int i = 1;

        //    while (i <= sayi)
        //    {
        //        if (sayi % i == 0)
        //        {
        //            bolenSayisi++;
        //        }
        //        i++;
        //    }

        //    if (bolenSayisi == 2)  
        //    {
        //        Console.Write(sayi + " ");
        //    }

        //    sayi++;
        //}

        #endregion

        #region  9) 1000 sayısının çarpanları   
        //int sayi = 1000;
        //int i = 1; // Çarpanları 1'den başlayarak kontrol et

        //while (i <= sayi)
        //{
        //    if (sayi % i == 0) // Eğer sayı i'ye tam bölünüyorsa
        //    {
        //        Console.Write(i + " "); // i bir çarpanıdır, yazdır
        //    }
        //    i++; // i'yi bir arttırarak sonraki sayıya geç
        //}

        #endregion

        #region  10)  Bankamatik
        //int sifre = 123;
        //int bakiye = 10000;
        //int hak = 3;
        //string cevap;
        //int girilenSifre;
        //bool isAuthenticated = false;

        //while (hak > 0 && !isAuthenticated)
        //{
        //    Console.Write("Lütfen Şifrenizi giriniz: ");
        //    girilenSifre = int.Parse(Console.ReadLine());

        //    if (girilenSifre == sifre)
        //    {
        //        isAuthenticated = true;
        //        do
        //        {
        //            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz. (Sadece sayı yazın).");
        //            Console.WriteLine("1. Para çekme");
        //            Console.WriteLine("2. Para yatırma");
        //            Console.WriteLine("3. Bakiye Kontrolü");
        //            Console.WriteLine("4. Çıkış");
        //            int secim = int.Parse(Console.ReadLine());

        //            switch (secim)
        //            {
        //                case 1:
        //                    Console.WriteLine("Ne kadar para çekmek istiyorsunuz?");
        //                    int cekilecekTutar = int.Parse(Console.ReadLine());
        //                    if (cekilecekTutar <= bakiye)
        //                    {
        //                        bakiye -= cekilecekTutar;
        //                        Console.WriteLine("Para çekme işlemi başarıyla gerçekleşti. GÜNCEL BAKİYE: " + bakiye);
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Bakiye yetersiz.");
        //                    }
        //                    break;
        //                case 2:
        //                    Console.WriteLine("Ne kadar para yatırmak istiyorsunuz?");
        //                    int yatirilacakTutar = int.Parse(Console.ReadLine());
        //                    if (yatirilacakTutar > 0)
        //                    {
        //                        bakiye += yatirilacakTutar;
        //                        Console.WriteLine("Para yatırma işlemi başarıyla gerçekleşti. GÜNCEL BAKİYE: " + bakiye);
        //                    }
        //                    break;
        //                case 3:
        //                    Console.WriteLine("GÜNCEL BAKİYE: " + bakiye);
        //                    break;
        //                case 4:
        //                    Console.WriteLine("Çıkış yapılıyor.");
        //                    return; // Çıkış işlemi için döngüyü kır
        //            }

        //            Console.WriteLine("Ana Menüye dönmek ister misiniz? (y/n)");
        //            cevap = Console.ReadLine();
        //        } while (cevap == "y");
        //    }
        //    else
        //    {
        //        hak--;
        //        if (hak > 0)
        //        {
        //            Console.WriteLine($"Şifre yanlış! Kalan hakkınız: {hak}");
        //            Console.WriteLine("Devam etmek için bir tuşa basın ardından şifrenizi girin.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Kartınız bloke oldu.");
        //        }
        //    }
        //}

        #endregion
    }
    }
