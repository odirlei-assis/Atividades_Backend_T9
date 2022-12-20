﻿namespace CalculadoraBET9
{
    public static class Calculadora
    {
        public static double Somar(double pNum, double sNum)
        {
            return (pNum + sNum);
        }


        public static string CalcularImc(float peso, float altura)
        {
            double resultado = peso / (altura * altura);

            if (resultado < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (resultado < 24.9)
            {
                return "Peso Normal";
            }
            else if (resultado < 29.9)
            {
                return "Sobre peso";
            }
            else if (resultado < 34.9)
            {
                return "Obesidade Grau 1";
            }
            else if (resultado < 39.9)
            {
                return "Obesidade Grau 2";
            }
            else
            {
                return "Obesidade Grau 3";
            }
        }
    }
}