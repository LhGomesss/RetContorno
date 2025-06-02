Console.WriteLine("Retângulo");
Console.Write("Digite a largura desejada: ");
int largura = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a altura desejada: ");
int altura = Convert.ToInt32(Console.ReadLine());
// declare as variáveis, e peça as medidas do retângulo

if (largura<1 || largura>10 || altura<1 || altura>10)
// se tiver largura entre 1 e 10 está certo
{
    Console.WriteLine("Largura e Altura tem que estar entre 1 e 10.");
// se não tiver entre 1 e 10, mostra essa mensagem 
}
else
{
    int linhainicial = 1;
    while (linhainicial <= altura)
    {
    Console.WriteLine();
    int alturainicial = 1;
    while (alturainicial <= largura)
        {if (linhainicial == 1 || linhainicial == altura)
        {
        Console.Write("*");
        // se for a primeira ou a última linha, ela é preenchida toda com *
        }
        else
        {   if (alturainicial == 1 || alturainicial == largura)
            {
            Console.Write("*");
            }
            else
            {
            Console.Write(" ");
            }
        }
        alturainicial += 1;
        }
        linhainicial += 1;
    }
}
