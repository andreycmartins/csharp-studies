Console.Clear();
Console.WriteLine("S = segundo => 10s = 10 segundos");
Console.WriteLine("M = Minuto => 1m = 1 minuto");
Console.WriteLine("0 (zero) = Sair");
Console.WriteLine("Quanto tempo deseja contar?");

string data = Console.ReadLine().ToLower();
string type = data.Substring(data.Length-1, 1);
int time = int.Parse(data.Substring(0, data.Length-1));
int multiplier = 1;

if (type == "m"){
    multiplier = 60;
}

Start(time * multiplier, multiplier);

if(time == 0)
Console.WriteLine("Comando de sair ou desconhecido, saindo da aplicação...");
System.Environment.Exit(0);

static void Start(int time, int multiplier){
    int currentTime = 0;

    while (currentTime != time){
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(50);
    }

    Console.Clear();
    
    if (multiplier == 1){
        Console.WriteLine($"Temporizador de {time} segundos finalizado!");
    } else {
        Console.WriteLine($"Temporizador de {time/60} minuto finalizado!");        
    }
}