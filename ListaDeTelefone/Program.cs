using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using ListaDeTelefone;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Contato> phonebook = new List<Contato>();
        int op = 0;

        do
        {
            Console.Clear();
            op = menu();
            switch (op)
            {
                case 1:
                    phonebook.Add(CreateContact());
                    List<Contato> phonebookorde = phonebook.OrderBy(Contato => Contato.Name).ToList();
                    phonebook = phonebookorde;
                    break;
                case 2:
                    int contato = ProcurarContato();
                    while(contato == -1)
                    {
                        contato = ProcurarContato();
                    }
                    int campEdit = Verificacao();
                    phonebook[contato].EditContact(campEdit);
                    phonebookorde = phonebook.OrderBy(Contato => Contato.Name).ToList();
                    phonebook = phonebookorde;
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
            bool option;
            int op = 0;
            do
            {
                Console.Write("Menu de opcções\n1- Inserir Contato\n2- Editar contato\n3- Remover contato\n4- Mostrar contatos: \n5- Sair\nEscolha sua poção: ");
                try
                {
                    op = int.Parse(Console.ReadLine());
                    option = false;
                }
                catch (Exception ex)
                {
                    Console.Write("Digite um número inteiro entre 1 e 5...");
                    Console.ReadKey();
                    option == true;
                }
            } while (option == true);
            return op;
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

        int ProcurarContato()
        {
            Console.Write("Digite o nome do contato: ");
            string cont = Console.ReadLine();
            for(int i = 0; i < phonebook.Count; i++)
            {
                if (phonebook[i].Name.ToUpper() == cont.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }

        int Verificacao()
        {
            int value = 0;
            bool correct;
            do
            {
                try
                {
                    Console.Clear();
                    Console.Write("Escolha o campo a ser editado:\n1- Nome\n2- Telefone\n3- Email\n4- Street\n5- City\n6- State\n" +
                "7- Postal Code\n8- Country\n0- SAIR\nOption: ");
                    value = int.Parse(Console.ReadLine());
                    correct = false;
                }
                catch (Exception val)
                {
                    Console.Write("Valor não aceito. Tente novamente...");
                    Console.ReadKey();
                    correct = true;
                }
            } while (correct == true);
            Console.Clear();
            return value;
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