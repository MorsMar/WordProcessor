using System.Text;
using System.Text.RegularExpressions;
using WordProcessor.DomainLayer.Entities;
using WordProcessor.DataLayer;

namespace WordProcessor.InfrastructureLayer.DataClasses
{
    internal class DictionaryFile : IDictionaryFile
    {
        /*возвращает список часто встречающихся слов и их количество*/
        public IEnumerable<WordCount> ReadTextFile(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                return Regex.Matches(GetTextFile(pathFile), @"[^ _.,;:\r\n\t!?0-9]+").Where(x => x.Length >= 3)
                                                                              .GroupBy(x => x.Value)
                                                                              .Select(i => new WordCount(new Word(i.Key), i.Count()));
            }
            return Enumerable.Empty<WordCount>();
        }
        /*получает текст из файла*/
        private static string GetTextFile(string pathFile)
        {
            var lines = File.ReadAllLines(pathFile, Encoding.UTF8);
            return string.Join(" ", lines)/*.ToLower()*/;
        }
    }
}
