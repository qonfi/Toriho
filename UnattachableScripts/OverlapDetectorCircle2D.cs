
using System;
using UnityEngine;

namespace Fiziks2D
{


    public class OverlapDetectorCircle2D : IRayCaster2D
    {

        public GameObject LastDetectedObject { get; set; }
        public GameObject ObjectBeingDetected { get; set; }
        public float Radius { get; set; }


        public OverlapDetectorCircle2D(float radius = 0.5f)
        {
            this.Radius = radius;
        }


        public bool Cast(Vector2 origin)
        {
            Collider2D overlappedCollider;

            // 複数のオブジェクトと同時に接触した場合に問題を起こすかも。
            overlappedCollider = Physics2D.OverlapCircle(origin, Radius);


            if (overlappedCollider == null)
            {
                ObjectBeingDetected = null;
                return false;
            }
            else
            {
                GameObject detectedObject = overlappedCollider.gameObject;
                LastDetectedObject = detectedObject;
                ObjectBeingDetected = detectedObject;
                return true;
            }


        }


    }
}