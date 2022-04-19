using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [Test]
        [TestCase("A", "43644237")]
        [TestCase("Pepe López", "4.364.423-7")]
        public void DadosCédulaYNombreVálidos_AsignaLosValores(string nombre, string ci)
        {
            var p = new Person(nombre, ci);

            Assert.AreEqual(p.Name, nombre);
            Assert.AreEqual(p.ID, ci);
        }

        [Test]
        [TestCase("", "43644237")]
        [TestCase(null, "4.364.423-7")]
        public void DadoNombreInválidoYCédulaVálida_NoAsignaElNombreYAsignaCédula(string nombre, string ci)
        {
            var p = new Person(nombre, ci);

            Assert.AreEqual(p.Name, null);
            Assert.AreEqual(p.ID, ci);
        }

        [Test]
        [TestCase("A", "12345678")]
        [TestCase("B C", "1.234.567-8")]
        public void DadoNombreVálidoYCédulaInválida_AsignaNombreYNoAsignaCédula(string nombre, string ci)
        {
            var p = new Person(nombre, ci);

            Assert.AreEqual(p.Name, nombre);
            Assert.AreEqual(p.ID, null);
        }

        [Test]
        [TestCase("", "12345678")]
        [TestCase(null, "1.234.567-8")]
        public void DadoNombreInválidoYCédulaInválida_NoAsignaNombreYNoAsignaCédula(string nombre, string ci)
        {
            var p = new Person(nombre, ci);

            Assert.AreEqual(p.Name, null);
            Assert.AreEqual(p.ID, null);
        }
    }
}