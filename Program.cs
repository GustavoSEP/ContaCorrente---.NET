using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 1823;
            contaDaGabriela.numero = 28098;
            contaDaGabriela.saldo = 1680.50;

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);


            contaDaGabriela.saldo += 200;
            Console.WriteLine(contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}