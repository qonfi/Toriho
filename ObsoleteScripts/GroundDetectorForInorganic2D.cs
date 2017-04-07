
using System;
using UnityEngine;

namespace Fiziks2D
{

    // 名前長過ぎ
    public class GroundDetectorForInorganic2D : MonoBehaviour, IGroundDetector2D
    {
        public GameObject GroundBeingDetected { get; set; }
        public GameObject LastDetectedGround { get; set; }
        //public Vector2 MovementPerFrame { get; set; }
        public bool IsGrounding { get; set; }
        public IRayCaster2D Caster { get; set; }

        private float Radius { get; set; }


        private void Start()
        {
            // テスト用
            Radius = 0.5f;
        }

        private void Update()
        {
            Collider2D other;
            other = Physics2D.OverlapCircle(transform.position, Radius);

            Debug.Log(other);
        }
    }
}