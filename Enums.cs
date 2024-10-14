using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public static class Enums
    {
        public enum playerChoice
        {
            PlayerChoice_x,
            PlayerChoice_o
        }


        public enum playerPostion // the numbers are designated for the spaces for the grid
        {
            topLeftCorner = 1,
            topMiddleCorner = 2,
            topRightConer = 3,

            midLeft = 4,
            midCenter = 5,
            midRight = 6,

            bottomLeftCorner = 7,
            bottomMiddleCorner = 8,
            bottomRightConer = 9,
        }
    }

}
