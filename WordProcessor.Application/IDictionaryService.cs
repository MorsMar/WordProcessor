namespace WordProcessor.ApplicationLayer
{
    public interface IDictionaryService
    {
        void AddDictionary(string pathFile);
        void UpdateDictionary(string pathFile);
        void ClearDictionary();
    }
}
