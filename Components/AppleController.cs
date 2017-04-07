
using System;
using UnityEngine;

namespace Fiziks2D
{


    public class AppleController : MonoBehaviour, IMovementCalculator2D
    {
        public IGroundDetector2D Detector { get; set; }
        public Vector2 MovementPerFrame { get; set; }

        private void Start()
        {
            Detector = GetComponent<IGroundDetector2D>();
            Detector.Caster = new OverlapDetectorCircle2D(0.5f);

        }
        
    }


}