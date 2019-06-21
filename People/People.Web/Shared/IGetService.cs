namespace People.Web.Shared
{
    public interface IGetService<T> where T : class
    {
        T Get();
    }
}
