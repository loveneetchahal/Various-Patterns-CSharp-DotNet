﻿using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransactions adapter = new TransAdapter();
            foreach (var item in adapter.GetTransactions())
            {
                Console.WriteLine(item);
            }
        }
    }

    public class TransAdapter : OrgYTransactions, ITransactions
    {
        public List<string> GetTransactions()
        {
            return GetTransactionsList();
        }
    }


    public interface ITransactions
    {
        List<string> GetTransactions();
    }

    public class OrgYTransactions
    {
        public List<string> GetTransactionsList()
        {
            List<string> transactions = new List<string>();
            transactions.Add("Debit 1");
            transactions.Add("Debit 2");
            transactions.Add("Debit 3");
            return transactions;
        }
    }
}
