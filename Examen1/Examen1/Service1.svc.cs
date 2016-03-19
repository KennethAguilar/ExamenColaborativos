﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Examen1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string sumaResta(int columna1, int fila1, int columna2, int fila2)
        {

            string resultado;
            if ((columna1 == columna2) && (fila1 == fila2))
                resultado = "Tienen el mismo tamano";
            else
                resultado = "Son diferentes";

            return (resultado);
        }

        public string esCuadrada(int columna, int fila)
        {

            string resultado;
            if (columna == fila)
                resultado = "Es cuadrada";
            else
                resultado = "No es cuadrada";

            return resultado;
        }

        public string obtenerDiagonal()
        {

            string resultado = "";

            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            for (int i = 0; i < 3; i++)
                resultado += Convert.ToString(matriz[i][i]);

            return resultado;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
