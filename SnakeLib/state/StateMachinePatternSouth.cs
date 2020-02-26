using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLib.state
{
    public class StateMachinePatternSouth:IStateMachinePattern
    {
        private static readonly IStateMachinePattern WEST = new StateMachinePatternWest();
        private static readonly IStateMachinePattern EAST = new StateMachinePatternEast();


        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return this;
                case InputType.LEFT: return EAST;
                case InputType.RIGHT: return WEST;
            }

            return this;

        }

        public SnakeStatesTypes NextAction(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return SnakeStatesTypes.NORTH;
                case InputType.LEFT: return SnakeStatesTypes.EAST;
                case InputType.RIGHT: return SnakeStatesTypes.WEST;
            }

            return SnakeStatesTypes.NORTH;
        }
    }
}
