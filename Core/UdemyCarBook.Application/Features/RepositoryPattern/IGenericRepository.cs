namespace UdemyCarBook.Application.Features.RepositoryPattern
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        void Create (T entity);
        void Update (T entity);
        void Remove (int id);
        T GetById (int id);
    }
}
