using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIdeaFinancial.Data
{
    public class TransactionDatabaseSettings : ITransactionDatabaseSettings
    {
        public string TransactionCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    
}
