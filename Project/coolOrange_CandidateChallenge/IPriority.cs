﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    internal interface IPriority
    {

        void SetPriority(Task.Priority priority);
        Task.Priority GetPriority();

    }
}
