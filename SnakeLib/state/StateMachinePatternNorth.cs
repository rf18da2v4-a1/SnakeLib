using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLib.state
{
    public class StateMachinePatternNorth:IStateMachinePattern
    {
        private static readonly IStateMachinePattern WEST = new StateMachinePatternWest();
        private static readonly IStateMachinePattern EAST = new StateMachinePatternEast();


        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return this;
                case InputType.LEFT: return WEST;
                case InputType.RIGHT: return EAST;
            }

            return this;

        }

        public SnakeStatesTypes NextAction(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return SnakeStatesTypes.NORTH;
                case InputType.LEFT: return SnakeStatesTypes.WEST;
                case InputType.RIGHT: return SnakeStatesTypes.EAST;
            }

            return SnakeStatesTypes.NORTH;
        }
    }
}
