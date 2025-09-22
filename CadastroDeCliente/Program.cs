namespace CadastroDeCliente
{
    internal class Program
    {

        static List<Cliente> clientes = new List<Cliente>();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao gerenciador de clientes!");
            Console.WriteLine("-------------------------------------");

            bool aux = true;
            int opc;

            while (aux)
            {
                Menu();
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        aux = false;
                        Console.WriteLine("Até a próxima! ;)");
                        break;
                    case 1:
                        Adicionar();
                        break;
                    case 2:
                        Listar();
                        break;
                    case 3:
                        Remover();
                        break;
                    case 4:
                        Editar();
                        break;
                    default:
                        Console.WriteLine("Digite um número válido");
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Adicionar cliente");
            Console.WriteLine("2 - Listar cliente");
            Console.WriteLine("3 - Remover cliente");
            Console.WriteLine("4 - Editar cliente");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
        }

        static void Adicionar()
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o email do cliente: ");
            string email = Console.ReadLine();
            Cliente cliente = new Cliente(nome, email);

            clientes.Add(cliente);
        }

        static void Listar()
        {
            foreach(Cliente cliente in clientes)
            {
                Console.WriteLine("Nome: " + cliente.nome);
                Console.WriteLine("Email: " + cliente.email);
                Console.WriteLine("------------------------");
            }
        }

        static void Remover()
        {
            Console.Write("Digite o email do cliente que deseja remover: ");
            string email = Console.ReadLine();

            Cliente cliente = clientes.Find(c => c.email == email);

            if(cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente removido com sucesso! :)");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado :(");
            }
        }

        static void Editar()
        {
            Console.Write("Digite o email do cliente que deseja editar: ");
            string email = Console.ReadLine();

            Cliente cliente = clientes.Find(c => c.email == email);

            if(cliente != null)
            {
                Console.Write("Digite o novo nome do cliente: ");
                string novoNome = Console.ReadLine();
                Console.Write("Digite o novo email do cliente: ");
                string novoEmail = Console.ReadLine();

                cliente.nome = novoNome;
                cliente.email = novoEmail;

                Console.WriteLine("Cliente alterado com sucesso! :)");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado :(");
            }

        }
    }
}
