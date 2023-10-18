public class Cakes
{
    public static void Start()
    {
        string tort1 = "Тортик";
        string tort2 = "Тортище";
        string tort3 = "Торт95";

        int tort1cena = 1507;
        int tort2cena = 3600;
        int tort3cena = 200;

        Console.Write("Муьлха торт еза хьуна?: ");

        string otvetpolzovatelya = Console.ReadLine();

        if (otvetpolzovatelya == tort1)
        {
            Console.WriteLine($"{tort1} ах {tort1cena} сом доьху");
        }
        else if (otvetpolzovatelya.ToLower() == tort2)
        {
            Console.WriteLine($"{tort2} {tort2cena} сом доьху");
        }
        else if (otvetpolzovatelya == tort3)
        {
            Console.WriteLine($"{tort3} {tort3cena} сом доьху");
        }
        else
        {
            Console.WriteLine($"{otvetpolzovatelya} йац нету давай досвидание");
        }
    }
}
