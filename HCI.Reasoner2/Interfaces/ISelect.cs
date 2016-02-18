﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserModeling
{
    /// <summary>
    /// Problem Selection API
    /// </summary>
    public interface ISelect
    {
        void Select(int index);

        /// <summary>
        /// Bayesian Inference Method to Select the best next problem.
        /// </summary>
        /// <returns></returns>
        void Select();
    }
}
