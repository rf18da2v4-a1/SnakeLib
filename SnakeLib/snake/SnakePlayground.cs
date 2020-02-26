using System;
using System.Collections.Generic;
using System.Text;
using SnakeLib.state;

namespace SnakeLib.snake
{
    public class SnakePlayground
    {
        // playgound
        private char[,] _playground;
        private readonly int maxWidth;
        private readonly int maxHeight;
        private readonly String horizontalLine = "";


        // snake Head
        private int _headrow;
        private int _headcol;

        public SnakePlayground(int width, int height)
        {
            _playground = new char[width,height];
            maxWidth = width;
            maxHeight = height;
            for (int i = 0; i < width+2; i++)
            {
                horizontalLine += "-";
            }

            _headrow = width / 2;
            _headcol = height / 2;
        }

        public bool DoNextMove(SnakeStatesTypes move)
        {
            bool inside = true;

            switch (move)
            {
                case SnakeStatesTypes.NORTH:
                    _headrow--;
                    break;
                case SnakeStatesTypes.SOUTH:
                    _headrow++;
                    break;
                case SnakeStatesTypes.EAST:
                    _headcol++;
                    break;
                case SnakeStatesTypes.WEST:
                    _headcol--;
                    break;
            }


            // check if snake is moving outside playground
            if (_headrow == maxHeight || _headrow == -1 ||
                _headcol == maxWidth || _headcol == -1)
            {
                inside = false; // snake is outside playground
            }
            else
            {
                PrintPlayground(); // snake still inside
            }

            return inside;
        }

        private void PrintPlayground()
        {
            Console.Clear();
            Console.WriteLine("Snake ");
            Console.WriteLine(horizontalLine);
            for (int r = 0; r < maxHeight; r++)
            {
                Console.WriteLine($"|{GetRowString(r)}|");
            }
            Console.WriteLine(horizontalLine);
        }
        private String GetRowString(int r)
        {
            StringBuilder sb = new StringBuilder();
            for (int c = 0; c < maxWidth; c++)
            {
                if (r == _headrow && c == _headcol)
                    sb.Append('H'); // head of snake
                else
                    sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}
