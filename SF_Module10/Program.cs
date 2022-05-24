using System;

namespace SF_Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* (II) [10.2.2]
            Writer writer = new Writer();

            ((IWriter) writer).Write();

            Console.ReadKey();
            */

            /* (IV) [10.2.4]
            Worker worker = new Worker();

            ((IWorker)worker).Build();

            Console.ReadKey();
            */

            /* (VIII) [10.4.4]
            var user = new User();
            var account = new Account();

            IUpdater<Account> updater = new UserService();

            var userService = new UserService();

            userService.Update(user);
            */
        }
    }

    /* (I) [10.1.4]
    public interface IManager
    {
        void Create();

        void Read();

        void Update();

        void Delete();
    }

    public class Manager : IManager
    {
        public void Create() { }

        public void Read() { }

        public void Update() { }

        public void Delete() { }
    }
    */

    /* (II) [10.2.2]
    public interface IWriter
    {
        void Write();
    }

    public class Writer : IWriter
    {
        void IWriter.Write() { }
    }
    */

    /* (III) [10.2.3]
    public interface IWorker
    {
        public void Build();
    }

    public class Worker : IWorker
    {
        public void Build() { }
    }
    */

    /* (IV) [10.2.4]
    public interface IWorker
    {
        public void Build();
    }

    public class Worker : IWorker
    {
        void IWorker.Build() { }
    }
    */

    /* (V) [10.3.1]
    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    public class FileManager : IWriter, IReader, IMailer
    {
        public void Write() { }

        public void Read() { }

        public void SendEmail() { }
    }
    */

    /* (VI) [10.3.2]
    public interface ICreatable
    {
        void Create();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface IUpdatable
    {
        void Update();
    }

    public class Entity : ICreatable, IDeletable, IUpdatable
    {
        public void Create() { }

        public void Delete() { }

        public void Update() { }
    }
    */

    /* (VII) [10.3.3]
    public interface IBook
    {
        void Read();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    public class ElectronicBook : IBook, IDevice
    {
        void IBook.Read() { }

        void IDevice.TurnOn() { }

        void IDevice.TurnOff() { }
    }
    */

    /* VIII) [10.4.4]
    public class User { }

    public class Account : User { }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    public class UserService : IUpdater<User>
    {
        public void Update(User entity) { }
    }
    */
}
