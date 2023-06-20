// Ideia é fazer um sistema de luta simples, só para aprendizado e diversão.

using Sistema_de_Soco;

ConsoleKeyInfo escolha;
ConsoleKeyInfo opcao;
VocêCaracteristicaClass Vcc = new VocêCaracteristicaClass();

do
{
    Console.WriteLine(@$"   
                             Menu

                        (1) - Jogar
                        (2) - Escolha o seu personagem

                        (0) - Sair
                        ");

    escolha = Console.ReadKey(true);
    switch (
        escolha.Key
    )
    {
        case ConsoleKey.D1:


            do
            {
                Console.WriteLine(@$"
        
                                    _____
                                    [0-0]
                                     /|\
                                     / \

        -----------------------------------------------------------------------
        |                                                                      |
        | |  (1)   |      |   (2)    |      |   (3)    |        |   (0)    |   |
        | | Atacar |      | Defender |      | Especial |        | Desistir |   |
        |                                                                      |
        -----------------------------------------------------------------------    
        ");

                opcao = Console.ReadKey(true);
                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        Vcc.Atacar();
                        break;
                    case ConsoleKey.D2:
                        Vcc.Defender();
                        break;
                    case ConsoleKey.D3:
                        Vcc.Especial();
                        break;
                    case ConsoleKey.D0:
                    Console.WriteLine($"Você é fraco!");
                    
                        break;
                    default:
                        break;
                }

                if(Vcc.vida <= 0)
                {
                    Console.WriteLine($"Você morreu! Otário!");
                    break;
                }
                
            }
            while (opcao.Key != ConsoleKey.D0);


            break;
        case ConsoleKey.D2:
            break;
        case ConsoleKey.D0:
            Console.WriteLine($"Tchau!!");

            break;
        default:
            break;
    }




}
while (escolha.Key != ConsoleKey.D0);
