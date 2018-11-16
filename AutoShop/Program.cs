using System;
using System.Collections.Generic;
using System.Threading;

namespace AutoShop
{
    

    class Program
    {
        static void Main()
        {
            Console.WriteLine(new string('$', 60));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var culture = new System.Globalization.CultureInfo("us-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            List<AutoShop> dic = new List<AutoShop>();

            // Создадим множество автомобилей

            Console.WriteLine("Просмотреть склад автомобилей - нажмите 1\nДобавить новый автомобиль - нажмите 2");
            int q = Convert.ToInt32(Console.ReadLine());
            if (q == 2)
            {
                dic.Add(new AutoShop());
                goto label;
            }

            else goto label;
            label:
            Console.WriteLine("Исходный каталог автомобилей: \n");
            foreach (AutoShop a in dic)
                Console.WriteLine(a);

            Console.WriteLine("\nТеперь автомобили отсортированны по стоимости: \n");
            dic.Sort();
            foreach (AutoShop a in dic)
                Console.WriteLine(a);

            Console.WriteLine();
            Console.WriteLine("Добавить еще одну машину - нажмите 1");
            int w = Convert.ToInt32(Console.ReadLine());
            if (w == 1)
            {
                dic.Add(new AutoShop());
                goto label;
            }

            Console.ReadLine();
        }
    }
}