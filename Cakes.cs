public class Cakes
{
    public static void Start()
    {
        string[] cakes = { "Тортик", "Тортище", "Торт95", "Наполеон" };
        int[] cakePrices = { 1507, 3600, 200, 1230 };

        if (cakes.Length != cakePrices.Length){
            Console.WriteLine("Количество элементов цен и тортов не совпадает!");
            return;
        }

        Console.Write("Муьлха торт еза хьуна?: ");

        string otvetpolzovatelya = Console.ReadLine();

        if (otvetpolzovatelya == cakes[0])
        {
            Console.WriteLine($"{cakes[0]}ах {cakePrices[0]} сом доьху");
        }
        else if (otvetpolzovatelya.ToLower() == cakes[1])
        {
            Console.WriteLine($"{cakes[1]}ах {cakePrices[1]} сом доьху");
        }
        else if (otvetpolzovatelya == cakes[2])
        {
            Console.WriteLine($"{cakes[2]}ах {cakePrices[2]} сом доьху");
        }
        else
        {
            Console.WriteLine($"{otvetpolzovatelya} йац нету давай досвидание");
        }
    }
}
