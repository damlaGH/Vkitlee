namespace Vkitle
{
    public class Program
    {
        public static void Main()

        {
            bool devamMi;
            string secim = " ";
            do
            {
                Console.Clear();
                Console.WriteLine("Lütfen hastanın boyunu giriniz (metre cinsinden):");
                double boy = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Lütfen hastanın kilosunu giriniz (kg cinsinden):");
                double agirlik = Convert.ToDouble(Console.ReadLine());

                double vkitle = agirlik / (boy * boy);

                string teshis;
                if (vkitle < 18.5)
                {
                    teshis = "Zayıf";
                }
                else if (vkitle >= 18.5 && vkitle < 25)
                {
                    teshis = "İdeal kilolu";
                }
                else if (vkitle >= 25 && vkitle < 30)
                {
                    teshis = "Fazla kilolu";
                }
                else
                {
                    teshis = "Obez";
                }

                Console.WriteLine("Hastanın; boyu: {0}, kilosu: {1}, VKI indeksi: {2}, Teşhis: {3}", boy, agirlik, vkitle, teshis);
                //Console.WriteLine($"Hastanın; boyu: {boy}, kilosu: {agirlik}, VKI indeksi: {vkitle}, Teşhis: {teshis}"); string interpolation ile de yazabilirdik.

                do
                {
                    Console.WriteLine("Yeni bir hesaplama yapmak istiyor musunuz? (E/H)");
                    secim = Console.ReadLine();
                    if (secim == "E" || secim == "e" || secim == "H" || secim == "h")
                    {
                        devamMi = true;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız.");
                        devamMi = false;

                    }
                } while (devamMi == false);

            } while (secim == "E" || secim == "e");
        }

        }
    }
