using System;

file class ProctoTak; //Доступен из того же файла где определён

public class Car

{
    
    // public - доступно из любого места
    public string Brand { get; set; }


    // private - доступно только внутри этого класса
    private string vin;



    // internal - доступно только внутри текущей сборки (проекта)
    internal int Year;


    // protected - доступно только в этом классе и производных классах (наследниках)
    protected string Model;


    // protected internal - доступно в текущей сборке и производных классах (наследниках)
    protected internal string Color;


    // private protected - доступно только в этом классе и производных (классах наследнкиах) в той же сборке
    private protected int Mileage;


    // Конструктор класса Car, который инициализирует все свойства
    public Car(string brand, string vin, int year, string model, string color, int mileage)

    {

        Brand = brand;          // Инициализируем публичное свойство Brand
        this.vin = vin;         // Инициализируем приватное свойство vin
        Year = year;            // Инициализируем internal свойство Year
        Model = model;          // Инициализируем protected свойство Model
        Color = color;          // Инициализируем protected internal свойство Color
        Mileage = mileage;      // Инициализируем private protected свойство Mileage

    }


    // Метод для отображения информации о автомобиле

    public void DisplayInfo()

    {

        // Выводим информацию о публичных, защищенных и private protected свойствах

        Console.WriteLine($"Brand: {Brand}, Year: {Year}, Model: {Model}, Color: {Color}, Mileage: {Mileage}");
        Console.ReadKey();

    }


    // Приватный метод для получения VIN

    private string GetVin()

    {
        return vin; // Возвращаем значение приватного свойства vin
    }

}


// Класс SportsCar наследует от Car
public class SportsCar : Car

{
    
    // Конструктор класса SportsCar

    public SportsCar(string brand, string vin, int year, string model, string color, int mileage)

        : base(brand, vin, year, model, color, mileage) // Вызов базового конструктора

    {

        // Тело конструктора пустое.

    }


    // Метод для отображения деталей спорткара

    public void ShowDetails()

    {

        // Получаем доступ к защищенным и защищенным внутренним свойствам

        Console.WriteLine($"Model: {Model}, Color: {Color}");
        Console.ReadKey();
    }
}


// Класс с модификатором file
file class CarHelper

{

    // Метод для вывода характеристик автомобиля

    public void DisplayAdditionalInfo(Car car)

    {
        // Доступ к публичным и internal свойствам 

        Console.WriteLine($"Характеристики авто: {car.Brand}, Year: {car.Year}");
        Console.ReadKey();
    }

}


class Program

{

    static void Main()

    {

        // Создаем объект myCar класса Car и инициализируем его параметры

        Car myCar = new Car("Toyota", "1HGBH41JXMN109186", 2020, "Corolla", "Red", 15000);

        myCar.DisplayInfo(); // Отображаем информацию о myCar


        // Создаем объект mySportsCar класса SportsCar

        SportsCar mySportsCar = new SportsCar("Ferrari", "1HGCM82633A123456", 2022, "488", "Red", 5000);

        mySportsCar.ShowDetails(); // Отображаем детали спорткара


        // Используем класс CarHelper из того же файла

        CarHelper helper = new CarHelper();

        helper.DisplayAdditionalInfo(myCar); // Вывод дополнительной информации о легковом автомобиле

    }

}





