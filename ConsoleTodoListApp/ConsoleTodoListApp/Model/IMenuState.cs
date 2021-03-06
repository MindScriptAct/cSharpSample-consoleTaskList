﻿using ConsoleTodoListApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Model
{
    public interface IMenuState
    {
        int ActiveButtonNr { get; set; }
        int TotalButtonCount { get; }
        ButtonName ActiveButtonName { get; }
    }
}
