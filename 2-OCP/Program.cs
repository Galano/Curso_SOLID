Console.WriteLine("[START] [" + DateTime.Now + "]");


Produto produto = new Produto(1,"Prod.Teste","Prod.Desc", 10,20, 1,true);

Console.WriteLine("ProdutoId: " + produto.ProdutoId);
Console.WriteLine("Nome: " +  produto.Nome);
Console.WriteLine("Descricao: " + produto.Descricao);
Console.WriteLine("Custo: " + produto.Custo);
Console.WriteLine("Venda: " + produto.Venda);
Console.WriteLine("Estoque: " +  produto.Estoque);
Console.WriteLine("Ativo: " +  produto.Ativo);

// var retorno = ProdutoExtension.MargemLucro(produto);
// Console.WriteLine("MargemLucro: " + retorno.ToString() + "%");



Console.WriteLine("[END] [" + DateTime.Now + "]");
