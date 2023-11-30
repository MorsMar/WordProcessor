using WordProcessor.DataLayer;
using WordProcessor.DomainLayer.Entities;
using WordProcessor.ApplicationLayer;


namespace WordProcessor.InfrastructureLayer.Services
{
    internal class InputService : IInputService
    {
        IDatabaseDictionary databaseDictionary;
        public InputService(IDatabaseDictionary DatabaseDictionary)
        {
            databaseDictionary = DatabaseDictionary;
        }
        public IEnumerable<Word> GetWordsDictionary()
        {
            return databaseDictionary.GetWordsList();
        }
    }
}
