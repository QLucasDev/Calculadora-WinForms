using System;


namespace Calculadora
{
    public class Operacoes
    {
        public string operacao;
        public decimal valor1 { get; set; }
        public decimal valor2 { get; set; }


        public Operacoes()
        {
        }

        public Operacoes(string operacao, decimal valor1, decimal valor2)
        {
            this.operacao = operacao;
            this.valor1 = valor1;
            this.valor2 = valor2;
        }


        public decimal result()
        {
            decimal resultado = 0;

            if (operacao == "SOMA")
            {
                resultado = valor1 + valor2;
            }
            else if (operacao == "SUB")
            {
                resultado = valor1 - valor2;
            }
            else if (operacao == "MULT")
            {
                resultado = valor1 * valor2;
            }
            else if (operacao == "DIV")
            {
                resultado = valor1 / valor2;
            }
            return resultado;
        }
    }
}
