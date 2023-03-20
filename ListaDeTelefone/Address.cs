using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTelefone
{
    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Address() 
        {
            
        }

        public void EditStreet(string edit)
        {
            this.Street = edit;
        }

        public void EditCity (string edit)
        {
            this.City = edit;
        }

        public void EditState (string edit)
        {
            this.State = edit;
        }
        public void EditPostalCode(string edit)
        {
            this.PostalCode = edit;
        }
        public void EditCountry (string edit)
        {
            this.Country = edit;
        }
        public override string ToString()
        {
            return $"\nEndereço - \nRua:{Street}\nEstado:{State}\nCidade:{City}\nPaís:{Country}\nPostalCode:{PostalCode}\n----------------------------------------------------------\n";
        }

    }
}
