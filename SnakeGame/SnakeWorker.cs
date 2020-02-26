using System;
using SnakeLib.snake;
using SnakeLib.state;

namespace SnakeGame
{
    internal class SnakeWorker
    {
        public void Start()
        {
            SnakePlayground pg = new SnakePlayground(20,20);
            
            // using table state machine
            //IState stateMachine = new SnakeTableStateMachine();

            // using state machine pattern
            IState stateMachine = new SnakeStateMachinePattern();

            bool gameContinue = true;
            while (gameContinue)
            {
                InputType nextInput = ReadNextEvent();
                SnakeStatesTypes nextMove = stateMachine.NextMove(nextInput);

                gameContinue = pg.DoNextMove(nextMove);
                
            }

            Console.WriteLine("You loose :-( ");

        }


        private InputType ReadNextEvent()
        {
            InputType ev = InputType.FORWARD;

            Console.Write("Type next movement 'a,w,d' : ");
            bool ok = false;
            while (!ok)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                char c = info.KeyChar;
                switch (c)
                {
                    case 'a':
                        ev = InputType.LEFT;
                        ok = true;
                        break;
                    case 'd':
                        ev = InputType.RIGHT;
                        ok = true;
                        break;
                    case 'w':
                        ev = InputType.FORWARD;
                        ok = true;
                        break;
                }
            }

            return ev;
        }
    }
}