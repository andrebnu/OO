using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] pilotos = new string[4] { "Ayrton Senna", "Michael Schumacher",
                 "Lewis Hamilton", "Alain Prost" };
             Console.WriteLine(pilotos[3]);
             Console.WriteLine();
             pilotos[3] = "Rubens Barrichello";
             foreach (string piloto in pilotos)
                {
                     Console.WriteLine(piloto);
                }*/

            /* int[] vetor = new int[2];
             Console.WriteLine("Insira 2 números que te informo qual o maior");
             vetor[0] = Convert.ToInt32(Console.ReadLine());
             vetor[1] = Convert.ToInt32(Console.ReadLine());

             if (vetor[0] > vetor[1])
             {
                 Console.WriteLine(vetor[0]);
             }
             else
             {
                 Console.WriteLine(vetor[1]);
             }*/
            //Crie um vetor que armazena 2 valores vindo do usuario, depois, diga pro usuario qual o maior

            /* Console.WriteLine("Digite dois valores, retornarei o maior!");
             int[] vetor = new int[2];
             vetor [0]= Convert.ToInt32(Console.ReadLine());
             vetor[1] = Convert.ToInt32(Console.ReadLine());


             if (vetor[0] > vetor[1])
             {
                 Console.WriteLine("o numero maior é "+ vetor[0]);

             }
             else
             {
                 Console.WriteLine("o numero maior é " + vetor[1]);
             }*/
            //2) Crie um vetor que armarmazene 3 notas vindo do usuario, depois, de a média das três notas

            /* double[] notas = new double[3];
             Console.WriteLine("Digite 3 valores e lhe darei a média deles!");
             notas[0] = Convert.ToDouble(Console.ReadLine());
             notas[1] = Convert.ToDouble(Console.ReadLine());
             notas[2] = Convert.ToDouble(Console.ReadLine());         
             Console.WriteLine("A média dos valores é!..." + (notas[0] + notas[1] + notas[2]) / 3);*/

            // 3) Crie um vetor que armazena 3 valores vindo do usuario, depois, mostre apenas o maior
            //dentre eles, se todos forem iguais, exiba uma mensagem dizendo “sao todos iguais”

            /*double[] valor = new double[3];
            Console.WriteLine("Digite 3 valores e lhe Retornarei o maior deles!");
            valor[0] = Convert.ToDouble(Console.ReadLine());
            valor[1] = Convert.ToDouble(Console.ReadLine());
            valor[2] = Convert.ToDouble(Console.ReadLine());

            if (valor[0] == valor[1] || valor[0] == valor[2])
            {
                Console.WriteLine("Os numeros são todos iguais!");
            }
            
            else if (valor[0] > valor[1] && valor[0] > valor[2])
            {
                Console.WriteLine("O maior valor digitado foi...!" + valor[0]);
            }
            else if (valor[1] > valor[0] && valor[1] > valor[2])
            {
                Console.WriteLine("O maior valor digitado foi...!" + valor[1]);
            }
            else
            {
                Console.WriteLine("O maior valor digitado foi...!" + valor[2]);
            }*/

            //4) Crie um vetor que armazena 3 nomes vindo do usuario, o usuario pode, a qualquer
            //momento, solicitar quais nomes estao armazenados.

            /* string[] nome = new string[4];
             Console.WriteLine("Digite 3 nomes");
             Console.WriteLine("Aperte S para ver os nomes digitados");
             for (int i= 0; i < nome.Length -1; i++)
             {
                 nome [i] = Console.ReadLine();
                 if (nome[i] == "S" || nome[i] == "s")
                 {
                     nome[i] = nome[i + 1];
                     break;
                 }
             }
             Console.WriteLine("Lista de nomes cadastrados!");
             Console.WriteLine(nome[0]);
             Console.WriteLine(nome[1]);
             Console.WriteLine(nome[2]);*/








            // 5) Crie um vetor que armazena 5 valor INTEIROS, peça ao usuario para ele colocar
            //valores nessas 5 posições, depois, some todos os valor e mostre pro usuario

            /*int[] valor = new int[5];
            Console.WriteLine("Calcule a soma de 5 valores!");
            valor[0] = Convert.ToInt32(Console.ReadLine());
            valor[1] = Convert.ToInt32(Console.ReadLine());
            valor[2] = Convert.ToInt32(Console.ReadLine());
            valor[3] = Convert.ToInt32(Console.ReadLine());
            valor[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma dos 5 Valores é!");
            Console.WriteLine("Total = "+valor[0] + valor[1] + valor[2] + valor[3] + valor[4]);*/


            // EX06

            /* string [] nome = new string[4]; 
             string []  cpf = new string [4];
             int  [] idade = new int[4];
            while (true)
            {
                Console.WriteLine("Cadastro de alunos");
                Console.WriteLine("Qual posição deseja cadastrar os alunos?");
                Console.WriteLine("  1  -  2  -  3  -  4  ");
                switch (Console.ReadLine())
                {
                    case"1":
                        Console.WriteLine("Digite o Nome do aluno(1)!");
                        nome[0] = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do aluno!");
                        cpf[0] = Console.ReadLine();
                        Console.WriteLine("Digite a idade do aluno!");
                        idade[0] = Convert.ToInt32(Console.ReadLine());
                        break;

                    case "2":
                        Console.WriteLine("Digite o Nome do aluno(2)!");
                        nome[1] = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do aluno!");
                        cpf[1] = Console.ReadLine();
                        Console.WriteLine("Digite a idade do aluno!");
                        idade[1] = Convert.ToInt32(Console.ReadLine());
                        break;

                    case "3":
                        Console.WriteLine("Digite o Nome do aluno(3)!");
                        nome[2] = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do aluno!");
                        cpf[2] = Console.ReadLine();
                        Console.WriteLine("Digite a idade do aluno!");
                        idade[2] = Convert.ToInt32(Console.ReadLine());
                        break;

                    case "4":
                        Console.WriteLine("Digite o Nome do aluno(4)!");
                        nome[3] = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do aluno!");
                        cpf[3] = Console.ReadLine();
                        Console.WriteLine("Digite a idade do aluno!");
                        idade[3] = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.WriteLine("============================================================================");
                Console.WriteLine("Deseja cadastrar outro aluno? S/N");
                string cadastro = Console.ReadLine().ToLower();

                if(cadastro == "n")
                {
                    if(nome[0] != null)
                    {
                    Console.WriteLine("O nome cadastrado na posição 1 é...");
                    Console.WriteLine("Nome" + nome[0]);
                    Console.WriteLine("Cpf" + cpf[0]);
                    Console.WriteLine("Idade" + idade[0]);
                    Console.WriteLine("**--------------------------------**");

                    }

                    if (nome[1] != null)
                    {
                    Console.WriteLine("O nome cadastrado na posição 2 é...");
                    Console.WriteLine("Nome" + nome[1]);
                    Console.WriteLine("Cpf" + cpf[1]);
                    Console.WriteLine("Idade" + idade[1]);
                    Console.WriteLine("**--------------------------------**");
                    }

                    if (nome[2] != null)
                    {
                        Console.WriteLine("O nome cadastrado na posição 3 é...");
                        Console.WriteLine("Nome" + nome[2]);
                        Console.WriteLine("Cpf" + cpf[2]);
                        Console.WriteLine("Idade" + idade[2]);
                        Console.WriteLine("**--------------------------------**");
                    }

                    if (nome[3] != null)
                    {
                        Console.WriteLine("O nome cadastrado na posição 4 é...");
                        Console.WriteLine("Nome" + nome[3]);
                        Console.WriteLine("Cpf" + cpf[3]);
                        Console.WriteLine("Idade" + idade[3]);
                        Console.WriteLine("**--------------------------------**");
                    }

                break;
                }

            }*/


            //Desafio
            //a) Cadastrar pessoa na agenda de aniversariantes(nome, dia e mês de niver)
            //b) Excluir pessoa a partir do nome
            //c) Alterar dia ou mês a partir do nome
            //d) Consultar aniversariante de uma data(dia e Mês)
            //e) Consultar todos os aniversariantes pela letra inicial do nome, ordenados(por data)
            //f) Mostrar toda a agenda ordenada pelo nome, ordenados(por data)
            //g)Mosrar toda a agenda ordenada por mês
            //h) Sair


            /* string [] nome = new string[15];
             string[] data = new string[15];

             while (true)
             {


                 Console.WriteLine("Agenda de aniversário!!");
                 Console.WriteLine("Digite o local da agenda para salvar o contato!");
                 Console.WriteLine("De 1 á 15");
                 switch (Console.ReadLine())
                 {
                     case "1":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[0] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[0] = Console.ReadLine();
                         break;

                     case "2":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[1] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[1] = Console.ReadLine();
                         break;
                     case "3":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[2] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[2] = Console.ReadLine();
                         break;
                     case "4":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[3] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[3] = Console.ReadLine();
                         break;
                     case "5":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[4] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[4] = Console.ReadLine();
                         break;
                     case "6":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[5] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[5] = Console.ReadLine();
                         break;
                     case "7":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[6] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[6] = Console.ReadLine();
                         break;
                     case "8":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[7] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[7] = Console.ReadLine();
                         break;
                     case "9":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[8] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[8] = Console.ReadLine();
                         break;
                     case "10":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[9] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[9] = Console.ReadLine();
                         break;
                     case "11":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[10] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[10] = Console.ReadLine();
                         break;
                     case "12":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[11] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[11] = Console.ReadLine();
                         break;
                     case "13":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[12] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[12] = Console.ReadLine();
                         break;
                     case "14":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[13] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[13] = Console.ReadLine();
                         break;
                     case "15":
                         Console.WriteLine("Digite o nome do aniversáriante!");
                         nome[14] = Console.ReadLine();
                         Console.WriteLine("Digite a data de aniversário!");
                         data[14] = Console.ReadLine();
                         break;
                 }

                 Console.WriteLine("Deseja cadastrar outro Aniversariante? S/N");
                 string cadastro = Console.ReadLine().ToLower();
                 if (cadastro == "n")
                 {
                     if (nome[0] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 1 é...");
                         Console.WriteLine("Nome  " + nome[0]);
                         Console.WriteLine("Data  " + data[0]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[1] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 2 é...");
                         Console.WriteLine("Nome  " + nome[1]);
                         Console.WriteLine("Data  " + data[1]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[2] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 3 é...");
                         Console.WriteLine("Nome  " + nome[2]);
                         Console.WriteLine("Data  " + data[2]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[3] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 4 é...");
                         Console.WriteLine("Nome  " + nome[3]);
                         Console.WriteLine("Data  " + data[3]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[4] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 5 é...");
                         Console.WriteLine("Nome  " + nome[4]);
                         Console.WriteLine("Data  " + data[4]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[5] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 6 é...");
                         Console.WriteLine("Nome  " + nome[5]);
                         Console.WriteLine("Data  " + data[5]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[6] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 7 é...");
                         Console.WriteLine("Nome  " + nome[6]);
                         Console.WriteLine("Data  " + data[6]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[7] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 8 é...");
                         Console.WriteLine("Nome  " + nome[7]);
                         Console.WriteLine("Data  " + data[7]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[8] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 9 é...");
                         Console.WriteLine("Nome  " + nome[8]);
                         Console.WriteLine("Data  " + data[8]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[9] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 10 é...");
                         Console.WriteLine("Nome  " + nome[9]);
                         Console.WriteLine("Data  " + data[9]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[10] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 11 é...");
                         Console.WriteLine("Nome  " + nome[10]);
                         Console.WriteLine("Data  " + data[10]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[11] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 12 é...");
                         Console.WriteLine("Nome  " + nome[11]);
                         Console.WriteLine("Data  " + data[11]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[12] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 13 é...");
                         Console.WriteLine("Nome  " + nome[12]);
                         Console.WriteLine("Data  " + data[12]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[13] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 14 é...");
                         Console.WriteLine("Nome  " + nome[13]);
                         Console.WriteLine("Data  " + data[13]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     if (nome[14] != null)
                     {
                         Console.WriteLine("O nome cadastrado na posição 15 é...");
                         Console.WriteLine("Nome  " + nome[14]);
                         Console.WriteLine("Data  " + data[14]);
                         Console.WriteLine("**--------------------------------**");

                     }
                     Console.WriteLine("Deseja excluir um aniversariante?  S/N" );
                     string excluir = Console.ReadLine().ToLower();
                     if (excluir == "s")
                         Console.WriteLine("Qual aniversariante deseja excluir?");

                     {
                         if (nome[0]  != null)
                         {
                            // Console.Clear();
                           //  break;
                         }
                     }


                    break;
                 }
             }*/


            /* string[] nomes = new string[4];
             string[] cpf = new string[4];
             int[] idade = new int[4];
             while (true)
             {
                 for (int i = 0; i < nomes.Length; i++)
                 {
                     Console.WriteLine("-----------//----------");
                     Console.WriteLine("Aluno : " + (i + 1));
                     Console.WriteLine("Nome  : " + nomes[i]);
                     Console.WriteLine("CPF   : " + cpf[i]);
                     Console.WriteLine("Idade : " + idade[i]);
                 }
                 Console.WriteLine("Qual aluno deseja preencher");
                 int escolha = Convert.ToInt32(Console.ReadLine())/*-1;
                 escolha--;
                 Console.WriteLine("Insira o nome");
                 nomes[escolha - 1] = Console.ReadLine();
                 Console.WriteLine("Insira o cpf");
                 cpf[escolha - 1] = Console.ReadLine();
                 Console.WriteLine("Insira o idade");
                 idade[escolha - 1] = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Deseja sair?\n1 - sim | 2 - não");
                 escolha = Convert.ToInt32(Console.ReadLine());
                 if (escolha == 1)
                 {
                     break;
                 }
             }*/



            //  matriz


            //exec01
            int[][] matriz = new int[4][]; // gera uma matriz com 4 linhas
            for (int i = 0; i < matriz.Length; i++) // percorre todas as linhas
            {
                matriz[i] = new int[4]; // gera minhas colunas
            }
            for (int i = 0; i < matriz.Length; i++) // percorre todas as linhas
            {
                for (int j = 0; j < matriz[i].Length; j++) // percorre todas as colunas da linha i
                {
                    Console.WriteLine("insira o elemento -> " + i + " " + j);
                    matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int contador = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (matriz[i][j] > 10)
                    {
                        contador++;
                    }
                    Console.Write(matriz[i][j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" Foram apresentados "+contador+"numeros maiores que 10");

        }
    }

    
    
}
