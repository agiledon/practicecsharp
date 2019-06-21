using System;

namespace PracticeCSharp.StudyClass
{
    public class Money
    {
        private int faceValue;
        private Currency currency;

        public Money() : this(0, Currency.RMB)
        {
        }

        public Money(int faceValue) : this(faceValue, Currency.RMB)
        {

        }

        public Money(int faceValue, Currency currency)
        {
            this.faceValue = faceValue;
            this.currency = currency;
        }

        public int FaceValue
        {
            get { return this.faceValue; }
        }

        public Currency Currency
        {
            get => this.currency;
        }

        public static Money operator+(Money first, Money second)
        {
            if (first.currency != second.currency)
            {
                throw new MoneyException("Currency is not same.");
            }
            return new Money(first.faceValue + second.faceValue, first.currency);
        }

        public static Money operator-(Money first, Money second)
        {
            if (first.currency != second.currency)
            {
                throw new MoneyException("Currency is not same.");
            }
            return new Money(first.faceValue - second.faceValue, first.currency);
        }
    }
}
