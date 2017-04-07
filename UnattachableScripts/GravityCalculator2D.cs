
using UnityEngine;

namespace Fiziks2D
{


    public class GravityCalculator2D 
    {
        public float GravityAccel { get; set; }
        
        public GravityCalculator2D()
        {
            GravityAccel = 10f;
        }
       
        // 問題は無いけど...単純過ぎ?
        public float CalcMovement(float floatingTime)
        {
            return floatingTime * GravityAccel;
        }
    }


}