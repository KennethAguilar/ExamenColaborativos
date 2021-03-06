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

        public string esNulo()
        {

            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            if(matriz.Length == 0 )
                return "La matriz si es nula";
            else
                return "La matriz no es nula";
        }

        public string esColumna()
        {

            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            if (matriz.Length == 1)
                return "La matriz es 1xn";
            else
                return "La matriz no es 1xn";
        }

        public string esFila()
        {

            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            if (matriz[0].Length == 1)
                return "La matriz es nx1";
            else
                return "La matriz no es nx1";
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

        public string esTriangularInferior() {

            string resultado = "";

            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            for (int i = 0; i < 3; i++)
                for (int j = i-1; j >= 0; j--) {
                    if (j == 0)
                        resultado = "Es triangular inferior";
                    else
                        resultado = "No es triangular inferior";
                }

            return resultado;

        }

        public string esTriangularSuperior() {
            string resultado = "";

            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            for (int i = 0; i < 3; i++)
                for (int j = i + 1; j < 3; j++)
                {
                    if (j == 0)
                        resultado = "Es triangular superior";
                    else
                        resultado = "No es triangular superior";
                }

            return resultado;
        }

        public string transpuesta()
        {

            string resultado = "";

            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            for (int i = 0; i < 3; i++)
                for(int j = 0; j < 3; j ++)
                 resultado += Convert.ToString(matriz[j][i]);

            return resultado;
        }

        public string Multi()
        {

            string resultado = "";

            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            int[][] matriz2 = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    resultado += Convert.ToString(matriz[i][j] * matriz2[i][j]);

            return resultado;
        }

        public string simetrica()
        {

            string resultado = "";

            int[][] matriz = new int[][] {
                new int[] { 2, 2, 2},
                new int[] { 2, 2, 2},
                new int[] { 2, 2, 2}
            };

            

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                     resultado += Convert.ToString(matriz[j][i]);

            return resultado;
        }

        public string esDiagonal()
        {

            string resultado = "";

            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {

                    if (i != j)
                    {

                        if (matriz[i][j] != 0)
                            resultado = "No es diagonal";
                        else
                            resultado = "Es diagonal";
                    }
                }

            return resultado;

        }



        public string MultiplicarPorEscalar(int constante)
        {

            string result = "";
            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    matriz[i][j] = matriz[i][j] * constante;
                    result += Convert.ToString(matriz[i][j]);
                }
            }
            return result;
        }

        public string EsEscalar()
        {


            bool bandera = true;
            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };

            int num = matriz[0][0];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {
                        if (matriz[i][j] != 0)
                            bandera = false;
                    }
                    else
                    {
                        if (matriz[i][j] != num)
                            bandera = false;
                    }
                }
            if (bandera == true)
            {
                return "Si es escalar";
            }
            else
                return "No es escalar";
        }

        public string EsIdentidad()
        {

            int num = 0;
            bool bandera = true;
            int[][] matriz = new int[][] {
                new int[] { 2, 3, 4},
                new int[] { 5, 6, 7},
                new int[] { 8, 3, 1}
            };
            num = matriz[0][0];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {
                        if ((matriz[i][j] != 0) && (matriz[i][j] == 1))
                            bandera = true;
                    }
                    else
                    {
                            bandera = false;
                    }
                }
            if (bandera == true)
            {
                return "Si es Identidad";
            }
            else
                return "No es Identidad";
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
