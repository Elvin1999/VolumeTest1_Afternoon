namespace VolumeTest1.Services
{
    public class FileService : IFileService
    {
        public async Task<string> GetData(string path)
        {
            return await File.ReadAllTextAsync(path);
        }
        public async Task SetData(string path, string value)
        {
            await File.WriteAllTextAsync(path, value);
        }
    }
}
