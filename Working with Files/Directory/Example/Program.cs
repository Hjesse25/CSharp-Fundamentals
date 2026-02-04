Directory.CreateDirectory(@"/home/shadowk/folder1");

var files = Directory.GetFiles(@"/home/shadowk/Code/CSharpFundamentals/", "*.slnx", SearchOption.AllDirectories);
foreach (var file in files)
    Console.WriteLine(file);

var directories = Directory.GetDirectories(@"/home/shadowk/Code/CSharpFundamentals/", "*.*", 
    SearchOption.AllDirectories);
foreach (var directory in directories)
    Console.WriteLine(directory);

Directory.Exists("...");

var directoryInfo = new DirectoryInfo("...");
directoryInfo.GetFiles();
directoryInfo.GetDirectories();
