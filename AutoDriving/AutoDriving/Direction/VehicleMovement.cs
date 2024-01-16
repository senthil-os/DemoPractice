using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDriving.Direction
{
    public class VehicleMovement : IVehicleMovement
    {
        private int _iMinX = 0;
        private int _iMinY = 0;

        private int _iMaxX = 0;
        private int _iMaxY = 0;

        private int _iPositionX = 0;
        private int _iPositionY = 0;

        private Util.Direction _chrDirection;
        public VehicleMovement()
        { }
        public int MinX
        {
            get { return _iMinX; }
            set { _iMinX = value; }
        }
        public int MinY
        {
            get { return _iMinY; }
            set { _iMinY = value; }
        }

        public int MaxX
        {
            get { return _iMaxX; }
            set { _iMaxX = value; }
        }
        public int MaxY
        {
            get { return _iMaxY; }
            set { _iMaxY = value; }
        }

        public int PositionX
        {
            get { return _iPositionX; }
            set { _iPositionX = value; }
        }
        public int PositionY
        {
            get { return _iPositionY; }
            set { _iPositionY = value; }
        }

        public Util.Direction Direction
        {
            get { return _chrDirection; }
            set { _chrDirection = value; }
        }
        public void TurnLeft()
        {
            if (Direction == Util.Direction.North)
            {
                Direction = Util.Direction.West;
            }
            else if (Direction == Util.Direction.West)
            {
                Direction = Util.Direction.South;
            }
            else if (Direction == Util.Direction.South)
            {
                Direction = Util.Direction.East;
            }
            else if (Direction == Util.Direction.East)
            {
                Direction = Util.Direction.North;
            }
            else { }//No Implementation
        }
        public void TurnRight()
        {
            if (Direction == Util.Direction.North)
            {
                Direction = Util.Direction.East;
            }
            else if (Direction == Util.Direction.East)
            {
                Direction = Util.Direction.South;
            }
            else if (Direction == Util.Direction.South)
            {
                Direction = Util.Direction.West;
            }
            else if (Direction == Util.Direction.West)
            {
                Direction = Util.Direction.North;
            }            
            else { }//No Implementation
        }
        public void MoveForward()
        {
            if (Direction == Util.Direction.North)
            {
                PositionY = (PositionY + 1) > MaxY ? PositionY : (PositionY + 1);
            }
            else if (Direction == Util.Direction.South)
            {
                PositionY = (PositionY - 1) < MinY ? PositionY : (PositionY - 1);
            }
            else if (Direction == Util.Direction.East)
            {
                PositionX = (PositionX + 1) > MaxX ? PositionX : (PositionX + 1);
            }
            else if (Direction == Util.Direction.West)
            {
                PositionX = (PositionX - 1) > MinX ? PositionX : (PositionX - 1);
            }
            else { }//No Implementation

        }
        public Tuple<int, int, Char> JourneyDestination(string strPath)
        { 
        Char _left = (Char)Util.Movement.TurnLeft;
        Char _right = (Char)Util.Movement.TurnRight;
        Char _moveForward = (Char)Util.Movement.MoveForward;
        char[] journey = strPath.ToCharArray();
            for (int i = 0; i <= journey.Length - 1; i++)
            {
                if (journey[i] == _left)
                {
                    TurnLeft();
                }
                else if (journey[i] == _right)
                {
                    TurnRight();
                }
                else if (journey[i] == _moveForward)
                {
                    MoveForward();
                }
                else
                { }//Noimplementation                 
            }
            return Tuple.Create(PositionX, PositionY, (Char)Direction);
        }
    }
}
