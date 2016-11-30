using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumaDe2NumerosEnteros()
        {
            int a = 1;
            int b = 2;
            int resultado = Operaciones.Suma(a, b);
            Assert.AreEqual(resultado, 3);
        }
        [TestMethod]
        public void RestaDe2NumerosEnteros()
        {
            int a = 2;
            int b = 3;
            int resultado= Operaciones.Resta(a, b);
            Assert.AreEqual(resultado, -1);
        }
        [TestMethod]
        public void RestaDe2NumerosEnterosNoDebeSerMenorDe0()
        {   //si el resultado de la resta es < 0 retornar 0
            int a = 3;
            int b = 2; 
            int resultado = Operaciones.Resta(a, b);
            Assert.AreEqual(resultado ,0);
        }
        [TestMethod]
        public void Mutiplicacionde2NumerosEnteros()
        {
            int a = 2;
            int b = 2;
            int resultado = Operaciones.Multiplicacion(a, b);
            Assert.AreEqual(resultado, 4);          
        }
        [TestMethod]
        public void MultiplicacionPorNegativosNoPermitida()
        {// si se mandan valores negativos regresar 0
            int a = -2;
            int b = 6;
            int resultado = Operaciones.Multiplicacion(a, b);
            Assert.AreEqual(resultado, 0);
        }
        [TestMethod]
        public void DivicionEntre2NumerosEnteros()
        {
            int a = 25;
            int b = 5;
            int resultado = Operaciones.Divicion(a, b);
            Assert.AreEqual(resultado,5);
        }
        [TestMethod]
        public void DivicionEntre0NoValida()
        {//si se divide entre 0 regresar 0
            int a = 25;
            int b = 0;
            int resultado = Operaciones.Divicion(a, b);
            Assert.AreEqual(resultado, 0);
        }
        [TestMethod]
        public void OrdenDeMayorAMenorDeArreglo()
        {
            int[] arregloOrdenado= new int[] {-56,1,20,45,45,90,867};
            int[] arregloDesordenado= new int[] { 1,45,867,45,-56,20,99};
            Assert.AreEqual(Operaciones.Ordenar(arregloDesordenado),arregloDesordenado);
        }

    }
}
