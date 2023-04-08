using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________________________Banco Virtual____________________________________\r\n");

            Console.WriteLine(">> Dados da Conta - Fulano\r\n");

            Cliente fulano = new Cliente();

            fulano.nome = "Fulano";
            fulano.profissao = "Professor de Lógica de Programação";
            fulano.cpf = "123.456.789-10";

            Console.WriteLine("O nome de titular é " + fulano.nome + ".");
            Console.WriteLine("A profissão é " + fulano.profissao + ".");
            Console.WriteLine("O CPF é " + fulano.cpf + ".");


            Console.WriteLine("____________________________________________________________________ \r\n");
            Console.WriteLine(">> Dados da Conta - Fulano a partir de [fulano] e [Cliente]\r\n");

            ContaCorrente conta = new ContaCorrente();

            conta.titular = fulano;
            conta.saldo = 200;
            conta.agencia = 123;
            conta.numConta = 1234567;

            Console.WriteLine("O nome de titular a partir de [fulano] é " + fulano.nome + ".");
            Console.WriteLine("O nome de titular a partir de [Cliente] é " + conta.titular.nome + ".");
            Console.WriteLine("O saldo da conta é de R$ " + conta.saldo + ".");
            Console.WriteLine("O número da agência é " + conta.agencia + ".");
            Console.WriteLine("O número da conta é " + conta.numConta + ".");

            Console.WriteLine("____________________________________________________________________ \r\n");
            Console.WriteLine(">> Dados da Conta - Fulano após alteração \r\n");

            conta.titular.nome = "Fulano Sicrano";
            Console.WriteLine("O nome de titular a partir de [fulano] depois de alterado é " + fulano.nome + ".");
            Console.WriteLine("O nome de titular a partir de [Cliente] depois de alterado é " + conta.titular.nome + ".");

            Console.WriteLine("____________________________________________________________________ \r\n");
            Console.WriteLine(">> Dados da Conta - Beltrano\r\n");

            conta.titular = new Cliente();
            conta.titular.nome = "Beltrano";
            conta.titular.profissao = "Professor de Redes";
            conta.titular.cpf = "123.456.789-11";

            conta.saldo = 300;
            conta.agencia = 123;
            conta.numConta = 1234568;

            Console.WriteLine("O nome de titular é " + conta.titular.nome + ".");
            Console.WriteLine("A profissão é " + conta.titular.profissao + ".");
            Console.WriteLine("O CPF é " + conta.titular.cpf + ".");
            Console.WriteLine("O saldo da conta é de R$ " + conta.saldo + ".");
            Console.WriteLine("O número da agência é " + conta.agencia + ".");
            Console.WriteLine("O número da conta é " + conta.numConta + ".");

            Console.ReadLine();
        }
    }
}
