﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserModeling
{
    public interface IQuery
    {
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        object Query(object input);

        /// <summary>
        /// User do not know the next action,
        /// agent needs to give a adaptive feedback.
        /// </summary>
        /// <returns></returns>
        object Query();
    }
}
