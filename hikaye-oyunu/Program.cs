namespace hikaye_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Başlangıç: Uzay Gemisi Kaçışı");
            Console.WriteLine("Gözlerini açtığında, soğuk ve metalik bir zeminin üzerindesin. Etrafına baktığında, kendini devasa bir uzay gemisinin içinde bulursun. Bir an için kafan karışmış olsa da, hafızanda bir parça parça hatırlamaya başlarsın: Sen bir uzay gemisi mürettebatıydın, ancak bir kaza sonucu gemi hasar gördü ve sen de şimdi geminin enkazı içindesin. Bu durumda ne yaparsın?");
            Console.WriteLine("Seçenekler:");
            Console.WriteLine("1-Çıkışı ara: Etrafındaki enkazı incelemeye başlar ve gemiden bir çıkış bulmaya çalışırsın. Belki de dışarıdaki uzay boşluğunda hayatta kalmak için bir yol bulabilirsin.");
            Console.WriteLine("2-Diğer hayatta kalanları ara: Eğer yalnız değilsen, diğer mürettebat üyelerini veya yolcuları aramaya karar verirsin. Birlikte çalışarak gemiden kaçma şansını artırabilirsiniz.");
            Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
            int secim1 = int.Parse(Console.ReadLine());
            Console.Clear();

            if (secim1 == 1)
            {
                Console.WriteLine("Çıkışı ara:");
                Console.WriteLine("Seçenekler:");
                Console.WriteLine("1-Açıklıktan dışarı doğru ilerle: ");
                Console.WriteLine("2-Açıklığın içine doğru ilerle: ");
                Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
                int secim2 = int.Parse(Console.ReadLine());
                Console.Clear();

                if (secim2 == 1)
                {
                    Console.WriteLine("Açıklıktan dışarı doğru ilerle:");
                    Console.WriteLine("Seçenekler:");
                    Console.WriteLine("1-Kapıyı zorla açmaya çalış: Kapının hava kilitli olduğunu fark etmiş olsan da, umutsuzluğa kapılmadan önce kapıyı açmak için bir yol bulmaya çalışırsın. Belki de bir güç kaynağına erişerek kapıyı açabilirsin ya da kapının mekanik kısmını manipüle ederek açmayı deneyebilirsin.");
                    Console.WriteLine("2-Yakındaki acil çıkış kapılarını ara: Uzay gemisinin dışına çıkmak için sadece bu kapının tek seçenek olmadığını düşünerek, yakındaki diğer acil çıkış kapılarını aramaya karar verirsin. Belki de bu kapılardan biri daha kolay açılabilir veya güvenli bir kaçış yolunu sağlayabilir.");
                    Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
                    int secim3 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (secim3 == 1)
                    {
                        Console.WriteLine("Kapıyı zorla açmaya çalış:");
                        Console.WriteLine("Metalik zeminde adımlarını hızlandırırken, kapının önüne gelirsin. Kapının hava kilitli olduğunu fark edersin. Ancak umutsuzluğa kapılmadan önce, kapıyı açmanın bir yolunu bulmaya kararlısındır. Etrafı incelediğinde, kapının yanında bir güç paneli olduğunu fark edersin. Paneli açarak iç mekanizmaya erişebilirsin. Şimdi ne yaparsın?");
                        Console.WriteLine("Seçenekler:");
                        Console.WriteLine("1-Güç panelini kullanarak kapıyı açmaya çalış.");
                        Console.WriteLine("2-Kapıyı zorlamak için fiziksel gücünü kullan.");
                        Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
                        int secim4 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (secim4 == 1)
                        {
                            Console.WriteLine("Güç panelini kullanarak kapıyı açmaya çalış:");
                            Console.WriteLine("Güç panelini hızla açar ve iç mekanizmaya erişirsin. Ancak, panelin içindeki devreler hasar görmüş gibi görünmektedir. Birkaç deneme yaparsın ama kapı açılmaz. Zaman daralıyor ve çaresizce etrafına bakınıyorsun. Bir umutla tekrar denemek ister misin?");
                            Console.WriteLine("Seçenekler:");
                            Console.WriteLine("1-Tekrar denemek için paneli tamir etmeye çalış.");
                            Console.WriteLine("2-Başka bir kaçış yolunu aramaya karar ver.");
                            Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
                            int secim5 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (secim5 == 1)
                            {
                                Console.WriteLine("Tekrar denemek için paneli tamir etmeye çalış:");
                                Console.WriteLine("Zamanın dar olmasına rağmen, umutsuzluğa kapılmadan önce hızla panelin iç mekanizmasına göz atarsın. Hasar görmüş devreleri incelemeye başlarsın. Elinden gelenin en iyisini yapmaya çalışırsın, ancak ne yazık ki, zaman ve kaynakların kısıtlı olması nedeniyle kapıyı açmaya yetecek kadar onarmak mümkün değildir. Derin bir nefes alırken, kabul etmek zorunda kalırsın ki, bu kaçış yolu kapalıdır ve zamanın daralmaktadır. Gözlerini kapatırken, son anlarını beklemeye başlarsın...");
                            }
                            else if (secim5 == 2)
                            {
                                Console.WriteLine("Başka bir kaçış yolunu aramaya devam etmek:");
                                Console.WriteLine("Güç panelinin başarısızlığı seni durdurmadı. Hala umut dolusun ve başka bir kaçış yolunu aramaya karar verirsin. Belki de başka bir bölümde daha uygun bir kaçış yolunu bulabilirsin.");
                                Console.WriteLine("Seçenekler:");
                                Console.WriteLine("1-Geminin haritasını ara:");
                                Console.WriteLine("2-Gizli geçitleri ara:");
                                Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
                                int secim11 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if(secim11 == 2)
                                {
                                    Console.WriteLine("Gizli geçitleri ara:");
                                    Console.WriteLine("Uzay gemisi genellikle gizli geçitler veya alternatif kaçış yollarıyla tasarlanır. Duvarlarda, tabanlarda veya tavanlarda gizlenmiş geçitleri aramak için dikkatlice odaları ve koridorları incelemeye karar verirsin.");
                                    Console.WriteLine("Kararlılıkla odaları ve koridorları araştırırken, bir duvar panelinin hafifçe sallandığını fark edersin. Daha yakından incelediğinde, panelin arkasında gizli bir geçit olduğunu keşfedersin. Hızla geçide doğru ilerlersin ve içeri girdiğinde, seni güvenli bir kaçış yoluna yönlendiren bir dizi tünel bulursun.");
                                    Console.WriteLine("Tüneller boyunca hızla ilerlerken, ardında kalan uzay gemisinin patlamasıyla sarsıldığını hissedersin. Ancak sen, gizli geçitlerin labirentinden çıkarak uzaklaşırken, kurtulmuş olursun.");
                                    Console.WriteLine("Tebrikler, kazandınız! Oyun burada sona eriyor. Teşekkür ederim oyunu oynadığınız için!");
                                }
                                else if(secim11 == 1)
                                {
                                    Console.WriteLine("Geminin haritasını ara:");
                                    Console.WriteLine("Yakınlarda bir harita ekranı veya geminin planını gösterebilecek bir kontrol paneli bulmaya çalışırsın. Belki de geminin yapısını daha iyi anlayarak daha etkili bir kaçış yolunu bulabilirsin.");
                                    Console.WriteLine("Koridorlarda dolaşırken, duvarlara monte edilmiş bir kontrol paneli görürsün. Hızla yaklaşıp paneli incelemeye başlarsın. Kontrol panelinin üzerinde bir dizi seçenek ve geminin planını gösteren bir harita bulunur. Ancak panelden yeterince bilgi alamadan, uzay gemisi bir patlama ile sarsılır.");
                                    Console.WriteLine("Patlamanın etkisiyle, duvarlardan düşen enkazlar seni altında gömer ve bilincini kaybedersin.");
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
                            }
                        }
                        else if (secim4 == 2)
                        {
                            Console.WriteLine("Başka bir kaçış yolunu aramaya devam etmek:");
                            Console.WriteLine("Güç panelinin başarısızlığı seni durdurmadı. Hala umut dolusun ve başka bir kaçış yolunu aramaya karar verirsin. Belki de başka bir bölümde daha uygun bir kaçış yolunu bulabilirsin.");
                            Console.WriteLine("Hızla güç panelinin yanından uzaklaşırsın ve geminin içinde ilerlemeye devam edersin. Koridorları ve odaları dikkatlice araştırırken, potansiyel kaçış yollarını ve diğer hayatta kalanları bulma umuduyla ilerlersin.");
                            Console.WriteLine("Ancak, zaman geçtikçe oksijen seviyesi hızla azalmaya başlar. Çaresizce çıkış yolunu ararken, son nefesini verir ve karanlığa gömülürsün.");;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
                        }
                    }
                    else if (secim3 == 2)
                    {
                        Console.WriteLine("Kapıyı zorlamak için fiziksel gücünü kullan:");
                        Console.WriteLine("Kapının hava kilitli olduğunu fark etmiş olmana rağmen, umutsuzluğa kapılmadan önce kapıyı fiziksel gücünü kullanarak zorlamaya karar verirsin. Belki de kapıyı açmak için yeterli güce sahip olabilirsin.");
                        Console.WriteLine("Kapıya sıkıca sarılır ve maksimum gücünü kullanarak onu açmaya çalışırsın. Başlangıçta zorlanırsın, ancak azmin ve kararlılığın sayesinde kapı kademeli olarak açılmaya başlar. Nihayetinde, kapı tamamen açılır ve önünde uzay gemisinin içinden uzanan karanlık bir koridora ulaşırsın.");
                        Console.WriteLine("Koridorda ilerlerken, acil çıkış yollarını ararken dikkatlice etrafına bakarsın. Aniden, sağ tarafında bir acil kaçış podunun olduğunu fark edersin. Podu kontrol ederken, içine hızla girersin ve kontrolleri yaparak podun motorlarını çalıştırırsın.");
                        Console.WriteLine("Pod, uzay gemisinden ayrıldığında, arkanda kalan geminin enkazını geride bırakırsın. Birkaç saat sonra, yakındaki bir uzay istasyonuna ulaşırsın ve kurtarılmış olursun.");
                        Console.WriteLine("Tebrikler, hayatta kalmayı başardınız! Oyun burada sona eriyor. Teşekkür ederim oyunu oynadığınız için!");


                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
                    }
                }
                else if (secim2 == 2)
                {
                    Console.WriteLine("Açıklığın İçine Doğru İlerle:");
                    Console.WriteLine("Belki de bu açıklık, uzay gemisinin başka bir bölümüne veya daha güvenli bir alana yönlendiriyor olabilir. Bu seçeneği seçerek daha fazla bilgi edinmeyi ve güvenli bir yol bulmayı umuyorsun.");
                    Console.WriteLine("Seçenekler:");
                    Console.WriteLine("Koridorları keşfetmeye devam et: Uzay gemisinin içinde ilerlemeye devam ederek, çıkış yolunu bulmak için farklı koridorları araştırırsın. Belki de güvenli bir çıkış yolu veya diğer hayatta kalanlarla karşılaşabileceğin bir bölge bulabilirsin.");
                    Console.WriteLine("Bir kontrol panelini incele: Yakınlarda bir kontrol paneli veya bilgi ekranı varsa, geminin durumu hakkında daha fazla bilgi edinmek için onu incelemeye karar verebilirsin. Belki de geminin hangi bölümünde olduğunu veya çıkış yolunu bulmak için ipuçları verebilir.");
                    Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
                    int secim10 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if(secim10 == 1)
                    {
                        Console.WriteLine("Koridorları Keşfetmeye Devam Et:");
                        Console.WriteLine("Uzay gemisinin içinde ilerlemeye devam ederek, çıkış yolunu bulmak için farklı koridorları araştırırsın. Ancak maalesef, seçtiğin koridor sana beklenmedik bir tehlikeyle karşılaştırır.");
                        Console.WriteLine("Koridorda ilerlerken, ani bir patlama meydana gelir ve sizi savurur. Gözlerini açtığında, etrafındaki karanlık ve sessizlik içinde hareketsiz yatıyorsun. Maalesef, seçtiğin yol senin için ölümcül olmuştur.");
                    }

                    else if (secim10 == 2)
                    {
                        Console.WriteLine("Bir kontrol panelini incele:");
                        Console.WriteLine("Yakınlarda bir kontrol paneli veya bilgi ekranı varsa, geminin durumu hakkında daha fazla bilgi edinmek için onu incelemeye karar verirsin. Kontrol panelini dikkatlice incelerken, geminin durumu hakkında önemli bilgiler bulabileceğini umuyorsun.");
                        Console.WriteLine("Kontrol panelini inceledikten sonra, geminin durumunun oldukça kötü olduğunu fark edersin. Birçok sistemde ciddi hasarlar olduğu ve geminin tamir edilemez durumda olduğunu anlarsın.");
                        Console.WriteLine("Tam bu sırada, gemide biriken atmosferik bozulma nedeniyle oksijen seviyesi hızla düşer ve nefes almakta zorlanmaya başlarsın. Panik içinde çevreye bakınırsın, ancak çıkış yolunu bulamazsın. Sonunda, nefes almak imkansız hale gelir ve karanlığa gömülürsün.");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
                }
            }

            else if (secim1 == 2)
                {
                    Console.WriteLine("Diğer hayatta kalanları ara:");
                    Console.WriteLine("Yakındaki bölgeleri ara: Yakındaki bölgelerdeki odalara ve koridorlara doğru ilerleyerek, diğer hayatta kalanları aramaya karar verirsin. Belki de onları sesleri veya işaretleriyle bulabilirsin.");
                    Console.WriteLine("Seçenekler:");
                    Console.WriteLine("1-Yakındaki bölgeleri ara ve diğer hayatta kalanları bulmaya çalış.");
                    Console.WriteLine("2-Başka bir yol aramaya devam et.");
                    Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
                    int secim7 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (secim7 == 2)
                    {
                        Console.WriteLine("Yakındaki bölgeleri ara ve diğer hayatta kalanları bulmaya çalış:");
                        Console.WriteLine("Kararlı adımlarla, yakındaki bölgeleri aramaya başlarsın. Koridorlarda dikkatlice ilerlerken, sesleri dinler ve işaretlere bakarsın. Birden, uzakta hafif bir ses duyarsın. Sesin geldiği yöne doğru hızla ilerlersin ve bir dönemeçten sonra, bir grup hayatta kalanın toplandığı bir odaya ulaşırsın.");
                        Console.WriteLine("Seçenekler:");
                        Console.WriteLine("2-Diğer hayatta kalanlarla birlikte kaçış planı yap.");
                        Console.WriteLine("2-Onlara katılmadan kendi başına kaçış yolu ara.");
                        Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
                        int secim8 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (secim8 == 2)
                        {
                            Console.WriteLine("Onlara katılmadan kendi başına kaçış yolu ara:");
                            Console.WriteLine("Grubun arasına karışmadan önce, kendi başına bir kaçış yolu bulma umuduyla odadan ayrılırsın. Koridorlarda hızlı adımlarla ilerlerken, etrafa dikkatlice bakınırsın. Birden, sol tarafındaki bir kapının hafifçe açık olduğunu fark edersin. Belki de bu, daha önce fark edilmemiş bir kaçış yoludur.");
                            Console.WriteLine("Seçenekler:");
                            Console.WriteLine("1-Kapıyı inceleyip içeri girmek.");
                            Console.WriteLine("2-Başka bir kaçış yolunu aramaya devam etmek.");
                            Console.WriteLine("Seçiminiz (Lütfen seçiminizi rakam olarak belirtiniz.):");
                            int secim9 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (secim9 == 1)
                            {
                                Console.WriteLine("Kapıyı inceleyip içeri girmek:");
                                Console.WriteLine("Hızla kapıya yaklaşırsın ve içeri doğru adımını atarsın. Kapıyı açtığında, küçük bir odaya girersin. Odada, acil kaçış podları bulunmaktadır. Heyecanla, bir podu kontrol edersin ve içine yerleşirsin. Kontrolleri hızla yapıp, podun motorlarını çalıştırırsın. Pod, uzay gemisinden ayrılırken, arkanda kalan geminin enkazını geride bırakırsın. Birkaç saat sonra, yakındaki bir uzay istasyonuna ulaşırsın ve kurtarılmış olursun.");
                                Console.WriteLine("Tebrikler, hayatta kalmayı başardınız! Oyun burada sona eriyor. Teşekkür ederim oyunu oynadığınız için!");

                            }
                            else if (secim9 == 2)
                        {
                                Console.WriteLine("Başka bir kaçış yolunu aramaya devam etmek:");
                                Console.WriteLine("Grubun arasına karışmadan önce, kendi başına bir kaçış yolu bulma umuduyla odadan ayrılırsın. Koridorlarda hızlı adımlarla ilerlerken, etrafa dikkatlice bakınırsın. Birden, sol tarafındaki bir kapının hafifçe açık olduğunu fark edersin. Belki de bu, daha önce fark edilmemiş bir kaçış yoludur.");
                                Console.WriteLine("Kapıya doğru hızla ilerlersin ve içeri adımını atarsın. Ancak, içeri girdiğinde karşına beklenmedik bir engel çıkar ve kapı arkanda kapanır. Odanın içinde bir tuzak olduğunu fark edersin. Hızla çıkış yollarını aramaya başlarsın, ancak her geçen saniye tuzak daha da etkili hale gelir.");
                                Console.WriteLine("Sonunda, tuzak seni yakalar ve hayatını kaybedersin.");
                        }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
                            }
                    }
                        else if (secim8 == 1)
                        {
                            Console.WriteLine("Onlara katılmadan kendi başına kaçış yolu ara:");
                            Console.WriteLine("Grubun arasına karışmadan önce, kendi başına bir kaçış yolu bulma umuduyla odadan ayrılırsın. Koridorlarda hızlı adımlarla ilerlerken, etrafa dikkatlice bakınırsın. Birden, sol tarafındaki bir kapının hafifçe açık olduğunu fark edersin. Belki de bu, daha önce fark edilmemiş bir kaçış yoludur.");
                            Console.WriteLine("Hızla kapıya yaklaşırsın ve içeri doğru adımını atarsın. Kapıyı açtığında, küçük bir odaya girersin. Odada, acil kaçış podları bulunmaktadır. Heyecanla, bir podu kontrol edersin ve içine yerleşirsin. Kontrolleri hızla yapıp, podun motorlarını çalıştırırsın.");
                            Console.WriteLine("Pod, uzay gemisinden ayrılırken, arkanda kalan geminin enkazını geride bırakırsın. Birkaç saat sonra, yakındaki bir uzay istasyonuna ulaşırsın ve kurtarılmış olursun.");
                            Console.WriteLine("Ancak, kurtuluşun kutlanırken, diğer hayatta kalanların akıbeti hakkında endişelenmeye başlarsın. Yalnızca senin hayatta kaldığın gerçeği seni rahatsız eder ve bu düşünceyle huzursuz olursun.");
                         }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
                        }
                }
                    else if (secim7 == 1)
                    {
                        Console.WriteLine("Yakındaki bölgeleri ara ve diğer hayatta kalanları bulmaya çalış:");
                        Console.WriteLine("Kararlı adımlarla, yakındaki bölgeleri aramaya başlarsın. Koridorlarda dikkatlice ilerlerken, sesleri dinler ve işaretlere bakarsın. Birden, uzakta hafif bir ses duyarsın. Sesin geldiği yöne doğru hızla ilerlersin ve bir dönemeçten sonra, bir grup hayatta kalanın toplandığı bir odaya ulaşırsın.");
                        Console.WriteLine("Diğer hayatta kalanlarla birlikte buluştuğunda, birlikte kaçış planı yapmaya başlarsınız. Ancak, kaçış yolunuzu bulamadan uzay gemisi çevresindeki tehlikeli durumlar artar ve zamanınız tükenir.");
                        Console.WriteLine("Sonunda, uzay gemisinin enkazı altında hayatını kaybettin.");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
                    }
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir giriş yapınız.");
            }



        }
    }
}