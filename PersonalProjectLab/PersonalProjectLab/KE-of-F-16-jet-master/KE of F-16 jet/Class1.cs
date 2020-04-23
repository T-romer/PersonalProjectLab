using System;
using System.Collections.Generic;
using System.Text;

namespace KE_of_F_16_jet
{
    public class Class1
    {
        List<int> _velocity;
        public Class1(List<int> velocity)
        {
            _velocity = velocity;
        }

        public int VelocitiesAboveThreshold(int threshold)
        {
            int countofvel = 0;
            foreach (int velocity in _velocity)
            {
                if (velocity > threshold)
                {
                    countofvel += 1;
                }
            }
            return countofvel;
        }

        public int VelocitiesBelowThreshold(int threshold)
        {
            int velCount = 0;
            foreach (int velocity in _velocity)
            {
                if (velocity < threshold)
                {
                    velCount += 1;
                }
            }
            return velCount;
        }

        public int VelocitiesAtThreshold(int threshold)
        {
            int countVel = 0;
            foreach (int velocity in _velocity)
            {
                if (velocity == threshold)
                {
                    countVel += 1;
                }
            }
            return countVel;
        }
    }
}
