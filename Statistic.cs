﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyzerRunner
{
    internal struct Statistic
    {
        public Statistic(int numberOfNodes, int numberOfTokens, int numberOfTrivia)
        {
            this.NumberofNodes = numberOfNodes;
            this.NumberOfTokens = numberOfTokens;
            this.NumberOfTrivia = numberOfTrivia;
        }

        public int NumberofNodes { get; }

        public int NumberOfTokens { get; }

        public int NumberOfTrivia { get; }

        public static Statistic operator +(Statistic statistic1, Statistic statistic2)
        {
            return new Statistic(
                statistic1.NumberofNodes + statistic2.NumberofNodes,
                statistic1.NumberOfTokens + statistic2.NumberOfTokens,
                statistic1.NumberOfTrivia + statistic2.NumberOfTrivia);
        }
    }
}
