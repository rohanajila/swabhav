using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person("rohan",23,"Male",1.75f,90.5f);
            PersonGetMisingInfo(obj);
            obj.CalcBmiIndex();
            PersonInfoDisplay(obj);
            Person obj1 = new Person("ashar", 23);
            PersonGetMisingInfo(obj1);
            obj1.CalcBmiIndex();
            PersonInfoDisplay(obj1);
            Console.ReadKey();

        }
        public static void PersonInfoDisplay(Person obj)
        {
            Console.WriteLine("Name: " + obj.getName());
            Console.WriteLine("Age: " + obj.getAge());
            Console.WriteLine("Gender: " + obj.getGender());
            Console.WriteLine("Height: " + obj.getHeight());
            Console.WriteLine("Weight: " + obj.getWeight());
            Console.WriteLine("BMI Index: " + obj.getBmiIndex());
            if (obj.getBmiIndex() < 18.5)
                Console.WriteLine("UNDERWEIGHT!");
            if (obj.getBmiIndex() >= 18.5 && obj.getBmiIndex() <= 24.9)
                Console.WriteLine("Normal Weight");
            if (obj.getBmiIndex() >= 25 && obj.getBmiIndex() <= 29.9)
                Console.WriteLine("OVERWEIGHT!");
            if (obj.getBmiIndex() >= 30)
                Console.WriteLine("OBESE!!!!");
        }
        public static void PersonGetMisingInfo(Person obj)
        {
            if(obj.getHeight()==0f)
            {
                Console.WriteLine("Enter missing values: ");
                obj.setGender();
                obj.setHeight();
                obj.setWeight();
            }
        }
    }
}
