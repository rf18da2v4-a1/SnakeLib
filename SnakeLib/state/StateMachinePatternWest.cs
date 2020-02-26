using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLib.state
{
    public class StateMachinePatternWest:IStateMachinePattern
    {
        private static readonly IStateMachinePattern NORTH = new StateMachinePatternNorth();
        private static readonly IStateMachinePattern SOUTH = new StateMachinePatternSouth();


        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return this;
                case InputType.LEFT: return SOUTH;
                case InputType.RIGHT: return NORTH;
            }

            return this;

        }

        public SnakeStatesTypes NextAction(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return SnakeStatesTypes.WEST;
                case InputType.LEFT: return SnakeStatesTypes.SOUTH;
                case InputType.RIGHT: return SnakeStatesTypes.NORTH;
            }

            return SnakeStatesTypes.NORTH;
        }
    }
}
