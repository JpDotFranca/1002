using NUnit.Framework;

namespace Teste
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Teste1()
        {
            float R = 2;
            float saidaEsperada = 12.5664f;
            float resultado = Runner.AreaDoCirculo(R);
            Assert.AreEqual(resultado, saidaEsperada);
        }

        [Test]
        public void Teste2()
        {
            float R = 100.64f;
            float saidaEsperada = 31819.3103f;
            float resultado = Runner.AreaDoCirculo(R);
            Assert.AreEqual(resultado, saidaEsperada);
        }

              [Test]
        public void Teste3()
        {
            float R = 150.00f;
            float saidaEsperada = 70685.7750f;
            float resultado = Runner.AreaDoCirculo(R);
            Assert.AreEqual(resultado, saidaEsperada);
        }

    }
}