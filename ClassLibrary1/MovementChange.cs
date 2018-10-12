using System;

namespace ClassLibrary1
{
    [Serializable]
    class MovementChange
    {
        public int Dx { get; set; }
        public int Dy { get; set; }

        public MovementChange(int dx, int dy)
        {
            Dx = dx;
            Dy = dy;
        }
    }
}