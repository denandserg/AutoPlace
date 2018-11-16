using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class AutoShop : IComparable<AutoShop>
    {

        public string CarName; 
        public int MaxSpeed { get; set; }
        public double Cost { get; set; }
        public byte Discount { get; set; }
        public int ID { get; set; }

        public AutoShop()
        {
            Console.WriteLine("Введите идентификатор машины => ");
            this.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите марку машины => ");
            this.CarName = Console.ReadLine();
            Console.WriteLine("Введите максимальную скорость машины => ");
            this.MaxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость машины => ");
            this.Cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную скидку для машины => ");
            this.Discount = Convert.ToByte(Console.ReadLine());

        }

        // Реализуем интерфейс IComparable<T>
        public int CompareTo(AutoShop obj)
        {
            if (this.Cost > obj.Cost)
                return 1;
            if (this.Cost < obj.Cost)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return String.Format("{4}\tМарка: {0}\t\tМакс. скорость км.час: {1}\t\tЦена: {2:C}\t\tСкидка: {3}%",
                this.CarName, this.MaxSpeed, this.Cost, this.Discount, this.ID);
        }
    }
}
