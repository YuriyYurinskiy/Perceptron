using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronConsoleApplication
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Количесво образов
            int n,
                // Число С
                c,
                // Количесво типов образов
                types_images = 10,
                // Число свойств
                attr = 9;

            List<Image> images = new List<Image>();

            Console.Write("Введите число образов: ");
            n = Int16.Parse(Console.ReadLine());


            Console.Write("Введите число C: ");
            c = Int16.Parse(Console.ReadLine());

            // Заполнение образов
            for (int i = 0; i < n; i++)
            {
                Image temp = new Image(attr, c);
                temp.fillConsole();
                images.Add(temp);
            }

            Perceptron p = new Perceptron(images, types_images);
            p.study();
        }
    }
}
