using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using ListaDeTelefone;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Contato> phonebook = new List<Contato>();
        int op = 0;

        do {
            Console.Clear();
            op = menu();
            switch (op)
            {
                case 1:
                    phonebook.Add(CreateContact());
                    break;
                case 2:
                    phonebook = new List<Contato>();
                    break;
                case 3:
                    phonebook.Remove(DeleteContact());
                    break;
                case 4:
                    PrintPhoneBook(phonebook);
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcao Inválida.");
                    break;
            }
        } while (op != 5);

        void PrintPhoneBook(List<Contato> l)
        {
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.Write("PressEnter continue...");
            Console.ReadKey();
        }

        int menu()
        {
            Console.Write("Menu de opcções\n1- Inserer Contato\n2- Editar contato\n3- Remover contato\n4- Mostrar contatos: \n5- Sair\nEscolha sua poção: ");
            return int.Parse(Console.ReadLine());
        }

        Contato DeleteContact()
        {
            Console.Write("Informe o nome: ");
            string n = Console.ReadLine();
            foreach (var item in phonebook)
            {
                if (item.Name.Equals(n))
                {
                    return item;
                }
            }
            return null;
        }

        Contato CreateContact()
        {
            Console.Write("Informe o nome: ");
            string n = Console.ReadLine();
            Console.Write("Informe o telefone: ");
            string t = Console.ReadLine();
            Contato contact = new(n, t);
            return contact;
        }

    }



    /*Contato contact = new Contato("Pestana", "11116985");
    contact.Address.EditStreet("Dirceu Abreu, 219");
    contact.Address.EditPostalCode("15400-355");
    contact.Address.EditState("São Paulo");
    contact.Address.EditCity("Matão");
    contact.Address.EditCountry("Brasil");

    Contato contact1 = new Contato("Pabline", "2659855445");
    contact1.Address.EditStreet("Alice no pais das maravilhas, 965");
    contact1.Address.EditPostalCode("14695-652");
    contact1.Address.EditState("São Paulo");
    contact1.Address.EditCity("Barretos");
    contact1.Address.EditCountry("Brasil");

    phonebook.Add(contact);
    phonebook.Add(contact1);
    PrintPhoneBook(phonebook);

    Console.ReadKey();
    Console.Clear();
    phonebook.Remove(contact);

    PrintPhoneBook(phonebook);*/


}