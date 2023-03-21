// See https://aka.ms/new-console-template for more information
using ConsoleAgent.Implement;


Mode mode = new Mode();
process();

string ReadMode()
{
    Console.WriteLine("    Ingrese funcionalidad    ");
    var modeInput = Console.ReadLine();

    return string.IsNullOrEmpty(modeInput) || (!modeInput.Equals("1") && !modeInput.Equals("2")) ? ReadMode() : modeInput;
}

void process()
{
    Console.Clear();
    Console.WriteLine("                             ");
    Console.WriteLine("       FUNCIONALIDADES       ");
    Console.WriteLine("                             ");
    Console.WriteLine("    1. Obtener media         ");
    Console.WriteLine("    2. Escalera              ");
    Console.WriteLine("                             ");

    mode = new Mode(ReadMode());
    mode.ReadDataInput();
    mode.ReadAgent();
    mode.Execute();
    ReadProccessContinue();
}

void ReadProccessContinue()
{
    Console.WriteLine("                             ");
    Console.WriteLine("    ¿Qué desea hacer?        ");
    Console.WriteLine("    1. Cambiar funcionalidad         ");
    Console.WriteLine("    2. Cambiar agente              ");
    Console.WriteLine("                             ");
    var continueInput = Console.ReadLine();
    if (continueInput == "1")
        process();
    else
    {
        mode.ReadAgent();
        mode.Execute();
        ReadProccessContinue();
    }
}



