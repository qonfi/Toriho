
using System;
using UnityEngine;


namespace Fiziks2D
{


    public class PlatformWalk2D : MonoBehaviour, IMovementCalculator2D
    {
        public Vector2 MovementPerFrame { get; set; }
        public float WalkSpeed { get; set; }
        public float MaxSpeed { get; set; }


        private void Start()
        {
            // テスト用
            WalkSpeed = 0.6f;
            MaxSpeed = 3.6f;
        }


        private void Update()
        {

            if (Input.GetMouseButton(0))
            {
                MovementPerFrame += Vector2.right * -WalkSpeed;
            }


            if (Input.GetMouseButton(1))
            {
                MovementPerFrame += Vector2.right * WalkSpeed;
            }


            // 値を任意の範囲に収める。
            float f = Mathf.Min(MaxSpeed, Math.Max(-MaxSpeed, MovementPerFrame.x));
            MovementPerFrame = Vector2.right * f;


            if(Input.GetMouseButton(0) == false &&
                Input.GetMouseButton(1) == false)
            {
                MovementPerFrame *= 0.9f;
            }
            
        }
    }


}