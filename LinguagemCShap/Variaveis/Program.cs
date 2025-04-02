using System;
using System.Globalization;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo = 'M';
            int idade = 40;
            string primeiroNome = "Emerson";
            var sobreNome = "Oliveira";
            Console.WriteLine($"Nome Completo: {primeiroNome} {sobreNome}");
            Console.WriteLine($"Nome: {primeiroNome}, Sobrenome: {sobreNome}, Idade: {idade}, e sexo {sexo}");
            
            float altura  = 1.98f;
            double medida =  12.75;
            decimal salario = 2800.00M;

            Console.WriteLine($"Salario = R$ {salario.ToString("F2",CultureInfo.InvariantCulture)}, medida em centimetro: {medida.ToString("F2",CultureInfo.InvariantCulture)}, e altura = {altura.ToString("F2",CultureInfo.InvariantCulture)}");

            bool usuarioJaCadastrado = false;
            bool pagamentoRecebido = true;

            Console.WriteLine(usuarioJaCadastrado);
            Console.WriteLine(pagamentoRecebido);

            var nomeDaEmpresa = "Magazine Luiza";

            Console.WriteLine("Nome da empresa: " + nomeDaEmpresa);
        }       
    }
}

