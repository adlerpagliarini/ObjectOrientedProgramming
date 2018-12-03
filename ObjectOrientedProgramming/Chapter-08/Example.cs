using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_08.Example
{
    internal class Car
    {
        private readonly Tire Tire;
        private readonly Engine Engine;

        [Obsolete("A way to show that it shouldn't be used for developers, it's just needed for ORM like EF Core or Hibernate", false)]
        public Car() : this(new Tire(), new Engine())
        {
                
        }

        public Car(Tire tire, Engine engine)
        {
            Tire = tire;
            Engine = engine;
        }
    }

    internal class Tire
    {

    }

    internal class Engine
    {

    }

    internal class CPF
    {
        private string cpf;

        public CPF(string cpf)
        {
            if (cpf != "" && cpf.Length == 11)
                this.cpf = cpf;
            else
                throw new ArgumentException("Invalid CPF");
        }
    }

    internal class CPF2
    {
        private string cpf;

        public CPF2(string cpf)
        {
            this.cpf = cpf;
        }

        public bool IsValid() => (cpf != "" && cpf.Length == 11) ? true : false;
    }
}
