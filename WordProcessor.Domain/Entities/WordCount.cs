namespace WordProcessor.DomainLayer.Entities
{
    public class WordCount
    {
        public WordCount(){}
        public WordCount(Word wordId, int count)
        {
            WordId = wordId;
            Count = count;
        }
        public Word WordId { get; set; }
        public int Count { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj is WordCount wordCount) return WordId.word == wordCount.WordId.word;
            return false;
        }
    }
}
