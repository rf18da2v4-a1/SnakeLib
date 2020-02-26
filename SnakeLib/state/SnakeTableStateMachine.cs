using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLib.state
{
    class StateAction
    {
        public SnakeStatesTypes State { get; set; } // next state
        public SnakeStatesTypes Action { get; set; } // direction the snake should move

    }
    public class SnakeTableStateMachine:IState
    {
        // internal table as StateMachine
        private StateAction[,] _stateMachine;
        private SnakeStatesTypes _currentState;

        public SnakeTableStateMachine()
        {
            _currentState = SnakeStatesTypes.NORTH;

            // initialize table
            _stateMachine = new StateAction[4,3];
            _stateMachine[(int)SnakeStatesTypes.NORTH, (int)InputType.LEFT] = new StateAction() { State = SnakeStatesTypes.WEST, Action = SnakeStatesTypes.WEST };
            _stateMachine[(int)SnakeStatesTypes.NORTH, (int)InputType.RIGHT] = new StateAction() { State = SnakeStatesTypes.EAST, Action = SnakeStatesTypes.EAST };
            _stateMachine[(int)SnakeStatesTypes.NORTH, (int)InputType.FORWARD] = new StateAction() { State = SnakeStatesTypes.NORTH, Action = SnakeStatesTypes.NORTH };

            _stateMachine[(int)SnakeStatesTypes.EAST, (int)InputType.LEFT] = new StateAction() { State = SnakeStatesTypes.NORTH, Action = SnakeStatesTypes.NORTH };
            _stateMachine[(int)SnakeStatesTypes.EAST, (int)InputType.RIGHT] = new StateAction() { State = SnakeStatesTypes.SOUTH, Action = SnakeStatesTypes.SOUTH };
            _stateMachine[(int)SnakeStatesTypes.EAST, (int)InputType.FORWARD] = new StateAction() { State = SnakeStatesTypes.EAST, Action = SnakeStatesTypes.EAST };

            _stateMachine[(int)SnakeStatesTypes.WEST, (int)InputType.LEFT] = new StateAction() { State = SnakeStatesTypes.SOUTH, Action = SnakeStatesTypes.SOUTH };
            _stateMachine[(int)SnakeStatesTypes.WEST, (int)InputType.RIGHT] = new StateAction() { State = SnakeStatesTypes.NORTH, Action = SnakeStatesTypes.NORTH };
            _stateMachine[(int)SnakeStatesTypes.WEST, (int)InputType.FORWARD] = new StateAction() { State = SnakeStatesTypes.WEST, Action = SnakeStatesTypes.WEST };

            _stateMachine[(int)SnakeStatesTypes.SOUTH, (int)InputType.LEFT] = new StateAction() { State = SnakeStatesTypes.EAST, Action = SnakeStatesTypes.EAST };
            _stateMachine[(int)SnakeStatesTypes.SOUTH, (int)InputType.RIGHT] = new StateAction() { State = SnakeStatesTypes.WEST, Action = SnakeStatesTypes.WEST };
            _stateMachine[(int)SnakeStatesTypes.SOUTH, (int)InputType.FORWARD] = new StateAction() { State = SnakeStatesTypes.SOUTH, Action = SnakeStatesTypes.SOUTH };
        }


        public SnakeStatesTypes NextMove(InputType input)
        {
            // Find next move from current state and input
            SnakeStatesTypes nextMove = _stateMachine[(int) _currentState, (int) input].Action;

            // Find next state from current state and input
            _currentState = _stateMachine[(int) _currentState, (int) input].State;
            return nextMove;
        }
    }
}
