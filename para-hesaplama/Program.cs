namespace para_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para hesaplama uygulamasına hoşgeldiniz!");
            Console.WriteLine("Siparis tutarini giriniz: ");
            int siparisTutari = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Sipariş tutarınız : " + siparisTutari);
            Console.WriteLine("Ödeme yönteminizi seçin (Kart/Nakit):");
            string odemeYontemi = Console.ReadLine();
            Console.Clear();

            if (odemeYontemi.ToLower() == "nakit")
            {
                Console.WriteLine("Sipariş Tutarınız : " + siparisTutari);
                Console.WriteLine("Ödeme yönteminiz : " + odemeYontemi);
                Console.WriteLine("Ödemeyi kapıda yapıcaksınız.");
                Console.WriteLine("Onaylıyorsanız bir tuşa basın.");
                Console.ReadLine();

                Console.WriteLine("Verilecek nakit para mıktarını belirleyin : ");
                int nakit = int.Parse(Console.ReadLine());

                if (nakit >= siparisTutari)
                {
                    Console.WriteLine("Alıcağınız para üstü :" + (nakit - siparisTutari));
                }
                else if (nakit <= siparisTutari)
                {
                    Console.WriteLine((nakit - siparisTutari)+" miktar paranız eksik.");
                }
            }
            else if (odemeYontemi.ToLower() == "kart")
            {
                Console.WriteLine("Sipariş Tutarınız : " + siparisTutari);
                Console.WriteLine("Ödeme Yöntemi : " + odemeYontemi);
                Console.WriteLine("Ödemeniz online olarak yapılacaktır.");
                Console.WriteLine("Onaylıyorsanız herhangi bir tuşa basın.");
                Console.ReadLine();

                Console.WriteLine("Kart bakiyenizi giriniz : ");
                int kart = int.Parse(Console.ReadLine());

                Console.WriteLine("Katınızdan "+(siparisTutari)+" miktar para çekilicektir.");
                Console.WriteLine("Onaylıyorsanız bir tuşa basın.");
                Console.ReadLine();

                if (kart >= siparisTutari)
                {
                    Console.WriteLine("Ödeme tamamlandı.");
                    Console.WriteLine("Kalan kart bakiyesi : " + (kart - siparisTutari));
                }
                else if (kart <= siparisTutari)
                {
                    Console.WriteLine("Yetersiz bakiye. ");
                    Console.WriteLine("Eksik bakiye tutarı " + (kart - siparisTutari));
                }


            }
            else
            {
                Console.WriteLine("Hatalı ödeme yöntemi. Lütfen geçerli bir ödeme yöntemi girin.");
            }



        }
    }
}
