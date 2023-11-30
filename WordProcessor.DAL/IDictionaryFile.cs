using WordProcessor.DomainLayer.Entities;
/*сервис для работы с файлами */
namespace WordProcessor.DataLayer
{
    public interface IDictionaryFile
    {
        public IEnumerable<WordCount> ReadTextFile(string pathFile);  
    }
}
