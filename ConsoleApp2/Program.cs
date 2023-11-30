using WordProcessor.Data;
using WordProcessor.Domain.Entities;
//Encoding win1251 = Encoding.GetEncoding("windows-1251");
// var category = File.ReadAllLines("E:\\category.txt", Encoding.UTF8);
DatabaseDictionary.DeleteWordsAll();
DatabaseDictionary.SaveWord("море", 4);
DatabaseDictionary.SaveWord("морс", 4);
//int n=DatabaseDictionary.SaveWord("рак", 6);
//DatabaseDictionary.UpdateWord(n);
//Console.WriteLine(n);
//DatabaseDictionary.SaveWord(new Word("морс"));
//DatabaseDictionary.SaveWord(new Word("яблоко"));
//DatabaseDictionary.SaveWord(new Word("Мрамор"));
//DatabaseDictionary.SaveWord(new Word("Пена"));
List<Word> list = DatabaseDictionary.GetWords("мор");
foreach (Word word in list)
{
    Console.WriteLine(word.word +" "+word.Id);
}
//foreach (Word word in list)
//{
//    Console.WriteLine(word.word);
//}
//Console.WriteLine();
//List<Word> list1 = DatabaseDictionary.GetWordsAll();

//Dictionary<string,int> map=new Dictionary<string,int>();
//var lines = File.ReadAllLines("C:\\Users\\Мария\\source\\repos\\WordProcessor\\ConsoleApp2\\dict.txt", Encoding.UTF8);
//var line=string.Join(" ",lines).ToLower();
//var math = Regex.Matches(line, @"[^ _.,;:\r\n\t!?]+").Where(x => x.Length >= 3);
//var group = math.GroupBy(x => x.Value).Select(i => new { Word = i.Key, Count = i.Count() }).OrderByDescending(i => i.Count);
//Console.WriteLine(string.Join(", ", math));
//Console.WriteLine();
//foreach (var i in group) Console.Write(i + " ");

