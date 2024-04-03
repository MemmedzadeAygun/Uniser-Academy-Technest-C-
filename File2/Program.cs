
//string path = @"C:\Users\Lenovo\Documents\Uniser-Academy\Technest";
//string inputFile = @"C:\Users\Lenovo\Documents\Uniser-Academy\Technest\UniserWorker.txt";

//string outputFile = Path.Combine(path, "OutputFile.txt");
//File.Create(outputFile);

//int key = 2;

//void Encryption(string inputFile, string outputFile,int key)
//{
//    byte[] inputBytes = File.ReadAllBytes(inputFile);
//    for(int i=0; i < inputFile.Length; i++)
//    {
//        inputBytes[i] = (byte)(inputBytes[i] * key);
//    }

//    File.WriteAllBytes(outputFile, inputBytes);
//    Console.WriteLine("Operation Completed");
//}

string path = @"C:\Users\Lenovo\Documents\Uniser-Academy\Technest";
string newFolderPath = Path.Combine(path, "UniserWorkers.txt");
File.Create(newFolderPath);
Console.WriteLine(newFolderPath);