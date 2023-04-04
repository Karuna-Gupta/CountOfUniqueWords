// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter path for files:");
string path = Console.ReadLine();
string[] files;
if (path != null)
{
    string filter = "*.txt";
    files = Directory.GetFiles(path, filter);


    Task.Factory.StartNew(() =>
    {
        for (int i = 0; i < files.Length; ++i)
        {

            CountWords(files[i]);
            if (i % 5 == 0)
            {
                Thread.Sleep(2000);
            }
        }
    });
}

void CountWords(string path)
{
    string[] content = File.ReadAllLines(path);
    foreach (string line in content)
    {
        Console.WriteLine(line);
    }
    
}

Console.ReadLine();


