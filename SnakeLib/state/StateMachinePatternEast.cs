using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLib.state
{
    public class StateMachinePatternEast:IStateMachinePattern
    {
        private static readonly IStateMachinePattern NORTH = new StateMachinePatternNorth();
        private static readonly IStateMachinePattern SOUTH = new StateMachinePatternSouth();


        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return this;
                case InputType.LEFT: return NORTH;
                case InputType.RIGHT: return SOUTH;
            }

            return this;

        }

        public SnakeStatesTypes NextAction(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return SnakeStatesTypes.EAST;
                case InputType.LEFT: return SnakeStatesTypes.NORTH;
                case InputType.RIGHT: return SnakeStatesTypes.SOUTH;
            }

            return SnakeStatesTypes.NORTH;
        }
    }
}
