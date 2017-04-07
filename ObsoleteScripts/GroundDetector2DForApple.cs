
using System;
using UnityEngine;

namespace Fiziks2D
{
    public class GroundDetector2DForApple : MonoBehaviour, IGroundDetector2D
    {
        public GameObject GroundBeingDetected { get; set; }
        public GameObject LastDetectedGround { get; set; }
        public bool IsGrounding { get; set; }
        
        private float Radius { get; set; }
        public IRayCaster2D Caster { get; set; }
        private bool Bouncing { get; set; }


        private void Start()
        {
            Radius = 0.5f;
            Caster = new OverlapDetectorCircle2D(Radius);
        }


        private void Update()
        {
            IsGrounding = Caster.Cast(transform.position);
            GroundBeingDetected = Caster.ObjectBeingDetected;
            LastDetectedGround = Caster.LastDetectedObject;
        }

    }
}