using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDriving.Util
{
  public class Util
    {
        Char splitChar = ' ';
        public Util(){ }
        public Tuple<int,int,bool> ValidateMaxCoordinate(string strMaxCoordinate)
        {   
            int iMaxX = 0;
            int iMaxY = 0;
            bool isValid = false;
            try
            {
                string[] maxCoordinate = strMaxCoordinate.Split(splitChar);
                Int32.TryParse(maxCoordinate[0], out iMaxX);
                Int32.TryParse(maxCoordinate[1], out iMaxY);
                isValid = true;
            }
            catch (Exception ex) { isValid = false; } 
            return Tuple.Create(iMaxX-1 < 0?0: iMaxX - 1, iMaxY-1<0?0: iMaxY - 1, isValid);
        }
        public Tuple<int,int,char,bool> ValidateStartPosition(string startPosition)
        {   int iPositionX = 0;
            int iPositionY = 0;
            bool isValid = false;
            Char direction = ' ';
            try
            {
                string[] position = startPosition.Split(splitChar);
                Int32.TryParse(position[0], out iPositionX);
                Int32.TryParse(position[1], out iPositionY);
                direction = position[2].ToCharArray()[0];
                isValid = true;
            }
            catch (Exception ex) 
            {
                isValid = false;
            }
            return Tuple.Create(iPositionX, iPositionY, direction,isValid);
        }
        public bool ValidateDestinationPath(string destinationPath)
        {
            char[] path = destinationPath.ToCharArray();
            return path.Length > 0;
        }
    }
}
