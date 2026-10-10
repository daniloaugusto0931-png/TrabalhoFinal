
using System;

namespace TrabalhoFinal.Views
{
    public class MenuView
    {
        public static void IniciarSistema()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("   SISTEMA DE HAMBÚRGUERES");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Pessoa");
                Console.WriteLine("2 - Ingredientes");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Digite um número válido!");
                    Pausar();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        PessoaMenu();
                        break;

                    case 2:
                        IngredientesMenu();
                        break;

                    case 0:
                        continuar = false;
                        Console.WriteLine("Sistema encerrado!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        public static void PessoaMenu()
        {
            bool voltar = false;

            while (!voltar)
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("         MENU PESSOA");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Listar pessoas");
                Console.WriteLine("2 - Excluir pessoa");
                Console.WriteLine("3 - Editar pessoa");
                Console.WriteLine("4 - Adicionar pessoa");
                Console.WriteLine("0 - Voltar ao menu principal");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Digite um número válido!");
                    Pausar();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        // Troque pelo método existente no seu projeto.
                        Console.WriteLine(
                            "Implemente aqui a listagem de pessoas.");
                        Pausar();
                        break;

                    case 2:
                        Console.WriteLine(
                            "Método de excluir pessoa ainda não implementado.");
                        Pausar();
                        break;

                    case 3:
                        Console.WriteLine(
                            "Método de editar pessoa ainda não implementado.");
                        Pausar();
                        break;

                    case 4:
                        Console.WriteLine(
                            "Implemente aqui o cadastro de pessoas.");
                        Pausar();
                        break;

                    case 0:
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        public static void IngredientesMenu()
        {
            bool voltar = false;

            while (!voltar)
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("      MENU INGREDIENTES");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Listar ingredientes");
                Console.WriteLine("2 - Excluir ingrediente");
                Console.WriteLine("3 - Editar ingrediente");
                Console.WriteLine("4 - Adicionar ingrediente");
                Console.WriteLine("0 - Voltar ao menu principal");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Digite um número válido!");
                    Pausar();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        IngredientesView.Listar();
                        Pausar();
                        break;

                    case 2:
                        Console.WriteLine(
                            "Método de excluir ingrediente ainda não implementado.");
                        Pausar();
                        break;

                    case 3:
                        Console.WriteLine(
                            "Método de editar ingrediente ainda não implementado.");
                        Pausar();
                        break;

                    case 4:
                        IngredientesView.Adicionar();
                        Pausar();
                        break;

                    case 0:
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        private static void Pausar()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
