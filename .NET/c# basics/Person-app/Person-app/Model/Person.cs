using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_app
{
    class Person
    {
        private int Age;
        private string Name;
        private string Gender;
        private float Height;
        private float Weight;
        private float BmiIndex;
        public void Workout()
        {
            
            Weight = Weight-(Weight * 0.02f);
        }
        public void Eat()
        {
            Weight = Weight + (Weight * 0.05f);
        }
        public Person(string name,int age, string gender,float height,float weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int getAge()
        {
            return Age;
        }
        public string getName()
        {
            return Name;
        }
        public string getGender()
        {
            return Gender;
        }
        public float getHeight()
        {
            return Height;
        }
        public float getWeight()
        {
            return Weight;
        }
        public void setGender()
        {
            Console.WriteLine("Enter Gender: ");
            Gender = Console.ReadLine();
        }
        public void setWeight()
        {
            Console.WriteLine("Enter Weight(in kg's): ");
            Weight = float.Parse(Console.ReadLine());
        }
        public void setHeight()
        {
            Console.WriteLine("Enter Height(in meter's): ");
            Height = float.Parse(Console.ReadLine());
        }
        public void CalcBmiIndex()
        {
            BmiIndex = Weight / (Height * Height);
        }
        public float getBmiIndex()
        {
            return BmiIndex;
        }
    }
}
