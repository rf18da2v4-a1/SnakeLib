﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLib.state
{
    public interface IStateMachinePattern
    {
        IStateMachinePattern NextState(InputType input);
        SnakeStatesTypes NextAction(InputType input);

    }
}
