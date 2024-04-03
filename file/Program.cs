
using file.Classes;
using Microsoft.VisualBasic.FileIO;
using System.Text;

string path = @"C:\Users\Lenovo\Documents\TextFolder";

string newPath = Path.Combine(path, "test.txt");

//Console.WriteLine(newPath);
//Console.WriteLine(Path.GetFileName(newPath));
//Console.WriteLine(Path.GetDirectoryName(newPath));
//Console.WriteLine(Path.GetExtension(newPath));
//Console.WriteLine(Path.GetFullPath(newPath));
//Console.WriteLine(Path.Exists(newPath));


//Console.WriteLine(Path.Combine(Path.GetDirectoryName(newPath), "SubFolder"));
//string newFolder = Path.Combine(Path.GetDirectoryName(newPath), "SubFolder");
//Directory.CreateDirectory(newFolder);
////Directory.Delete(newFolder, true);

//Console.WriteLine(Directory.GetCurrentDirectory());
//string[] folders = Directory.GetDirectories(path);
//string[] files = Directory.GetFiles(path);

//Console.WriteLine(folders[0]);
//Console.WriteLine(files[0]);

//Console.WriteLine(SpecialDirectories.MyDocuments);
//Console.WriteLine(Environment.SpecialFolder.MyDocuments);

//foreach (var item in Directory.GetDirectories(SpecialDirectories.MyDocuments))
//{
//    Console.WriteLine(item);
//}


//string myDocuments = SpecialDirectories.MyDocuments;

//string testFolder = Path.Combine(myDocuments, "TextFolder");
//string newSubFolderPath = Path.Combine(testFolder, "SubFolder2");

//Directory.CreateDirectory(newSubFolderPath);

//Console.WriteLine(Environment.OSVersion.VersionString);
//Console.WriteLine(newSubFolderPath);

//File.Create(newPath);

//File.WriteAllText(newPath, "Technest telebeleri!");

//string text=File.ReadAllText(newPath);
//Console.WriteLine(text);

//string[] lines=File.ReadAllLines(newPath);

//foreach(string line in lines)
//{
//    Console.WriteLine(line);
//}



//List<string> contents = new List<string>();

//List<Student> students = new List<Student>()
//{
//    new Student{FirstName="Bruce", LastName="Wayne"},
//    new Student{FirstName="Walter", LastName="White"},
//    new Student{FirstName="Jemie", LastName="Lannister"},
//    new Student{FirstName="Jhon", LastName="Week"},
//};

//foreach (var student in students)
//{
//    contents.Add($"{student.Id}\t {student.FirstName}\t {student.LastName}");
//}

//File.AppendAllLines(uniserPath,contents);


//IEnumerable<Student> students = new List<Student>();
//List<string> lines = File.ReadAllLines(uniserPath).ToList();

//foreach (string line in lines)
//{
//    Console.WriteLine(line);
//    string[] parts = line.Split(',');
//}


string data = Path.Combine(path, "Data.txt");
using (FileStream fileStream = new FileStream(data, FileMode.Create))
{
    string testValue = "Bu file stream ile yazilan deyerdir";

    byte[] byteValues = Encoding.UTF8.GetBytes(testValue);

    fileStream.Write(byteValues, 0, byteValues.Length);
}


