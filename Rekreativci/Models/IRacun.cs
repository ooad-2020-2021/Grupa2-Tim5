﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    public interface IRacun
    {
        public void SkiniSaRacuna(double iznos);

        public void StaviNaRacun(double iznos);
    }
}
