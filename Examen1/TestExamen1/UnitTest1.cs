using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestExamen1.Cliente;

namespace TestExamen1
{
    [TestClass]
    public class UnitTest1
    {

        int cantidadColumasM1, cantidadColumnasM2, cantidadFilasM1, cantidadFilasM2;
        string resultadoEsperado;
        string resultadoReal;
        Service1Client cliente = new Service1Client();

        const string mensajeAlerta = "Resultado esperado = [{0}], pero el resultado real es [{1}] ";

        //Test para el metodo de sumaResta en donde se compara la cantidad de columnas de la matriz 1 con la contidad de
        //de columnas de la matriz 2 y la cantidad de filas de la matriz 1 con la cantidad de filas de la matriz 2
        [TestMethod]
        public void TestsumaResta()
        {
            cantidadColumasM1 = 3;
            cantidadColumnasM2 = 3;
            cantidadFilasM1 = 4;
            cantidadFilasM2 = 4;
            resultadoEsperado = "Tienen el mismo tamano";
            cliente = new Service1Client();

            resultadoReal = cliente.sumaResta(cantidadColumasM1, cantidadFilasM1, cantidadColumnasM2, cantidadFilasM2);

            Assert.AreEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAlerta, resultadoEsperado.ToString(), resultadoReal.ToString()));

        }

        //Test para el metodo esCuadrado en donde se compara la cantidad de columnas con la cantidad de filas: 
        //Si es la misma cantidad quiere deir que la matriz es cuadrada
        [TestMethod]
        public void testesCuadrado()
        {
            cantidadColumasM1 = 2;
            cantidadFilasM1 = 2;
            resultadoEsperado = "Es cuadrada";
            cliente = new Service1Client();

            resultadoReal = cliente.esCuadrada(cantidadColumasM1, cantidadFilasM1);

            Assert.AreEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAlerta, resultadoEsperado.ToString(), resultadoReal.ToString()));
        }

        //Test para el metodo obtenerDiagonal en donde la se obtiene los numeros de la diagonal formada en la matriz
        [TestMethod]
        public void testobtenerDiagonal()
        {

            resultadoEsperado = "261";
            cliente = new Service1Client();

            resultadoReal = Convert.ToString(cliente.obtenerDiagonal());

            Assert.AreEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAlerta, resultadoEsperado.ToString(), resultadoReal.ToString()));

        }

        [TestMethod]
        public void testEsNulo()
        {

            resultadoEsperado = "La matriz no es nula";
            cliente = new Service1Client();

            resultadoReal = Convert.ToString(cliente.esNulo());

            Assert.AreEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAlerta, resultadoEsperado.ToString(), resultadoReal.ToString()));

        }

        [TestMethod]
        public void testEsFila()
        {

            resultadoEsperado = "La matriz no es nx1";
            cliente = new Service1Client();

            resultadoReal = Convert.ToString(cliente.esFila());

            Assert.AreEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAlerta, resultadoEsperado.ToString(), resultadoReal.ToString()));

        }

        [TestMethod]
        public void testEsColumna()
        {

            resultadoEsperado = "La matriz no es 1xn";
            cliente = new Service1Client();

            resultadoReal = Convert.ToString(cliente.esColumna());

            Assert.AreEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAlerta, resultadoEsperado.ToString(), resultadoReal.ToString()));

        }

        [TestMethod]
        public void testTranspuesta()
        {
            int[][] resultadoEsperado = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };
           
            cliente = new Service1Client();

            resultadoReal = Convert.ToString(cliente.transpuesta());

            Assert.AreNotEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAlerta, resultadoEsperado.ToString(), resultadoReal.ToString()));

        }

        [TestMethod]
        public void testMulti()
        {
            

            string result = "49162536496491";
            cliente = new Service1Client();

            resultadoReal = Convert.ToString(cliente.Multi());

            Assert.AreEqual(resultadoReal, result,
                string.Format(mensajeAlerta, resultadoReal.ToString(), result.ToString()));

        }

        //Es diagonal
        [TestMethod]
        public void testEsDiagonal() {

            resultadoEsperado = "No es diagonal";
            cliente = new Service1Client();

            resultadoReal = Convert.ToString(cliente.esDiagonal());

            Assert.AreEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAlerta, resultadoEsperado.ToString(), resultadoReal.ToString()));

        }

    }
}

