internal class Program
{
    private static void Main(string[] args)
    {
        double x = 27.3198;
        int d;

        // Извлечь дробную часть x
        double fractionalPart = x - Math.Floor(x);

        // Преобразовать дробную часть в строку
        string fractionalPartStr = fractionalPart.ToString();

        // Извлечь первый символ дробной части строки
        char firstDigitChar = fractionalPartStr[2]; // 2, потому что первый символ — «0», а второй — «.»

        // Преобразовать первый символ в целое число
        d = int.Parse(firstDigitChar.ToString());

        Console.WriteLine("d = " + d); // Выводит: d = 3
    }
}