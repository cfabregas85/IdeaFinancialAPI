using System.Collections.Generic;
using APIIdeaFinancial.Models;

namespace APIIdeaFinancial.Services
{
    public interface ITransactionService
    {
        TransactionModel Get();
        bool Update(int id , int amount);        
    }
}