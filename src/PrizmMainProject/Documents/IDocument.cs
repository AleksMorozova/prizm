namespace PrizmMain.Documents
{
    internal interface IDocument
    {
        bool NeedToSave { get; }
        void Save();
    }
}