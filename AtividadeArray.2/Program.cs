Console.WriteLine("---Controle de Estoque Crítico---");
Console.Write("Quantos produtos deseja cadastrar? ");

int quantidadeItens = Convert.ToInt32(Console.ReadLine());
int[] itens = new int[quantidadeItens];
for (var contador = 0; contador < quantidadeItens; contador++)
{
    Console.Write($"Digite a quantidade em estoque do produto {contador + 1}: ");
    itens[contador] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("---Alerta: Produtos com Estoque Crítico---");
for (var contador = 0; contador < quantidadeItens; contador++)
{
    
    if (itens[contador] < 5)
    {
        Console.WriteLine($"Produto {contador + 1} está com estoque baixo: apenas {itens[contador]} unidades.");
    }
    
}
