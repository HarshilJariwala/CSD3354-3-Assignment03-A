using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Class1
    {
        private string m_customerName;
        private double m_balance;
        private bool m_frozen = false;

        private Class1()
        { }

        public Class1(string customerName, double balance) {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName {
            get  { return m_customerName; }

        }
        public double balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount) {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
            if(amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }

        public void credit(double amount)
        {
            if(m_frozen)
            {
                throw new ArgumentOutOfRangeException("Amount frozen");
            }
            if(amount<0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }
        }

        }
    }

