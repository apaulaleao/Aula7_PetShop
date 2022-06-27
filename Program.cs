using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_PetShop
{

    internal class PetShop
    {
        private string nomePet;
        private string especie;
        private string cor;
        private int idade;
        private string observacao;

        
        public PetShop(string nomePet, string especie, string cor, int idade, string observacao) : this(nomePet)
        {
            this.nomePet = nomePet;
            this.especie = especie;
            this.cor = cor;
            this.idade = idade;
            this.observacao = observacao;
        }

        static void Main(string[] args)
        {

            Console.Write("Nome do pet:");
            string nomePet = Console.ReadLine();

            Console.Write("Qual a espécie do Pet:");
            string especie = Console.ReadLine();

            Console.Write("Qual a cor do pet:");
            string cor = Console.ReadLine();

            Console.Write("Qual a idade do pet:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Campo de Observação:");
            string observacao = Console.ReadLine();

            PetShop petShop1 = new PetShop(nomePet, especie, cor, idade, observacao);
            Console.WriteLine();
            Console.WriteLine(petShop1);



        }
    }
}
