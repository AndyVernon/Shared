namespace Shared.BusinessData.Interfaces
{
    public interface IBusinessDataReader<T>
    {
        IEnumerable<T> ListFiles(string containerName);
        T? GetFile(string containerName, string fileName);
    }
}
