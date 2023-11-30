using System.Data;
using WordProcessor.ApplicationLayer;
using WordProcessor.DataLayer;
using WordProcessor.DomainLayer.Entities;

namespace WordProcessor.InfrastructureLayer.Services
{
    internal class DictionaryService : IDictionaryService
    {
        //private List<WordCount> wordsList = new List<WordCount>();
        private IDatabaseDictionary databaseDictionary;
        private IDictionaryFile dictionaryFile;
        public DictionaryService(IDatabaseDictionary DatabaseDictionary, IDictionaryFile DictionaryFile)
        {
            databaseDictionary = DatabaseDictionary;
            dictionaryFile = DictionaryFile;
        }
        public void AddDictionary(string pathFile)
        {
            databaseDictionary.DeleteWordsAll();
            var wordsCountList = GetWordCountsFile(pathFile);

            foreach (var word in wordsCountList)
            {
                databaseDictionary.SaveWord(word.WordId.word, word.Count);
            }
        }

        public void UpdateDictionary(string pathFile)
        {
            foreach (var word in GetWordCountsFile(pathFile))
            {
                databaseDictionary.SaveWord(word.WordId.word, word.Count);
            }
        }
        public void ClearDictionary()
        {
            databaseDictionary.DeleteWordsAll();
            //wordsList.Clear();
        }
        private List<WordCount> GetWordCountsFile(string pathFile) => dictionaryFile.ReadTextFile(pathFile).Where(x => x.Count > 2).ToList();
        private void ClearData()
        {
            //if (databaseDictionary.DatabaseIsEmpty())
            //{
            //    databaseDictionary.DeleteWordsAll();
            //    //wordsList.Clear();
            //}
        }
    }
}
