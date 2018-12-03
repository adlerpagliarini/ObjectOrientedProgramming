using NUnit.Framework;
using ObjectOrientedProgramming.Chapter_08.CPF;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Tests.Chapter_08
{
    [TestFixture]
    public class ClientValidateTest
    {
        [Test]
        public void ValidateAdultClient()
        {
            var client = new Client(new BuilderCPF().Build("111.111.111-11"), "client", 18);

            var isValid = new ClientValidator().IsValid(client);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void ValidateUnderAgeClient()
        {
            var client = new Client(new BuilderCPF().Build("111.111.111-11"), "client", 17);

            var isValid = new ClientValidator().IsValid(client);

            Assert.IsFalse(isValid);
        }
    }
}
