
using UnityEngine;

namespace Fiziks2D
{


    public interface IGroundDetector2D
    {
        GameObject LastDetectedGround { get; set; }
        GameObject GroundBeingDetected { get; set; }
        IRayCaster2D Caster { get; set; }
        bool IsGrounding { get; set; }
    }



}