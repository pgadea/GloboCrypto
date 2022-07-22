using LiteDB;
using System.Linq.Expressions;

namespace GloboCrypto.WebAPI.Services.Data
{
    public class LocalDbService : ILocalDbService
    {
        private readonly LiteDatabase Local;

        private string GetFilePath(string fileName) => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

        public void Delete<T>(Expression<Func<T, bool>> query)
        {
            var collection = Local.GetCollection<T>();
            collection.DeleteMany(query);
        }

        public void Insert<T>(T item)
        {
            var collection = Local.GetCollection<T>();
            collection.Insert(item);
        }

        public void Upsert<T>(T item)
        {
            var collection = Local.GetCollection<T>();
            collection.Upsert(item);
        }

        public IEnumerable<T> All<T>()
        {
            var collection = Local.GetCollection<T>();
            return collection.FindAll().Skip(0).Take(100);
        }

        public IEnumerable<T> Query<T>(Expression<Func<T, bool>> query)
        {
            var collection = Local.GetCollection<T>();
            return collection.Find(query);
        }

        public LocalDbService(string fileName)
        {
            Local = new LiteDatabase($"filename={GetFilePath(fileName)};mode=Exclusive");
        }

        ~LocalDbService()
        {
            Local.Dispose();
        }
    }
}
