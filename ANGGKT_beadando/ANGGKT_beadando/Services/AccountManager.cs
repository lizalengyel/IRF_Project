﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANGGKT_beadando.Services
{
    class AccountManager
    {

        public BindingList<Account> Accounts { get; } = new BindingList<Account>();

        public Account CreateAccount(Account account)
        {
            var oldAccount = (from a in Accounts
                              where a.email.Equals(account.email)
                              select a).FirstOrDefault();

            if (oldAccount != null)
                throw new ApplicationException(
                    "Már létezik felhasználó ilyen e-mail címmel!");

            Accounts.Add(account);

            return account;
        }
}
