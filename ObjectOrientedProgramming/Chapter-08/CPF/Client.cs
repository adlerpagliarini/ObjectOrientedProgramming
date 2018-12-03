using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_08.CPF
{
    public class Client
    {
        public CPF CPF { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public int Age { get; set; }

        public Client(CPF cpf, string name, int age)
        {
            CPF = cpf;
            Name = name;
            Age = age;
        }

        public void SetMotherName(string name)
        {
            MotherName = name;
        }
    }
}
