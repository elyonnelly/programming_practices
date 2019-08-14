/*
Реализовать класс Car для представления автомобиля.
Класс содержит:
Автореализуемые свойства int CurrentSpeed – текущая скорость автомобиля, 
int MaxSpeed – максимальная скорость, string Name – имя автомобиля;
Закрытое поле bool carIsDead – работоспособна ли машина;
Максимальная скорость по умолчанию (пустой конструктор) – 100, 
конструктор с параметрами (задают скорость текущую и максимальную, имя);	
*/
using System;
using MyLib;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Использование делегатов для управления событиями *****\n");
            Car c1 = new Car("SlugBug", 100, 10);
            // Передаём в машину метод, который будет вызван при отправке оповещения.
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            // Разгоняем машину
            Console.WriteLine("***** Увеличиваем скорость *****");
            for (int i = 0; i < 6; i++)
                 c1.Accelerate(20);
            Console.ReadLine();
        }
        // Это метод-обработчик оповещений от машины.
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Сообщение от объекта типа Car *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
        /* ToDO: 
        1)	Определите тип-делегат, который будет использоваться для отправки оповещений в вызывающий код
        public delegate void CarEngineHandler (string msgForCaller)
        2)	Добавим в класс Car закрытое поле private CarEngineHandler listOfHandlers
        3)	Описать вспомогательную функцию в классе Car, позволяющую передавать метод, который 
        должен запускаться в вызывающем коде 
        public void RegisterWithCarEngine (CarEngineHandler methodToCall)
        4)	реализовать метод Accelerate(), в котором происходят вызовы методов из 
        вызывающего кода через делегат listOfHandlers.
        */
    }
}
