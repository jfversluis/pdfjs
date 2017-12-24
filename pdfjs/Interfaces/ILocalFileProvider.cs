using System.IO;
using System.Threading.Tasks;

namespace pdfjs.Interfaces
{
    public interface ILocalFileProvider
    {
        Task<string> SaveFileToDisk(Stream stream, string fileName);
    }
}