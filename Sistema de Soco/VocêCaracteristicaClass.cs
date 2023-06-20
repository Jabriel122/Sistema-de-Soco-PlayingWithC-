using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_de_Soco;

namespace Sistema_de_Soco
{
    public class VocêCaracteristicaClass
    {
        public int vida = 5;

        public int dano;

        public int armadura;

        InimigoCaracteristicaClass icc = new InimigoCaracteristicaClass();
        public void DanoDado(int a, int b, int c)
        {
            int DanoDado = a - b;
            int DanoRecebido = DanoDado - c;
        }
        public void Atacar()
        {
            // Primeiro vamos ver se ele acerta o ataque
            Random rnd = new Random();

            int dice = rnd.Next(1, 21);

            dano = 3;

            if (dice <= 5)
            {
                Console.WriteLine($"You miss! ");
            }
            else if (dice >= 6 && dice <= 18)
            {
                Console.WriteLine($"Acerto!!!");

                DanoDado(dano, icc.armadura, icc.vida);
            }
            else if (dice > 18)
            {
                Console.WriteLine($"Critico!!!");
                int Critico = dano * 2;
                DanoDado(Critico, icc.armadura, icc.vida);
            }
            else
            {
                Console.WriteLine($"Algo deu errado");
                Console.WriteLine($"{dice}");

            }
        }

        public void Defender()
        {
            int Denfendendo = armadura + 3;
        }

        public void Especial()
        {
            Console.WriteLine(@$"
        
                                    _____
                                    [0-0]
                                     /|\
                                     / \

        -----------------------------------------------------------------------
        |                                                                     |
        |  1 - Aumentar o ataque                     4 - Ataque especial      |
        |                       3 - Aumentar a Defesa                         |
        |  2 - Aumentar a Vida                       5 - Chorar               |
        -----------------------------------------------------------------------    
        ");
            ConsoleKeyInfo Especial;
            Especial = Console.ReadKey(true);
            switch (Especial.Key)
            {
                case ConsoleKey.D1:
                    Random rnd = new Random();

                    int dice = rnd.Next(1, 21);
                    Console.WriteLine($"Um dado foi rolado, o valor foi {dice}");



                    if (dice <= 5)
                    {
                        dano++;
                        Console.WriteLine($"Dano aumento em 1, agora você tem {dano} de dano ");
                    }
                    else if (dice >= 6 && dice <= 18)
                    {
                        dano += 3;
                        Console.WriteLine($"Dano aumento em 3, agora você tem {dano} de dano ");
                    }
                    else if (dice > 18)
                    {
                        dano += dano * 2;
                        Console.WriteLine($"Dano dobrado, agora você tem {dano} de dano ");
                    }
                    else
                    {
                        Console.WriteLine($"Algo deu errado");
                    }

                    break;
                case ConsoleKey.D2:
                    Random rnd1 = new Random();

                    int dice1 = rnd1.Next(1, 21);
                    Console.WriteLine($"Um dado foi rolado, o valor foi {dice1}");



                    if (dice1 <= 5)
                    {
                        vida++;
                        Console.WriteLine($"vida aumento em 1, agora você tem {vida} de vida ");
                    }
                    else if (dice1 >= 6 && dice1 <= 18)
                    {
                        vida += 3;
                        Console.WriteLine($"vida aumento em 3, agora você tem {vida} de vida ");
                    }
                    else if (dice1 > 18)
                    {
                        vida += vida * 2;
                        Console.WriteLine($"vida dobrado, agora você tem {vida} de vida ");
                    }
                    else
                    {
                        Console.WriteLine($"Algo deu errado");
                    }

                    break;
                case ConsoleKey.D3:
                    Random rnd2 = new Random();

                    int dice2 = rnd2.Next(1, 21);
                    Console.WriteLine($"Um dado foi rolado, o valor foi {dice2}");



                    if (dice2 <= 5)
                    {
                        armadura++;
                        Console.WriteLine($"armadura aumento em 1, agora você tem {armadura} de armadura ");
                    }
                    else if (dice2 >= 6 && dice2 <= 18)
                    {
                        armadura += 3;
                        Console.WriteLine($"armadura aumento em 3, agora você tem {armadura} de armadura ");
                    }
                    else if (dice2 > 18)
                    {
                        armadura += armadura * 2;
                        Console.WriteLine($"armadura dobrado, agora você tem {armadura} de armadura ");
                    }

                    else
                    {
                        Console.WriteLine($"Algo deu errado");
                    }

                    break;
                case ConsoleKey.D4:
                    Random rnd3 = new Random();
                    int dice3 = rnd3.Next(1, 21);

                    Console.WriteLine($"Um dado foi rolado, o valor foi {dice3}");

                    if (dice3 <= 12)
                    {

                        Console.WriteLine($"Uma Bola de fogo foi jogada, Você errou");
                    }
                    else if (dice3 >= 13 && dice3 <= 19)
                    {
                        int especialDmg = dano + dice3;
                        Console.WriteLine($"Uma Bola de fogo foi jogada, dano total {especialDmg} ");
                    }
                    else if (dice3 > 19)
                    {
                        int especialDmg = (dano + dice3) * 2;
                        Console.WriteLine($"Uma Bola de fogo foi jogada, acertou em cheio, dano total {especialDmg} ");
                    }

                    else
                    {
                        Console.WriteLine($"Algo deu errado");
                    }

                    break;
                case ConsoleKey.D5:
                    Console.WriteLine($"Você lembra da sua mãe");
                    Console.ReadLine();
                    
                    Console.WriteLine($"Alem de sentir falta dela, você percebe que ela provavelmente estária decepcionada ao ver que você está brigando com uma criatura aleatória");
                    Console.ReadLine();
                    
                    Console.WriteLine($"Você chora!");
                    
                    
                    break;
                default:
                    break;
            }

        }

    }
}