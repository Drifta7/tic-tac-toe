﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class Enums
    {
        public enum playerChoice
        {
            PlayerChoice_x,
            PlayerChoice_o
        }


        public enum playerPostion
        {
            topLeftCorner = 1,
            topMiddleCorner = 2,
            topRightConer,

            midLeft,
            midCenter,
            midRight,

            bottomLeftCorner,
            bottomMiddleCorner,
            bottomRightConer,
        }
    }

}
