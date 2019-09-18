using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIdeaFinancial.Models;
using APIIdeaFinancial.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIIdeaFinancial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        // GET: api/Transaction
        [HttpGet]
        public TransactionModel Get()
        {
            var transaction = this._transactionService.Get();           
            return transaction;
        }

        // PUT: api/Transaction/5
        [HttpGet("{id}/{amount}")]
        public bool Get(int id , int amount)
        {
           return this._transactionService.Update(id, amount);
        }






    }
}
