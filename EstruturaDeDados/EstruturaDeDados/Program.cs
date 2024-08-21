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

        /* Inserir um elemento no indice específico */
        frutas.Insert(1, "Maracuja");

        /* Imprimir os Itens da lista */
        Console.WriteLine("Minha lista de fritas: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* Alterar um elemento no índice específico*/
        frutas[4] = "Pêra";

        /* Imprimir os Itens da lista */
        Console.WriteLine("Minha lista de fritas: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

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


    }
}