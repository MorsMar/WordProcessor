using WordProcessor.DomainLayer.Entities;

namespace WordProcessor.ApplicationLayer
{
    public interface IInputService
    {
        IEnumerable<Word> GetWordsDictionary();
      
    }
}
