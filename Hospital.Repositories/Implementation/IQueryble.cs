namespace Hospital.Repositories.Implementation
{
    internal interface IQueryble<T> where T : class
    {
        IQueryble<T> Include(string includeProperty);
        IEnumerable<T> ToList();
    }
}