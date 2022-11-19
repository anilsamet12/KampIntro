namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmişMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if(dolarDun> dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");

            }

            if(sistemeGirisYapmişMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }




            Console.WriteLine(kategoriEtiketi);
        }
    }
}