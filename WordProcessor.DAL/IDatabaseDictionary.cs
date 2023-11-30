using WordProcessor.DomainLayer.Entities;
/*сервис для работы с базой данных*/
namespace WordProcessor.DataLayer
{
    public interface IDatabaseDictionary
    {
        string stringConnection { get;}
        List<Word> GetWordsList();
        //Добавляет слово в таблицы
        bool SaveWord(string wordDict, int count);

        /*Удаляет данные из таблиц*/
        bool DeleteWordsAll();
    }
}