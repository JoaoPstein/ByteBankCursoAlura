using ByteBank.Entities;
using System.Collections.Generic;

namespace ByteBank.SystemAgency.Comparators
{
    public class ComparatorAccount : IComparer<Account>
    {
        int IComparer<Account>.Compare(Account x, Account y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            return x.Agency.CompareTo(y.Agency);
        }
    }
}
