
using UnityEngine;

namespace Fiziks2D
{


    public class GroundDetector2D : MonoBehaviour, IGroundDetector2D
    {

        /// <summary>
        /// オブジェクトが検出されない間は null を入れます。
        /// </summary>
        public GameObject GroundBeingDetected { get; set; }
        public GameObject LastDetectedGround { get; set; }
        public bool IsGrounding { get; set; }
        public IRayCaster2D Caster { get; set; }

        // やや応急的。落下物が一度地面に当たったらこれを falseにする。
        public bool IsActive { get; set; }
        public int Mask { get; set; }

        private void Start()
        {
            IsActive = true;
            Mask = LayerMask.GetMask("Ground");
            Caster = new CircleCaster2D(Mask);
        }


        private void Update()
        {
            if (IsActive == false) { return; }

            // ちょっと無駄がある。
            IsGrounding = Caster.Cast(this.transform.position);
            GroundBeingDetected = Caster.ObjectBeingDetected;
            LastDetectedGround = Caster.LastDetectedObject;
        }

        

    }


}