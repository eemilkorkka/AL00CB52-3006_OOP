using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_And_Overriding_EX3
{
    public class Window
    {
        public int posX, posY, sizeX, sizeY;
        public int maxSizeX, maxSizeY;
        public int stepSize;

        public Window()
        {
            posX = 0;
            posY = 0;

            sizeX = 0;
            sizeY = 0;

            maxSizeX = 0;
            maxSizeY = 0;

            stepSize = 0;
        }

        public Window(int _maxSizeX, int _maxSizeY) : this()
        {
            if (_maxSizeX < 0)
                _maxSizeX = 0;

            if (_maxSizeX < 0)
                _maxSizeY = 0;

            maxSizeX = _maxSizeX;
            maxSizeY = _maxSizeY;

            sizeX = maxSizeX;
            sizeY = maxSizeY;

            stepSize = 10;
        }

        public Window(int _maxSizeX, int _maxSizeY, int _sizeX, int _sizeY) : this(_maxSizeX, _maxSizeY)
        {
            if (_sizeX < 0)
                _sizeX = 0;

            if (_sizeY < 0)
                _sizeY = 0;

            int windowSize = _sizeX + _sizeY;
            int maxSize = maxSizeX + maxSizeY;

            if (windowSize > maxSize - windowSize)
            {
                _sizeX = maxSizeX;
                _sizeY = maxSizeY;

                return;
            }

            sizeX = _sizeX;
            sizeY = _sizeY;
        }

        public Window(int _maxSizeX, int _maxSizeY, int _sizeX, int _sizeY, int _posX, int _posY)
            : this(_maxSizeX, _maxSizeY, _sizeX, _sizeY)
        {
            if (_posX < 0)
                _posX = 0;

            if (_posY < 0)
                _posY = 0;

            posX = _posX;
            posY = _posY;
        }

        public Window(int _maxSizeX, int _maxSizeY, int _sizeX, int _sizeY, int _posX, int _posY, int _stepSize)
            : this(_maxSizeX, _maxSizeY, _sizeX, _sizeY, _posX, _posY)
        {
            if (_stepSize < 0)
                _stepSize = 0;

            stepSize = _stepSize;
        }

        public void MoveTo(int x, int y)
        {
            if (x < 0)
                x = 0;

            if (y < 0)
                y = 0;

            posX = x;
            posY = y;
        }

        public void MoveToCorner()
        {
            posX = 0;
            posY = 0;
        }

        public void MoveStepUp()
        {
            posX -= stepSize;
        }

        public void MoveStepDown()
        {
            posX += stepSize;
        }

        public void MoveStepLeft()
        {
            posY -= stepSize;
        }

        public void MoveStepRight()
        {
            posY += stepSize;
        }

        public void Minimize()
        {
            sizeX = 0;
            sizeY = 0;
        }

        public void Maximize()
        {
            sizeX = maxSizeX;
            sizeY = maxSizeY;
        }

        public void IncSize()
        {
            sizeX += stepSize;
            sizeY += stepSize;
        }

        public void DecSize()
        {
            sizeX -= stepSize;
            sizeY -= stepSize;
        }
    }
}
