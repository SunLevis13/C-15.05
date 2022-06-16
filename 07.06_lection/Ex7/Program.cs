// Рекурсия для обхода директории

string path = @"/Users/dariazueva/Dropbox/Zueva/GB";

DirectoryInfo di = new DirectoryInfo(path);

System.Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)

{

  System.Console.WriteLine(fi[i].Name);
}
