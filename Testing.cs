using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Testing

    {
        public string GetCarBrand()

        {
            // Создаем объект myCar класса Car
            SportsCar myCar = new SportsCar("Toyota", "1HGBH41JXMN109186", 2020, "Corolla", "Red", 15000);

            // Возвращаем значение свойства Brand
            return myCar.Brand;
            
           
        }

    }


}
