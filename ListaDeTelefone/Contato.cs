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

        public override string ToString()
        {
            return $"Nome: {Name}\nTelefone:{Telph}\nEmail:{Email}\n {Address.ToString()}";
        }
    }
}
