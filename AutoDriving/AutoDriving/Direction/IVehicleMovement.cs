using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AutoDriving.Direction
{
   public interface IVehicleMovement
    {
        public void TurnLeft();
        public void TurnRight();
        public void MoveForward();

    }
}
