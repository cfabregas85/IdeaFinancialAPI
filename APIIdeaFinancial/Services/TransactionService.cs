using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIdeaFinancial.Data;
using APIIdeaFinancial.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace APIIdeaFinancial.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IMongoCollection<TransactionModel> _trasn;


        #region Ctr

        public TransactionService(ITransactionDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _trasn = database.GetCollection<TransactionModel>(settings.TransactionCollectionName);
        }

        #endregion

        #region Methos        

        public TransactionModel Get() { 
           return _trasn.Find(trans => true).FirstOrDefault();
        }

        public bool Update(int id , int amount)
        {
            var card = _trasn.Find(c => c.cardId == id).FirstOrDefault();
            if ( card == null)
             {
                return false;
             }
            //Check Available Fund
            if (amount + card.balance > card.creditlimit)
            {
                return false;
            }
            else{
                //Updated balance
                card.balance = card.balance + amount;
                //Updated availablefunds
                card.availablefunds = card.creditlimit - card.balance;
            }
           _trasn.ReplaceOne(trasn => trasn.Id == card.Id, card);
            return true;
        }

        #endregion 



    }
}
