using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Who_are_Ya_____F1_Edition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pilotododia = "Max Verstappen";
            int idade, titulos, vitorias, poles, podios;
            double altura;
            idade = 25;
            altura = 1.81;
            titulos = 2;
            string equipa = "Red Bull Racing";
            string nacio = "Holanda";
            vitorias = 34;
            poles = 19;
            podios = 76;
            int m = 0;

            string[] dicas = new string[8];

            dicas[0] = "Este piloto tem 2 títulos mundiais.";
            dicas[1] = "Este piloto tem 25 anos.";
            dicas[2] = "Este piloto tem 1,81 de altura.";
            dicas[3] = "Este piloto tem 34 vitórias.";
            dicas[4] = "Este piloto tem 19 pole positions.";
            dicas[5] = "Este piloto tem 76 pódios.";
            dicas[6] = "Este piloto corre na Red Bull Racing RBPT.";
            dicas[7] = "Este piloto é Holandês.";

            Console.Write("Olá seja bem-vindo ao Programa de F1! Por favor, digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\n{0}, selecione uma das opções seguintes\n\n1 - Classificação Campeonato de Pilotos\n\n2 - Classificação Campeonato de Construtores\n\n3 - Who are Ya?", nome);
            Console.Write("\n: ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("\nNOTA: As classificações são alteradas depois do Grand Prix mais recente.");

                        string[] pilotos = new string[20];

                        pilotos[0] = "Max Verstappen";
                        pilotos[1] = "Sergio Perez";
                        pilotos[2] = "Charles Leclerc";
                        pilotos[3] = "George Russell";
                        pilotos[4] = "Lewis Hamilton";
                        pilotos[5] = "Carlos Sainz";
                        pilotos[6] = "Lando Norris";
                        pilotos[7] = "Estaban Ocon";
                        pilotos[8] = "Fernando Alonso";
                        pilotos[9] = "Valtteri Bottas";
                        pilotos[10] = "Sebastian Vettel";
                        pilotos[11] = "Daniel Ricciardo";
                        pilotos[12] = "Kevin Magnussen";
                        pilotos[13] = "Pierre Gasly";
                        pilotos[14] = "Lance Stroll";
                        pilotos[15] = "Mick Schumacher";
                        pilotos[16] = "Yuki Tsunoda";
                        pilotos[17] = "Zhou Guanyu";
                        pilotos[18] = "Alexander Albon";
                        pilotos[19] = "Nicholas Latifi";

                        Console.WriteLine("\n----- CAMPEONATO DE PILOTOS FÓRMULA 1 -----");

                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine("\n\t{0}º Lugar - {1}", i + 1, pilotos[i]);
                            Thread.Sleep(500);
                        }
                        Console.ReadKey();
                        break;
                    }

                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("\nNOTA: As classificações são alteradas depois do Grand Prix mais recente.");

                        string[] equipas = new string[10];

                        equipas[0] = "Red Bull Racing RBPT";
                        equipas[1] = "Ferrari";
                        equipas[2] = "Mercedes";
                        equipas[3] = "Alpine Renault";
                        equipas[4] = "McLaren Mercedes";
                        equipas[5] = "Alfa Romeo Ferrari";
                        equipas[6] = "Aston Martin Mercedes";
                        equipas[7] = "Haas Ferrari";
                        equipas[8] = "Alpha Tauri RBPT";
                        equipas[9] = "Williams Mercedes";


                        Console.WriteLine("\n----- CAMPEONATO DE CONSTRUTORES FÓRMULA 1 -----");

                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("\n\t{0}º Lugar - {1}", i + 1, equipas[i]);
                            Thread.Sleep(500);
                        }
                        Console.ReadKey();
                        break;
                    }

                case 3:
                    {
                        Console.Clear();

                        Console.WriteLine("----- Who are Ya? | F1 Edition -----");
                        Console.Write("\nSeja bem-vindo {0}! Deseja ler as regras ou deseja jogar o jogo? (S/N):", nome);
                        string op2 = Console.ReadLine();

                        if (op2 == "s" || op2 == "S" || op2 == "sim" || op2 == "Sim")
                        {
                            Console.Clear();

                            Console.WriteLine("----- Who are Ya? | F1 Edition --> REGRAS -----");
                            Console.WriteLine("\nEste jogo consiste em adivinhar o piloto 'mistério' e a cada vez que errares, será dada um dica para que possas acertar e ganhar o jogo!");
                            Console.WriteLine("\nNOTA: Os pilotos irão alterar diariamente!!!");

                            for (int s = 5; s > 0; s--)
                            {
                                Console.Clear();
                                Console.WriteLine("Bem, vamos jogar!!! Carregando menu em {0} segundo(s)", s);
                                Thread.Sleep(1000);
                            }

                            while (m == 0)
                            {
                                Console.WriteLine("\nQuem é o piloto? ");
                                string tent = Console.ReadLine();
                                if (tent == "Max Verstappen" || tent == "Verstappen")
                                {

                                    Console.WriteLine("\nParabéns, {0}! Você ACERTOU o piloto! O piloto era {1}.", nome, pilotododia);
                                    m = 1;

                                }
                                else
                                {
                                    int numd = 1;
                                    int n = 0;
                                    Console.WriteLine("\nResposta errada, tenta outra vez!");
                                    Console.WriteLine("\nDica nº{0}: {1}", numd, dicas[n]);
                                    ++n;
                                    ++numd;
                                    m = 0;
                                }



                            }






                        }
                        if (op2 == "n" || op2 == "N" || op2 == "não" || op2 == "Não")
                        {
                            for (int s = 5; s > 0; s--)
                            {
                                Console.Clear();
                                Console.WriteLine("Bem, vamos jogar!!! Carregando menu em {0} segundo(s)", s);
                                Thread.Sleep(1000);
                            }

                            while (m == 0)
                            {
                                Console.WriteLine("\nQuem é o piloto? ");
                                string tent = Console.ReadLine();
                                if (tent == "Max Verstappen" || tent == "Verstappen")
                                {

                                    Console.WriteLine("\nParabéns, {0}! Você ACERTOU o piloto! O piloto era {1}.", nome, pilotododia);
                                    m = 1;

                                }
                                else
                                {
                                    int numd = 1;
                                    int n = 0;
                                    Console.WriteLine("\nResposta errada, tenta outra vez!");
                                    Console.WriteLine("\nDica nº{0}: {1}", numd, dicas[n]);
                                    ++n;
                                    ++numd;
                                    m = 0;
                                }
                            }
                    
                        }
                        break;   
                    }

                default:
                    Console.WriteLine("Você não introduziu uma das opções acima... Reinicie o programa para voltar a selecionar uma opção, e desta vez corretamente."); break;



                    
            }
            Console.ReadKey();
        }
    }
}

