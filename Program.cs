class Program{
    
    static void Main(){
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("[ 1 ] Contagem em Segundo => 10s = 10 segundos");
        Console.WriteLine("[ 2 ] Contagem em Minuto => 1m = 1 minuto");
        Console.WriteLine("[ 0 ] Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
        char tipo = Convert.ToChar(data.Substring(data.Length -1,1));
        int tempo = Convert.ToInt32(data.Substring(0, data.Length -1));
        int multiplicador = 1;

        if(tipo == 'm')
        {
        multiplicador = 60;
        }
        if(tempo == 0)
        {
            Environment.Exit(0);
        }
        
        PreInicio(tempo * multiplicador);

    }

    static void PreInicio(int tempo)
    {
        Console.Clear();
        Console.WriteLine("Em seus Lugares...");
        Thread.Sleep(1000);
        Console.WriteLine("Preparar...");
        Thread.Sleep(1000);
        Console.WriteLine("Vai...");
        Thread.Sleep(1500);

        Inicio(tempo);
    }
    static void Inicio(int tempo)
    {
        int tempoAtual = 0;

        while (tempoAtual != tempo)
        {
            Console.Clear();
            tempoAtual++;
            Console.WriteLine(tempoAtual);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Cronometro Finalizado...");
        Thread.Sleep(2500);
        Menu();

    }
}