﻿using System.Collections;
using System.Runtime;

bool voltarMenu1;

do
{
    voltarMenu1 = false;
    aluno aluno1 = new aluno();
    int menu1, dadoAluno, dadoCPU;
    Produtos produtos1 = new Produtos();
    double Menu1, dadoprodutos;


    Console.Clear();

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Selecione uma das opções a seguir:");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar alunos");
    Console.WriteLine("2 - Ver treinos");
    Console.WriteLine("3 - ver produtos da academia");
    Console.WriteLine("4 - Serviços");
    Console.WriteLine("5 - Produtinhos do cariani");
    Console.WriteLine();
    Console.Write("Sua escolha [1-5] -> ");

    menu1 = Int32.Parse(Console.ReadLine());



    switch (menu1)

    {
    
    

        case 1:
            Console.Clear();
            Console.WriteLine(" Cadastro do aluno ");
            Console.WriteLine("---------------------");
            Console.Write(" Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" Cadastro concluído, digite qualquer tecla para continuar...");
            Console.ReadLine();
            voltarMenu1 = true;
            break;

        case 2:

            Console.Clear();
            Console.WriteLine(" Aqui estão seus treinos");
            Console.WriteLine("---------------");
            Console.WriteLine(" Segunda-feira -> treino de peito e triceps ");
            Console.WriteLine(" terça-feira -> treino de costas e ombro ");
            Console.WriteLine(" quarta-feira -> treino de biceps ");
            Console.WriteLine(" quinta-feira -> treino de quadriceps e posterior ");
            Console.WriteLine(" sexta-feira -> treino livre ");
            Console.WriteLine(" Voce viu seus treinos, digite qualquer tecla para continuar...");
            Console.ReadLine(); 

            voltarMenu1 = true;
            break;

        case 3:
            Console.Clear();
            Console.WriteLine(" digite o nome do produto  que voce quer coomprar");
            Console.WriteLine("----------------------");
            Console.WriteLine(" creatina Max titanium 300g - R$ 74.99");
            Console.WriteLine(" whey protein 1,5KG - R$ 119.99");
            Console.WriteLine(" hípercalorico Max titanium 3KG - R$ 115");
            Console.WriteLine(" Pré treino DINO 280g - R$ 99.99");
            Console.WriteLine(" Pré treino Prohibido 150g - R$ 64.99");
            Console.WriteLine(" este sao nossos produtos, digite qualquer tecla para continuar...");
            Console.ReadLine();
            voltarMenu1 = true;

            break;

            case 4:
            Console.Clear();
            Console.WriteLine(" planos disponiveis");
            Console.WriteLine("------------------");
            Console.WriteLine(" Plano mensal com personal - 80R$");
            Console.WriteLine(" Plano mensal sem personal - 55R$");
            Console.WriteLine(" Plano anual com personal - 70R$ / 12x");
            Console.WriteLine(" Plano anual sem personal - 60R$ / 12x");
            Console.WriteLine(" esses são nossos serviços, digite qualquer tecla para voltar...");
            Console.ReadLine();
            voltarMenu1 = true;
            break;

            case 5:
            Console.Clear();
            Console.WriteLine(" Selo cariani");
            Console.WriteLine("-----------------");
            Console.WriteLine(" Termogenico do cariani *Crack* 100g - R$ 50");
            Console.WriteLine(" Creatina em *Pó* 300g - R$ 380 ");
            Console.WriteLine(" esses são os produtos, digite qualquer tecla para encerrar...");
            Console.ReadLine();
            break;




        default:

            voltarMenu1 = true;
            break;
    }



} while (voltarMenu1);



