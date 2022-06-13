// Рекурсия для хождения по папкам и смотреть что внутри
void CatalogInfo(string path, string indent = "")

{

    DirectoryInfo catalogs = new DirectoryInfo(path);


    foreach (var currentCatalog in catalogs.GetDirectories())

    {

        Console.WriteLine($"{indent}{currentCatalog.Name}");

        CatalogInfo(currentCatalog.FullName, indent + "  ");

    }


    foreach (var item in catalogs.GetFiles())

    {

        Console.WriteLine($"{indent}{item.Name}");

    }

}

string path = @"/Users/dariazueva/Dropbox/Zueva/GB";

CatalogInfo(path);