using System;
using System.Data.Entity;
using System.Linq;

namespace Homework_EF_CodeFirst
{
    public class ApplicationContex : DbContext
    {
        // Контекст настроен для использования строки подключения "ApplicationContex" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Homework_EF_CodeFirst.ApplicationContex" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ApplicationContex" 
        // в файле конфигурации приложения.
        public ApplicationContex()
            : base("name=ApplicationContex")
        {
        }

        public virtual DbSet<Game> Games { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}