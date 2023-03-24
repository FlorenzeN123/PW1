using System;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В гонке участвует 4 автомобиля:");
            Console.WriteLine();
            // Создаем экземпляры класса Car
            var car1 = new Car(120, "Opel Corsa");
            var car2 = new Car(200, "Priora White");
            var car3 = new Car(150, "Priora Brown");
            var car4 = new Car(90, "VAZ2108");

            // Выводим информацию о каждом автомобиле
            car1.PrintInfo();
            car2.PrintInfo();
            car3.PrintInfo();
            car4.PrintInfo();

            // Определяем победителя гонки
            var winner = GetWinner(car1, car2, car3, car4);
            Console.WriteLine($"Победитель: {winner.Name}");

            Console.ReadKey();
        }

        // Метод для определения победителя гонки
        static Car GetWinner(params Car[] cars)
        {
            var winner = cars[0];

            for (int i = 1; i < cars.Length; i++)
            {
                if (cars[i].MaxSpeed > winner.MaxSpeed)
                {
                    winner = cars[i];
                }
            }

            return winner;
        }
    }

    class Car
    {
        public double MaxSpeed { get; set; }
        public string Name { get; set; }

        public Car(double maxSpeed, string name)
        {
            MaxSpeed = maxSpeed;
            Name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Автомобиль: {Name}, максимальная скорость: {MaxSpeed} км/ч");
        }
    }
}