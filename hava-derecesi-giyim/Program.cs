namespace hava_derecesi_giyim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba! Hava Durumu Kıyafet Önerisi uygulamasına hoş geldiniz.");
            Console.WriteLine("Bugün nasıl bir hava bekliyoruz? Dışarıdaki hava derecesini girin ve size uygun kıyafetleri önerelim!!");
            int derece = int.Parse(Console.ReadLine());
            Console.Clear();

            if (derece <= 0)
            {
                Console.WriteLine("Hava bugün oldukça soğuk görünüyor. Sıcak tutacak kıyafetler seçmeniz önemli. Dışarı çıkarken kalın bir mont veya ceket giymeniz, altına sıcak bir kazak tercih etmeniz ve başınızı bere ile kapamanız gerekebilir. Ellerinizi ve kulaklarınızı korumak için eldiven ve kulaklık da almayı unutmayın.");
            }
            else if (derece > 1 && derece <= 10)
            {
                Console.WriteLine("Hava bugün ılık görünüyor. Dışarıda biraz serin olabilir, bu yüzden orta kalınlıkta ve katmanlı giysiler tercih etmek iyi olabilir. Üzerinize ince bir kazak veya hırka giyebilir, üzerine de hafif bir ceket alabilirsiniz. Bu şekilde, hava sıcaklığına göre katmanlarınızı artırıp azaltarak rahat edebilirsiniz. Ayrıca, yanınızda bir şemsiye bulundurmayı da düşünebilirsiniz, çünkü hafif yağmurlar da olabilir.");
            }
            else if (derece > 11 && derece <= 20)
            {
                Console.WriteLine("Hava bugün oldukça ılık ve keyifli görünüyor. Dışarıda hafif bir serinlik olabilir, bu yüzden üzerinize orta kalınlıkta giysiler almanız iyi olabilir. Rahat bir gömlek veya tişört giyip üzerine hafif bir hırka veya ince bir ceket alabilirsiniz. Altına ise kot pantolon veya şort giyebilirsiniz. Bu şekilde, hem rahat hem de şık görünebilirsiniz. Güneş koruyucu bir şapka ve güneş gözlüğü de yanınızda bulundurmanızı öneririm, çünkü hava güneşli olabilir.");
            }
            else if (derece > 21 && derece <= 30)
            {
                Console.WriteLine("Hava bugün oldukça sıcak ve güneşli görünüyor. Bu sıcaklıkta serin ve rahat giysiler tercih etmek önemlidir. Rahat ve nefes alabilen bir tişört veya gömlek giyebilirsiniz. Altına hafif ve rahat bir şort veya pantolon seçebilirsiniz. Ayakkabı olarak rahat ve hava alan bir terlik veya spor ayakkabı tercih edebilirsiniz. Ayrıca, güneşin zararlı etkilerinden korunmak için güneş kremi ve güneş gözlüğü kullanmayı unutmayın. Suyunuzu da yanınıza alarak güneş altında hidrasyonunuzu sağlamayı unutmayın!");
            }
            else if (derece > 31)
            {
                Console.WriteLine("Hava bugün oldukça sıcak ve güneşli görünüyor. Bu sıcaklıkta serin ve rahat giysiler tercih etmek çok önemlidir. İnce ve hafif kumaşlardan yapılmış, terletmeyen ve nefes alabilen kıyafetler tercih etmelisiniz. Pamuklu ve gevşek kesimli tişörtler veya gömlekler giyebilirsiniz. Altına ise hafif ve rahat bir şort veya ince bir pantolon tercih edebilirsiniz. Ayakkabı olarak, hava alabilen ve rahat bir terlik veya sandalet seçebilirsiniz. Ayrıca, güneşin zararlı etkilerinden korunmak için geniş kenarlı bir şapka, güneş gözlüğü ve güneş kremi kullanmayı unutmayın. Sıcaklık nedeniyle vücudunuzun su ihtiyacı artar, bu yüzden bol bol su içmeyi unutmayın ve mümkünse güneş altında uzun süre kalmaktan kaçının.");
            }

        }
    }
}
