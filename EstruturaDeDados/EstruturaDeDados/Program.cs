internal class Program
{
    private static void Main(string[] args)
    {
        // Trabalhando com lista (list)
        /*Criando uma lista*/
        List<string> frutas = new List<string>();

        /* Adicionar itens na Lista*/
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");


        /* Imprimindo a lista em uma única linha */
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine(); // Pula linha em Branco

        /* Imprimir elemento na posição específica */
        Console.WriteLine("Fruta ni indice 2: " + frutas[2]);

        Console.WriteLine();
        /* Inserir um elemento no indice específico */
        frutas.Insert(1, "Maracuja");

        /* Imprimir os Itens da lista */
        Console.WriteLine("Minha lista de fritas: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine();
        /* Alterar um elemento no índice específico*/
        frutas[4] = "Pêra";

        /* Imprimir os Itens da lista */
        Console.WriteLine("Minha lista de fritas: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
        Console.WriteLine();
        /* Remover elementos da lista*/
        frutas.RemoveAt(3);
        /* Remover elementos pelo valor do conteúdo */
        frutas.Remove("Morango");

        /* Imprimir os Itens da lista */
        Console.WriteLine("Minha lista de fritas: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* Apagar todos os elementos da lista */
        frutas.Clear();

        Console.WriteLine();
        Console.WriteLine("========================================================");

        // Trabalhando com dicionário
        Dictionary<int, string> carros = new Dictionary<int, string>();
        // Adicionar Dados a um Dicionário 
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        // Imprimir um Dicionario de dados 
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("========================================================");

        // Trabalhando com fila
        // Criar uma fila (queue) 
        Queue<string> filaBanco = new Queue<string>();

        // Adicionar Elementos em uma FILA
        filaBanco.Enqueue("Pedro");
        filaBanco.Enqueue("Thiago");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Mateus");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        filaBanco.Dequeue();

        Console.WriteLine();
        Console.WriteLine("========================================================");
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);

        }

        bool achou = filaBanco.Contains("João");

        if (achou == true)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não está na fila");
        }

        Console.WriteLine();
        Console.WriteLine("========================================================");
        Console.WriteLine();

        // Trabalho com pilha ( stack )
        // Criando uma pilha 
        Stack<string> livros = new Stack<string>();

        // Adicionar elementos em uma pilha 
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de Neve e os Sete Anões");
        livros.Push("Princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine();
        Console.WriteLine("========================================================");
        Console.WriteLine();

        // Remove o primeiro elemento da Pilha 
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine();
        Console.WriteLine("========================================================");
        Console.WriteLine();
    }
}