using System;

namespace Cadastro_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ListaAluno lista = new ListaAluno();

            string opcao;

            do
            {
                Console.WriteLine("\nO que deseja fazer?");
                Console.WriteLine("1 - Listar Alunos Cadastrados");
                Console.WriteLine("2 - Incluir Aluno");
                Console.WriteLine("0 - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\nLista dos alunos no curso:\n");
                        lista.ListarAlunos();
                        break;

                    case "2":
                        Console.Clear();
                        bool cursoEscolhido = false;
                        string s;
                        Aluno aluno = new Aluno();

                        Console.WriteLine("Insira o nome do aluno:");
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("Insira o código do aluno:");
                        aluno.codigo = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Qual o curso do aluno?");
                            Console.WriteLine("1 - Curso 1");
                            Console.WriteLine("2 - Curso 2");
                            Console.WriteLine("3 - Curso 3");
                            Console.WriteLine("4 - Curso 4");
                            s = Console.ReadLine();
                            switch (s)
                            {
                                case "1":
                                    aluno.curso = "Curso 1";
                                    cursoEscolhido = true;
                                    break;

                                case "2":
                                    aluno.curso = "Curso 2";
                                    cursoEscolhido = true;
                                    break;

                                case "3":
                                    aluno.curso = "Curso 3";
                                    cursoEscolhido = true;
                                    break;

                                case "4":
                                    aluno.curso = "Curso 4";
                                    cursoEscolhido = true;
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;

                            }
                        } while (cursoEscolhido == false);
                        lista.IncluirAluno(aluno);
                        break;

                    case "0":
                        opcao = "0";
                        Console.Clear();
                        break;
                }

            } while (opcao != "0");
        }
    }
}
