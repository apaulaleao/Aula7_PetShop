using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*cadastro de animais de uma pet-shop;. 
 * Crie uma classe que modele os animais e contenha:
 * atributos nome, espécie, cor, idade, observação e dados do dono. 
 * Os atributos relacionados ao dono do animal deve ser (privados) para proteção de dados. 
 * Forneça métodos para cadastro e leitura das informações.*/

namespace PetShop
{
    internal class Petshop
    {
        public string nomePet { get; set; }
        public string especie { get; set; }
        public string cor {get;set;}
        public int idade { get; set; }
        public string observacao { get; set; }

        private string nomeDono { get; set; }
        private string addressDono { get; set; }
        private double whatsapp_dono { get; set; }

        public Petshop(string nomePet, string especie, string cor, int idade, string observacao, string nomeDono, string addressDono, double whatsapp_dono)
        {
            this.nomePet = nomePet;
            this.especie = especie;
            this.cor = cor;
            this.idade = idade;
            this.observacao = observacao;
            this.nomeDono = nomeDono;
            this.addressDono = addressDono;
            this.whatsapp_dono = whatsapp_dono;
        }
        public override string ToString()
        {
            return ($"O animal é um {nomePet}/n, do tipo{especie},/n, de cor{cor}");
        }
    }
}
