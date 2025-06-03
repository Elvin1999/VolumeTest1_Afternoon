namespace VolumeTest1.Services
{
    public interface IFileService
    {
        Task<string> GetData(string path);
        Task SetData(string path, string value);
    }
}
