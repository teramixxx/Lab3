using System;

class Program
{
    public interface ITranslationStrategy
    {
        string Translate(string phrase);
    }

    public class AmericanTranslationStrategy : ITranslationStrategy
    {

        public string Translate(string phrase)
        {
            return phrase + ", Степан!";
        }
    }

    public class AustralianTranslationStrategy : ITranslationStrategy
    {

        public string Translate(string phrase)
        {
            return phrase + ", Сергiй!";
        }
    }

    public class EnglishTranslation
    {
        public static string Translate(string phrase,
                ITranslationStrategy strategy)
        {
            return strategy.Translate(phrase);
        }

        static void Main(string[] args)
        {
            string aussieHello = Translate("Привiт",
                    new AustralianTranslationStrategy());
            Console.WriteLine(aussieHello);
            string usaHello = Translate("Привiт",
                    new AmericanTranslationStrategy());
            Console.WriteLine(usaHello);
            Console.ReadLine();
        }
    }

}