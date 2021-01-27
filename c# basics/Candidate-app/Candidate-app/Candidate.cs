﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_app
{
    class Candidate
    {
        private int id;
        private string name;
        private char grade;

        public void setId()
        {
            Console.WriteLine("Enter the candidate id: ");
            id = int.Parse(Console.ReadLine());
        }
        public void setName()
        {
            Console.WriteLine("Enter the candidate Name: ");
            name = Console.ReadLine();
        }
        public void setGrade()
        {
            Console.WriteLine("Enter the candidate Grade: ");
            grade = char.Parse(Console.ReadLine());
        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public char getGrade()
        {
            return grade;
        }
        public Candidate comparison(Candidate a,Candidate b)
        {
            Console.WriteLine("The better candidate is: ");
            Candidate test = new Candidate();
            int a1=(a.grade);
            int b1=(b.grade);
            if (a1 < b1)
                test = a;
            else if (b1 < a1)
                test= b;
            else if (a1 == b1)
                Console.WriteLine("Both candidates have the same score");
            return test;
            
        }
    }
}
