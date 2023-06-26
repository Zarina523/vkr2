using project2.Services;
using project2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Reflection;

namespace project2
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "vkr.db";
        private static SymptomsAsyncRepository database;
        public static SymptomsAsyncRepository Database
        {
            get
            {
                if (database == null)
                {
                    // путь, по которому будет находиться база данных
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME);
                    // если база данных не существует (еще не скопирована)
                    if (!File.Exists(dbPath))
                    {
                        // получаем текущую сборку
                        var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                        // берем из нее ресурс базы данных и создаем из него поток
                        using (Stream stream = assembly.GetManifestResourceStream($"project2.{DATABASE_NAME}"))
                        {
                            using (FileStream fs = new FileStream(dbPath, FileMode.OpenOrCreate))
                            {
                                stream.CopyTo(fs);  // копируем файл базы данных в нужное нам место
                                fs.Flush();
                            }
                        }
                    }
                    database = new SymptomsAsyncRepository(dbPath);
                }
                return database;
            }
        }

        private static DB db;
        public static DB Db
        {
            get
            {
                if (db == null)
                
                    db = new DB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"db2.sqlite3"));
                return db;
            }
        }


        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();


            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
