// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var tarefa01 = new Tarefa();
tarefa01.Nome = "Fazer Exercicios";
tarefa01.Descricao = "Leg Press e Esteira";
tarefa01.DataCriacao = DateTime.Now;
tarefa01.Status = 1;
tarefa01.DataExecucao = null;

Console.WriteLine("Dados tarefa 01 preenchidos");

Console.WriteLine("Inserir dados no banco de dados");

var operacoes = new Operacoes();
int idInserido = operacoes.Criar(tarefa01);

Console.WriteLine($"Dados inseridos no banco de dados com sucesso. Id:{idInserido}");
