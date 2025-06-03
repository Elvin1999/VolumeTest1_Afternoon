using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VolumeTest1.Services;

namespace VolumeTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly string _filePath = "/app/data.txt";
        private readonly IFileService _fileService;

        public DataController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            FileInfo fileInfo = new FileInfo(_filePath);
            if (fileInfo.Exists)
            {
                var result = await _fileService.GetData(_filePath);
                return Ok(result);
            }
            return NotFound($"{_filePath} did not find");
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] string value)
        {
            await _fileService.SetData(_filePath, value);
            return Ok(value);
        }
    }
}
