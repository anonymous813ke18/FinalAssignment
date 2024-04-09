using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class CalculateMET
    {
        public float getMET(String activityName, String workoutIntensity)
        {
            float MET = 0;
            if (activityName == "Walking")
            {
                if (workoutIntensity == "Casual")
                {
                    MET = 2.0f;
                }
                else if (workoutIntensity == "Brisk")
                {
                    MET = 3.5f;
                }
                else
                {
                    MET = 5.0f;
                }
            }

            else if (activityName == "Swimming")
            {
                if (workoutIntensity == "Leisurely")
                {
                    MET = 5.8f;
                }
                else if (workoutIntensity == "Moderate")
                {
                    MET = 7.0f;
                }
                else
                {
                    MET = 9.8f;
                }
            }

            else if (activityName == "Running")
            {
                if (workoutIntensity == "Slow")
                {
                    MET = 9.8f;
                }
                else if (workoutIntensity == "Moderate")
                {
                    MET = 12.8f;
                }
                else
                {
                    MET = 15.0f;
                }
            }

            else if (activityName == "Cycling")
            {
                if (workoutIntensity == "Slow")
                {
                    MET = 4.0f;
                }
                else if (workoutIntensity == "Medium")
                {
                    MET = 8.0f;
                }
                else
                {
                    MET = 12.0f;
                }
            }

            else if (activityName == "Jump Rope")
                MET = 12.0f;

            else if (activityName == "Yoga")
            {
                if (workoutIntensity == "Hatha")
                {
                    MET = 2.5f;
                }
                else if (workoutIntensity == "Power")
                {
                    MET = 4.0f;
                }
                else
                {
                    MET = 5.0f;
                }
            }

            return MET;
        }
    }
}
