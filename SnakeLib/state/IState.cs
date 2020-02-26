using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLib.state
{
    public enum SnakeStatesTypes
    {
        NORTH,
        EAST,
        WEST,
        SOUTH
    };

    public enum InputType
    {
        LEFT,
        RIGHT,
        FORWARD
    };

    public interface IState
    {
        SnakeStatesTypes NextMove(InputType input);
    }
}
