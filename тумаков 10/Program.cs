using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface ICipher
{
    string Encode(string s);
    string Decode(string s);
}


namespace тумаков_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1\n Создать интерфейс ICipher, который определяет методы поддержки nшифрования строк \n Введите строку");

            ICipher acipher = new ACipher();
            ICipher bcipher = new BCipher();

            string s = Console.ReadLine();
            string encoded_acipher = acipher.Encode(s);
            string decoded_acipher = acipher.Decode(encoded_acipher);
            string encoded_bcipher = bcipher.Encode(s);
            string decoded_bcipher = bcipher.Decode(encoded_bcipher);

            Console.WriteLine($"Исходная строка: {s}");
            Console.WriteLine($"ACipher encoded: {encoded_acipher}");
            Console.WriteLine($"ACipher decoded: {decoded_acipher}");
            Console.WriteLine($"BCipher encoded: {encoded_bcipher}");
            Console.WriteLine($"BCipher decoded: {decoded_bcipher}");

            Console.WriteLine("Упражнение 10.2 \n программа работает с геометрическими фигурами");
            
            Circle circle = new Circle(0, 0, 5, "Красный", true);
            circle.MoveHorizontally(10);
            circle.MoveVertically(5);
            circle.ChangeColor("Фиолетовый");
            circle.DisplayStatus();
            Console.WriteLine($"Площадь: {circle.CalculateArea()}");

            Rectangle rectangle = new Rectangle(0, 0, 10, 20, "Синий", true);
            rectangle.MoveHorizontally(5);
            rectangle.MoveVertically(10);
            rectangle.ChangeColor("Оранжевый");
            rectangle.DisplayStatus();
            Console.WriteLine($"Площадь: {rectangle.CalculateArea()}");
            Console.ReadKey();
        }
    }
}
