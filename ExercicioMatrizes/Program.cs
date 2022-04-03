// See https://aka.ms/new-console-template for more information

/*
O programa deve ler 2 valores inteiros. Estes números serão as linhas e colunas de uma matriz.
Em seguida o programa deve solicitar o preenchimento da matriz.
Por fim deve ser solicitado um número X para busca na matriz. Quando X for encontrado, o programa deve retornar
a sua posição e os números acima, à direita, abaixo e à esquerda dele quando houver.
*/

Console.Write("Entre com o numero de linhas e colunas da matriz: ");
string[] line = Console.ReadLine().Split(' ');
int m = int.Parse(line[0]);
int n = int.Parse(line[1]);

int[,] mat = new int[m, n];

for (int i = 0; i < m; i++)
{
    int cont = i + 1;
    Console.Write("Digite os " + n + " números da linha " + cont  + ": " );
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

Console.Write("Digite o valor a ser procurado na matriz: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] == x)
        {
            Console.WriteLine("Valor " + x + " encontrado na posição " + i + "," + j + ":");
            if (j > 0)
            {
                Console.WriteLine("Valor à esquerda: " + mat[i, j - 1]);
            }
            if (i > 0)
            {
                Console.WriteLine("Valor acima: " + mat[i - 1, j]);
            }
            if (j < n - 1)
            {
                Console.WriteLine("Valor à direita: " + mat[i, j + 1]);
            }
            if (i < m - 1)
            {
                Console.WriteLine("Valor abaixo: " + mat[i + 1, j]);
            }
        }
    }
}