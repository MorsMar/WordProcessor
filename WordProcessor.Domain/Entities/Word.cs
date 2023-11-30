namespace WordProcessor.DomainLayer.Entities
{
    public class Word
    {
        public int Id { get; set; }
        public string word { get; set; }
        public Word(string word)
        {
            this.word= word;
        }
        public Word()
        {
        }
    }
}