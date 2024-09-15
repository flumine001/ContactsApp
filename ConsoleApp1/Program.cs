// See https://aka.ms/new-console-template for more information
/*
using ContactsApp;
using Newtonsoft.Json;
using System.IO;


var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
           "\\ContactsApp1";
var filename = path + "ConsoleApp1.notes";
Directory.CreateDirectory(path);
var FileName = "ContactApp1.notes";
var SaveFilePath =
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
    "\\ContactsApp1";
var FilePath = Path.Combine(SaveFilePath, FileName);
var contacts = new Contacts("Вася", "Пупкин", DateTime.Now, "krutoy@mail.ru", 79000000000, "id12345");
var contacts2 = new Contacts("Петя", "Вупсень", DateTime.Now, "nekrutoy@mail.ru", 79999999999, "id1");
JsonSerializer serializer = new JsonSerializer();
using (StreamWriter sw = new StreamWriter(FilePath))
using (JsonWriter writer = new JsonTextWriter(sw))
{
    //Вызываем сериализацию и передаем объект, который хотим сериализовать
    serializer.Serialize(writer, contacts);
    serializer.Serialize(writer, contacts2);
}

Contacts contact2 = null;

JsonSerializer serializer1 = new JsonSerializer();

using (StreamReader sr = new StreamReader(FilePath))
using (JsonReader reader = new JsonTextReader(sr))
{
    contact2 = (Contacts)serializer1.Deserialize<Contacts>(reader);
}
Console.WriteLine(contact2.FirstName);
*/