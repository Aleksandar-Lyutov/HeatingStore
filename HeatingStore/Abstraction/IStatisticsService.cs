﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Abstraction
{
    public interface IStatisticsService
    {
        int CountHeatingDevices();
        int CountClients();
        int CountOrders();
        decimal SumOrders();
    }
}
