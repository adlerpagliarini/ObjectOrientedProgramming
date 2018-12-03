using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_08.CPF
{
    public class BuilderCPF
    {
        public CPF Build(string cpf)
        {
            return (cpf != "" && cpf.Replace(".","").Replace("-","").Length == 11) ? new CPF(cpf) : throw new ArgumentException("Invalid CPF");
        }
    }
}
