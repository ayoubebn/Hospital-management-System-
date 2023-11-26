namespace Hospital.Repositories.Implementation
{
    public interface IOrderdQueryble<T> where T : class
    {
        IEnumerable<T> ToList();
    }
}