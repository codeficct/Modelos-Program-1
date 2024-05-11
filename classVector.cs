using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos_Program_1
{
    class classVector
    {
        // Propiedades
        const int dimension = 50;
        private int[] vector;
        private int cantidad;

        // Constructor
        public classVector()
        {
            vector = new int[dimension];
            cantidad = 0;
        }

        // Metodos:
        // Cargar randomicamente
        public void cargar(int numEle, int min, int max)
        {
            Random rand = new Random();
            this.cantidad = numEle;
            for(int idx = 1; idx <= this.cantidad; idx++)
            {
                vector[idx] = rand.Next(min, max + 1);
            }
        }
        
        // Descargar
        public string descargar()
        {
            string space = "";
            for(int idx = 1; idx <= this.cantidad; idx++)
            {
                space = space + vector[idx] + "|";
            }
            return space;
        }

        // Cargar elemento por elemento
        public void cargarElexEl(int number)
        {
            this.cantidad++;
            vector[this.cantidad] = number;
        }

        // Funciones auxiliares para las preguntas
        // ***************************************

        // Intercambio de elmentos por posiciones
        public void intercambio(int date1, int date2)
        {
            int aux = vector[date2];
            vector[date2] = vector[date1];
            vector[date1] = aux;
        }
        
        // Ordenamiento por parametros
        public void ordenParametros(int min, int max)
        {
            for(int idx1 = min; idx1 < max; idx1++)
            {
                for(int idx2 = idx1 + 1; idx2 <= max; idx2++)
                {
                    if(vector[idx2] < vector[idx1])
                    {
                        this.intercambio(idx2, idx1);
                    }
                }
            }
        }

        // busqueda de un elemento
        public bool busquedaSecuencial(int number)
        {
            bool respuesta = false;
            int idx = 1;
            while(idx <= this.cantidad && respuesta == false)
            {
                if(vector[idx] == number)
                {
                    respuesta = true;
                }
                idx++;
            }
            return respuesta;
        }

        // frecuencia de une elemento
        public int frecuElem(int number)
        {
            int conta = 0;
            for(int idx = 1; idx <= this.cantidad; idx++)
            {
                if(vector[idx] == number)
                {
                    conta++;
                }
            }
            return conta; 
        }

        // ****************************************************************************************
        // Modelos de examen 
        // *****************

        /* Pregunta 1: Encontrar el elemento y frecuencia (ordenado de < a >)
           de los elementos de fibonaccio del rango a y b
                   a               b
            v [4,7,6,5,4,6,5,1,1,3,8,2] n= 12
            ele { v[1, 5, 8]
            fre { v[2, 2, 1]
        */
        public void elemFrecuFibo(int ragA, int ragB, ref classVector vecEle, ref classVector vecFrecu)
        {
            vecEle.cantidad = 0;
            vecFrecu.cantidad = 0;

            int ele, frecu, idx, varfibo, varA, varB;
            idx = ragA; varfibo = 0; varA = 0;  varB = 1;
            this.ordenParametros(idx, ragB);
            while(idx <= ragB)
            {
                frecu = 0;
                varfibo = varA + varB;
                ele = vector[idx];
                if(ele == varfibo)
                {
                    while((idx <= ragB) &&(vector[idx] == ele))
                    {
                        idx++; frecu++;
                    }
                    vecEle.cargarElexEl(ele);
                    vecFrecu.cargarElexEl(frecu);
                    varA = varB; varB = varfibo;
                }
                else if(ele < varfibo)
                {
                    idx++;
                }
                else if(ele > varfibo)
                {
                    varA = varB; varB = varfibo;
                }
            }
        }

        // Pregunta 2: Cargar randomicamente el vector sin elementos repetidos
        /* nE = 10; a = 10; b = 25
           v [15,12,10,16,13,11,20,14,17,21] = n=10
        */
        public void cargarSinRepetir(int numEle, int min, int max)
        {
            int ele;
            Random rand = new Random();
            while(!(this.cantidad == numEle))
            {
                ele = rand.Next(min, max + 1);
                if (!(busquedaSecuencial(ele)))
                {
                    this.cantidad++;
                    vector[this.cantidad] = ele;
                }
            }
        }

        // Pregunta 3: Eliminar posiciones multiplos de m
        // v[9,8,7,6,3] m = 2 => vR [9,7,3]
        public void elimPosiMultiplos(int number)
        {
            int ele, conta = 0;
            for(int idx = 1; idx <= this.cantidad; idx++)
            {
                ele = idx % number;
                if(ele != 0)
                {
                    conta++;
                    vector[conta] = vector[idx];
                }
            }
            this.cantidad = conta;
        }

        // Pregunta 4: Segmentar el vector en repetidos y no repetidos ordenados
        /* v[4,5,6,1,4,6,1,9,3,8,7,2] => vR [1,1,4,4,6,6,2,3,5,7,8,9]
        */
        public void segmentarRepetNoRepet()
        {
            for(int idx1 = 1; idx1 < this.cantidad; idx1++)
            {
                for(int idx2 = idx1 + 1; idx2 <= this.cantidad; idx2++)
                {
                    if((frecuElem(vector[idx2]) != 1) && (!(frecuElem(vector[idx1]) != 1)) ||
                        (frecuElem(vector[idx2]) !=1 ) && (frecuElem(vector[idx1]) != 1) && (vector[idx2] < vector[idx1]) || 
                        (!(frecuElem(vector[idx2]) != 1)) && (!(frecuElem(vector[idx1]) != 1)) && (vector[idx2] < vector[idx1]))
                    {
                        this.intercambio(idx2, idx1);
                    }
                }
            }
        }
    }
}
