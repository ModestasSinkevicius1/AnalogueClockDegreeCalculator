using System;

namespace AnalogueClockDegreeCalculator
{
    class ClockAnalogueDegreeSolver
    {
        private int startHour;
        private int endHour;
        private int startMin;
        private int endMin;

        public ClockAnalogueDegreeSolver(int startHour, int endHour, int startMin, int endMin)
        {
            this.startHour = startHour;
            this.endHour = endHour;
            this.startMin = startMin;
            this.endMin = endMin;
        }

        /*calculates endHour and startHour to get difference between hours.
          We know 12 hours in analogue clock creates 360 degree therefore we 
          can use proportion trick to get degrees between hours.
        */
        public int CalculateHourAngle()
        {
            int hour = endHour - startHour;

            return 360*hour/12;
        }

       /*calculates endMin and startMin to get difference between mins. 60 is 1 hour that means
         60 min times 12 hours would give us 720 mins and that creates full loop of the clock. 
         In the we can use proportion trick to get degrees between mins.
       */
        public int CalculateMinAngle()
        {
            int min = endMin - startMin;

            return 360*min/720;
        }
    }
}
