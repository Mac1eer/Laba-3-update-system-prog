using System.Diagnostics;

string[] processNames = { "notepad", "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Excel.lnk", "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Word.lnk" };
Process[] processes = new Process[processNames.Length];
 // Открываем приложения
for (int i = 0; i < processNames.Length; i++)
{
    try
    {
        processes[i] = Process.Start(processNames[i]);
        Console.WriteLine($"{processNames[i]} запущен с PID: {processes[i].Id}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine("Нажмите любую клавишу, чтобы завершить процессы...");
Console.ReadKey(); // Отключение приложений по нажатию кнопки
try
{
    foreach (Process process in processes)
    {
        process.Kill(); // Завершаем процессы
    }
}
catch (Exception ex)
{
     Console.WriteLine(ex.Message);
}

