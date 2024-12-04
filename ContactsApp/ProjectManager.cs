using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{

    namespace ContactsApp
    {
        /// <summary>
        /// Класс, реализующий сериализацию проекта с контактами
        /// </summary>
        ///
        public static class ProjectManager

        {


            /// <summary>
            /// Путь к файлу сохранения проекта с контактами
            /// </summary>
            private const string FileName = "ContactApp.notes";
            public static readonly string SaveFilePath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\ContactsAppZubkov";
            public static readonly string FilePath = Path.Combine(SaveFilePath, FileName);
            /// <summary>
            /// Метод, сохраняющий в файл проект с контактами
            /// </summary>
            /// <param name="project"></param>

            public static void SaveToFile(Project Contacts, string filepath)
            {
                if (!Directory.Exists(SaveFilePath))
                {
                    Directory.CreateDirectory(SaveFilePath);
                }
                if (!File.Exists(FilePath))
                {
                    File.Create(FilePath).Close();
                    

                }
            
                JsonSerializer serializer = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter(FilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, Contacts);
                    

                }
                
            }
            /// <summary>
            /// Метод, возвращающий проект с контактами из файла
            /// </summary>
            /// <returns>Эксземпляр класса Project из файла</returns>
            public static Project LoadFromFile(string filepath)
            {
                if (!Directory.Exists(SaveFilePath))
                {
                    Directory.CreateDirectory(SaveFilePath);
                }
                if (!File.Exists(FilePath))
                {
                    File.Create(FilePath).Close();


                }
                Project project = null;
                
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(FilePath))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = serializer.Deserialize<Project>(reader);
                }
                return project;
            }
            
        }
    }
}
