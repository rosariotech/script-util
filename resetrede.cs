using System;

class ResetRede
{
    static void Main(string[] args)
    {
        // string comando1 = "/c ipconfig /renew";
        // string comando2 = "/c ipconfig /flushdns";
        // string comando3 = "/c ipconfig /registerdns ";
        // string comando4 = "/c nbtstat -rr";
        // string comando5 = "/c netsh winsock reset";
        // string comando6 = "/c netsh int ip reset all";
        // System.Diagnostics.Process.Start("cmd.exe",comando1);
        // System.Diagnostics.Process.Start("cmd.exe",comando2);
        // System.Diagnostics.Process.Start("cmd.exe",comando3);
        // System.Diagnostics.Process.Start("cmd.exe",comando4);
        // System.Diagnostics.Process.Start("cmd.exe",comando5);
        // System.Diagnostics.Process.Start("cmd.exe",comando6);

        System.Diagnostics.Process process = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        startInfo.FileName = "cmd.exe";
        startInfo.Arguments = "/c ipconfig /renew";
        process.StartInfo = startInfo;
        process.Start();
        Console.WriteLine("Concluído Renew");
        startInfo.Arguments = "/c ipconfig /flushdns";
        process.Start();
        Console.WriteLine("Concluído flush");
        startInfo.Arguments = "/c ipconfig /registerdns";
        process.Start();
        Console.WriteLine("Concluído Register.");
        startInfo.Arguments = "/c nbtstat -rr";
        process.Start();
        Console.WriteLine("Concluído nbt.");
        startInfo.Arguments = "/c netsh winsock reset";
        process.Start();
        Console.WriteLine("Concluído netsh.");
        startInfo.Arguments = "/c netsh int ip reset all";
        process.Start();
        
        
        Console.WriteLine("Realizado Reset de Rede.");
        Console.ReadLine();
    }
}