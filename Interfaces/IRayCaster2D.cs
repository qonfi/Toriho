
using UnityEngine;

namespace Fiziks2D
{


    public interface IRayCaster2D 
    {
        bool Cast(Vector2 origin);
        GameObject LastDetectedObject { get; set; }
        GameObject ObjectBeingDetected { get; set; }
    }


}