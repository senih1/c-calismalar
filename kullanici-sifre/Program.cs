namespace kullanici_sifre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı kayıt sistemimize hoşgeldiniz.");
            Console.WriteLine("Kayıt olmak için herhangi bir tuşa basın.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Lütfen kendinize bir kullanıcı adı seçin:");
            string kullanici = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Başarılı.");
            Console.WriteLine("Kullanıcı adı: " +kullanici);
            Console.WriteLine("Lütfen bir şifre belirleyin: ");
            string sifre = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Kaydınız başarıyla gerçekleşti.");
            Console.WriteLine("Giriş yapmak için herhangi bir tuşa basın.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Giriş yapmak için kullanıcı adınızı girin:");
            string girisKullanici = Console.ReadLine();
            Console.Clear();

            if (girisKullanici == kullanici)
            {
                Console.WriteLine("Merhaba" +" " + kullanici + ", " +"lütfen şifrenizi girin.");
                string girisSifre = Console.ReadLine();
                Console.Clear();
                if (girisSifre == sifre)
                {
                    Console.WriteLine("Sisteme giriş başarılı.");
                    Console.WriteLine("Hoşgeldin" + " " +kullanici+"!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı şifre. Tekrar deneyiniz.");
                }
            }
            else
            {
                Console.Clear ();
                Console.WriteLine("Hatalı kullanıcı adı. Tekrar deneyiniz.");
            }
        }
    }
}