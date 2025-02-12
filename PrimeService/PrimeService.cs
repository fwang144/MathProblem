﻿using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= candidate/2; i++)
                {
                if (candidate % i == 0)
                {
                    return false;
                }

            }
            return true;

            }
        }
    }
}
