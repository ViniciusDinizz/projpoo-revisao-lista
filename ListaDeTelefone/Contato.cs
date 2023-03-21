using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTelefone
{
    internal class Contato
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Telph { get; set; }
        public string? Email { get; set; }
        public Contato Next { get; set; }

        public Contato(string nome,  string numero)
        {
            Name = nome;
            Telph = numero;
            this.Address = new Address();
        }

        public void EditPhone(string edit)
        {
            this.Telph = edit;
        }

        public void EditEmail(string edit)
        {
            this.Email = edit;
        }

        public void EditName(string edit)
        {
            this.Name = edit;
        }

        public void EditContact(int edit)
        {
            switch (edit)
            {
                case 1:
                    Console.Write("Digite o novo nome: ");
                    string nome = Console.ReadLine();
                    this.EditName(nome);
                    break;
                case 2:
                    Console.Write("Digite o novo telefone: ");
                    string telph = Console.ReadLine();
                    this.EditPhone(telph);
                    break;
                case 3:
                    Console.Write("Digite o novo email: ");
                    string email = Console.ReadLine();
                    this.EditEmail(email);
                    break;
                case 4:
                    Console.Write("Digite a nova rua: ");
                    string rua = Console.ReadLine();
                    this.Address.EditStreet(rua);
                    break;
                case 5:
                    Console.Write("Digite a nova cidade: ");
                    string city = Console.ReadLine();
                    this.Address.EditCity(city);
                    break;
                case 6:
                    Console.Write("Digite o novo estado: ");
                    string state = Console.ReadLine();
                    this.Address.EditState(state);
                    break;
                case 7:
                    Console.Write("Digite o novo nome: ");
                    string PostCod = Console.ReadLine();
                    this.Address.EditPostalCode(PostCod);
                    break;
                case 8:
                    Console.Write("Digite o novo País: ");
                    string pais = Console.ReadLine();
                    this.Address.EditCountry(pais);
                    break;
                default:
                    Console.WriteLine("Opcao errada.");
                    break;

            }


        }

        public override string ToString()
        {
            return $"Nome: {Name}\nTelefone:{Telph}\nEmail:{Email}\n {Address.ToString()}";
        }
    }
}
