﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStockAnalyzer.Models;

namespace MyStockAnalyzer.StockSelectionAlgorithms.Interfaces
{
    public interface IStockSelectionAlgorithm
    {
        string Name { get; }
        List<StockSelectionResult> GetSelectionResult(List<StockChartData> stockPriceList, DateTime checkBgn, DateTime checkEnd);
    }
}
