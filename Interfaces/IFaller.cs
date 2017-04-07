
using UnityEngine;


namespace Fiziks2D
{


    public interface IFaller
    {
        IGroundDetector2D Detector { get; set; }
        void OnCollidesWithGround();
        void OnCollidesWithAthlete();
    }


}