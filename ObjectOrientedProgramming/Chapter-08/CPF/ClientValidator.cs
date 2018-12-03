using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_08.CPF
{
    public class ClientValidator
    {
        public bool IsValid(Client client)
        {
            if (client.Age < 18 && string.IsNullOrEmpty(client.MotherName))
                return false;
            return true;
        }
    }
}
