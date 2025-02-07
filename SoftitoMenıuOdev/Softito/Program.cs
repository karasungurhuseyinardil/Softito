using System;
using System.Collections.Generic;

namespace RestoranUygulamasi
{
    class Program
    {
       
        class Masa
        {
            public int Id { get; set; }
            public bool Dolu { get; set; }
            public List<Siparis> Siparisler { get; set; }

            public Masa(int id)
            {
                Id = id;
                Dolu = false;          
                Siparisler = new List<Siparis>();
            }
        }

       
        class Siparis
        {
            public string UrunAdi { get; set; }
            public decimal Ucret { get; set; }
        }

       
        static List<Siparis> etYemekleri = new List<Siparis>()
        {
            new Siparis { UrunAdi = "1) Et Menü", Ucret = 50 },
            new Siparis { UrunAdi = "2) Tavuk Menü", Ucret = 40 },
            new Siparis { UrunAdi = "3) Köfte Menü", Ucret = 45 },
        };

        static List<Siparis> pizzalar = new List<Siparis>()
        {
            new Siparis { UrunAdi = "4) Margarita Pizza", Ucret = 35 },
            new Siparis { UrunAdi = "5) Karışık Pizza",   Ucret = 45 },
            new Siparis { UrunAdi = "6) Sucuklu Pizza",   Ucret = 40 }
        };

        static List<Siparis> sicakIcecekler = new List<Siparis>()
        {
            new Siparis { UrunAdi = "1) Çay",    Ucret = 5  },
            new Siparis { UrunAdi = "2) Kahve",  Ucret = 10 }
        };

        static List<Siparis> sogukIcecekler = new List<Siparis>()
        {
            new Siparis { UrunAdi = "3) Kola",   Ucret = 10 },
            new Siparis { UrunAdi = "4) Ayran",  Ucret = 8  }
        };

        
        static List<Masa> masalar = new List<Masa>();

        
        static decimal toplamCiro = 0;

        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 7; i++)
            {
                masalar.Add(new Masa(i));
            }

            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== ANA MENÜ ===");
                Console.WriteLine("[1] Masa Aç");
                Console.WriteLine("[2] Masa İşlem");
                Console.WriteLine("[3] Masa Hesap");
                Console.WriteLine("[4] Kasa İşlemleri");
                Console.WriteLine("[0] ÇIKIŞ");
                Console.Write("Seçiminiz: ");

                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        MasaAc();
                        break;
                    case "2":
                        MasaIslem();
                        break;
                    case "3":
                        MasaHesap();
                        break;
                    case "4":
                        KasaIslemleri();
                        break;
                    case "0":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MasaAc()
        {
            Console.Clear();
            Console.WriteLine("=== MASA AÇ ===");
            
            foreach (var masa in masalar)
            {
                Console.WriteLine($"{masa.Id}.Masa [{(masa.Dolu ? "dolu" : "boş")}]");
            }
            Console.Write("Açmak istediğiniz masa ID'sini girin (Ana menü için ESC): ");

            string giris = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(giris))
                return; 

            if (int.TryParse(giris, out int masaId))
            {
                Masa secilenMasa = masalar.Find(m => m.Id == masaId);
                if (secilenMasa != null)
                {
                    if (!secilenMasa.Dolu)
                    {
                        secilenMasa.Dolu = true;
                        Console.WriteLine($"Masa {secilenMasa.Id} açıldı. Sipariş ekleyelim...");

                        UrunEklemeEkrani(secilenMasa);
                    }
                    else
                    {
                        Console.WriteLine("Bu masa zaten dolu!");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz masa!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz girdi!");
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void UrunEklemeEkrani(Masa masa)
        {
           
            bool devam = true;
            while (devam)
            {
                Console.Clear();
                Console.WriteLine($"=== MASA {masa.Id} - SİPARİŞ EKRANI ===\n");

                Console.WriteLine("YEMEKLER (Et Yemekleri / Pizzalar)");
                foreach (var urun in etYemekleri)
                    Console.WriteLine($"{urun.UrunAdi} - {urun.Ucret} TL");
                foreach (var urun in pizzalar)
                    Console.WriteLine($"{urun.UrunAdi} - {urun.Ucret} TL");

                Console.WriteLine("\nİÇECEKLER (Sıcak / Soğuk)");
                foreach (var urun in sicakIcecekler)
                    Console.WriteLine($"{urun.UrunAdi} - {urun.Ucret} TL");
                foreach (var urun in sogukIcecekler)
                    Console.WriteLine($"{urun.UrunAdi} - {urun.Ucret} TL");

                Console.WriteLine("\n[SPACE] Onayla ve masayı DOLU olarak kaydet");
                Console.WriteLine("[ESC]   Ana menüye dön");
                Console.WriteLine("[Sol Ok] Geri git (bir önceki ekrana)");
                Console.Write("\nÜrün eklemek için ürün numarasını girin (boş geç: çık): ");

                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    
                    return;
                }

               
                if (input.Equals(" "))
                {
                    
                    Console.WriteLine("Sipariş onaylandı.");
                    return;
                }
                else if (input.Equals("ESC", StringComparison.OrdinalIgnoreCase))
                {
                    
                    return;
                }
                else if (input.Equals("SOL", StringComparison.OrdinalIgnoreCase))
                {
                    
                    return;
                }
                else
                {
                    
                    Siparis secilenUrun = null;

                    
                    secilenUrun = AraUrun(input, etYemekleri);
                    if (secilenUrun == null)
                        secilenUrun = AraUrun(input, pizzalar);
                    if (secilenUrun == null)
                        secilenUrun = AraUrun(input, sicakIcecekler);
                    if (secilenUrun == null)
                        secilenUrun = AraUrun(input, sogukIcecekler);

                    if (secilenUrun != null)
                    {
                        
                        masa.Siparisler.Add(new Siparis
                        {
                            UrunAdi = secilenUrun.UrunAdi,
                            Ucret = secilenUrun.Ucret
                        });
                        Console.WriteLine($"'{secilenUrun.UrunAdi}' eklendi.");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ürün numarası!");
                    }
                }

                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }

        static Siparis AraUrun(string input, List<Siparis> urunListesi)
        {
            
            foreach (var urun in urunListesi)
            {
                
                if (!string.IsNullOrEmpty(urun.UrunAdi) && urun.UrunAdi.StartsWith(input + ")"))
                {
                    return urun;
                }
            }
            return null;
        }

        static void MasaIslem()
        {
            Console.Clear();
            Console.WriteLine("=== MASA İŞLEM ===");
            Console.Write("İşlem yapmak istediğiniz masa ID'sini girin: ");
            string giris = Console.ReadLine();
            if (int.TryParse(giris, out int masaId))
            {
                Masa secilenMasa = masalar.Find(m => m.Id == masaId);
                if (secilenMasa != null && secilenMasa.Dolu)
                {
                   
                    UrunEklemeEkrani(secilenMasa);
                }
                else
                {
                    Console.WriteLine("Geçersiz masa ya da masa boş!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz girdi!");
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void MasaHesap()
        {
            Console.Clear();
            Console.WriteLine("=== MASA HESAP ===");
            Console.Write("Hesap almak istediğiniz masa ID'sini girin: ");
            string giris = Console.ReadLine();
            if (int.TryParse(giris, out int masaId))
            {
                Masa secilenMasa = masalar.Find(m => m.Id == masaId);
                if (secilenMasa != null && secilenMasa.Dolu)
                {
                    
                    decimal toplam = 0;
                    Console.WriteLine($"Masa {secilenMasa.Id} Sipariş Listesi:");
                    foreach (var siparis in secilenMasa.Siparisler)
                    {
                        Console.WriteLine($"- {siparis.UrunAdi} : {siparis.Ucret} TL");
                        toplam += siparis.Ucret;
                    }
                    Console.WriteLine($"Toplam Tutar: {toplam} TL");
                    Console.Write("Ödeme alındı mı? (E/H): ");
                    string odeme = Console.ReadLine();
                    if (odeme.Equals("E", StringComparison.OrdinalIgnoreCase))
                    {
                        
                        secilenMasa.Dolu = false;
                        secilenMasa.Siparisler.Clear();
                        toplamCiro += toplam;
                        Console.WriteLine("Masa kapatıldı, ödeme alındı.");
                    }
                    else
                    {
                        Console.WriteLine("Ödeme alınmadı, masa hala dolu.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz masa ya da masa boş!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz girdi!");
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void KasaIslemleri()
        {
            Console.Clear();
            Console.WriteLine("=== KASA İŞLEMLERİ ===");
            
            Console.WriteLine($"Toplam Ciro: {toplamCiro} TL");
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
