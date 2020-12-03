using System;

namespace DartsGame
{
    public static class Darts
    {
        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            int result;

            if (Math.Abs(x) + Math.Abs(y) <= 1)
            {
                result = 10;
            }
            else if (Math.Abs(x) + Math.Abs(y) <= 5)
            {
                result = 5;
            }
            else if (Math.Abs(x) + Math.Abs(y) <= 10)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}
