using System.Linq.Expressions;

namespace GloboCrypto.WebAPI.Services.Data
{
    public interface ILocalDbService
    {
        void Delete<T>(Expression<Func<T, bool>> query);
        void Insert<T>(T item);
        void Upsert<T>(T item);
        IEnumerable<T> All<T>();
        IEnumerable<T> Query<T>(Expression<Func<T, bool>> query);
    }
}
