using System.Data;
using WordProcessor.DomainLayer.Entities;
using WordProcessor.DataLayer;
using Dapper;
using Microsoft.Data.Sqlite;

namespace WordProcessor.InfrastructureLayer.DataClasses
{
    public class DatabaseDictionary : IDatabaseDictionary
    {
        private IDbConnection connection;
        public string stringConnection { get; } = "Data Source=Resources\\DictionaryFrequentlyWords.db";
        public DatabaseDictionary()
        {
            connection = new SqliteConnection(stringConnection);
        }
        /*получает список слов*/
        public List<Word> GetWordsList()
        {
            return connection.Query<Word>("SELECT Id, Word FROM Words JOIN WordsCount ON Words.Id=WordsCount.WordId ORDER BY WordsCount.Count DESC, Words.Word").ToList();
        }

        /*Добавляет слово в таблицы*/
        public bool SaveWord(string wordDict, int count)
        {
            try
            {
                Word word = new Word(wordDict);
                connection.Execute("INSERT INTO Words (Word) VALUES (@word)", word);
                connection.Execute("INSERT INTO WordsCount (WordId,Count) VALUES (@Id,@Count)", new { Id = GetIdWord(word), Count = count });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /*получает id слова*/
        public int GetIdWord(Word word)
        {
            return connection.ExecuteScalar<int>("SELECT Id FROM Words WHERE Word=@word", new { word.word });
        }

        /*Удаляет данные из таблиц*/
        public bool DeleteWordsAll()
        {
            try
            {
                connection.Execute("DELETE FROM Words");
                connection.Execute("UPDATE sqlite_sequence SET seq=0 WHERE name='Words'");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}