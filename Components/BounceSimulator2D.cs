
using System;
using UnityEngine;

namespace Fiziks2D
{

    /// <summary>
    /// コンポーネント。接地判定のインターフェイスに依存している。
    /// </summary>
    public class BounceSimulator2D : MonoBehaviour, IMovementCalculator2D
    {

        private IGroundDetector2D detector;
        public Vector2 MovementPerFrame { get; set; }
        public float BouncePower { get; set; }
        public bool Bouncing { get; set; }


        private void Start()
        {
            // テスト用
            BouncePower = 4f;
            detector = GetComponent<IGroundDetector2D>();
        }


        private void Update()
        {
            if (Bouncing && detector.IsGrounding)
            {
                Bouncing = false;
                MovementPerFrame = Vector2.zero;
            }


            if (Bouncing == false && detector.IsGrounding)
            {
                Bouncing = true;
                MovementPerFrame = Vector2.up * BouncePower;
            }
            
        }
        
    }


}