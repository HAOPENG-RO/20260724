using System;
using System.Collections.Generic;
using System.Text;

namespace Nisyuu2
{
    internal class CoinCase
    {
        private int C500 = 0;
        private int C100 = 0;
        private int C50 = 0;
        private int C10 = 0;
        private int C5 = 0;
        private int C1 = 0;

        public void AddCoin(int coin, int count)
        {
            switch (coin)
            {
                case 500:
                    C500 += count;
                    break;
                case 100:
                    C100 += count;
                    break;
                case 50:
                    C50 += count;
                    break;
                case 10:
                    C10 += count;
                    break;
                case 5:
                    C5 += count;
                    break;
                case 1:
                    C1 += count;
                    break;
                default:
                    break;
            }
        }
        public int GetCoin(int coin)
        {
            switch (coin)
            {
                case 500:
                    return C500;
                    break;
                case 100:
                    return C100;
                    break;
                case 50:
                    return C50;
                    break;
                case 10:
                    return C10;
                    break;
                case 5:
                    return C5;
                    break;
                case 1:
                    return C1;
                    break;
                default:
                    return 0;
            }
        }

        public int GetAmount()
        {
            return C500 * 500 +
                   C100 * 100 + 
                   C50 * 50 + 
                   C10 * 10 + 
                   C5 * 5 + 
                   C1;
        }
        public int GetCount()
        {
            return C500+C100+C50+C10+C5+C1;
        }
    }
}
