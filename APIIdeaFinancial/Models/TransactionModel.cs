using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APIIdeaFinancial.Models
{
    public class TransactionModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int cardId { get; set; }
        public decimal amount { get; set; }
        public decimal balance { get; set; }
        public decimal availablefunds { get; set; }
        public decimal creditlimit { get; set; }     
    }
}
