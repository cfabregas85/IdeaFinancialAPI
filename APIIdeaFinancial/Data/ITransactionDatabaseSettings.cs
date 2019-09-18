namespace APIIdeaFinancial.Data
{
    public interface ITransactionDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string TransactionCollectionName { get; set; }
    }
}