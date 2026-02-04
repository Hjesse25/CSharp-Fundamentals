var path = @"[FilePath]";

File.Copy("", "", true);
File.Delete(path);
if (File.Exists(path))
{
    //
}
var content = File.ReadAllText(path);

var fileInfo = new FileInfo(path);
fileInfo.CopyTo("...");
fileInfo.Delete();
if (fileInfo.Exists)
{
    //
}
