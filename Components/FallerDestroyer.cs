
using UnityEngine;

namespace Fiziks2D
{

    /// <summary>
    /// 落下物が地面に接触してバウンドしたら、それ以上は接地判定をさせない。あまりスマートには書けなかった。
    /// </summary>
    public class FallerDestroyer : MonoBehaviour
    {

        private BounceSimulator2D bouncer;
        private GroundDetector2D detector;
        private string GroundTag { get; set; }



        private void Start()
        {
            detector = GetComponent<GroundDetector2D>();
            bouncer = GetComponent<BounceSimulator2D>();
            GroundTag = "Ground";
        }


        private void Update()
        {
            if (detector.LastDetectedGround != null &&
                detector.LastDetectedGround.tag == GroundTag &&
                bouncer.Bouncing == true ) 
            {
                detector.IsGrounding = false;
                detector.IsActive = false;
                Destroy(this.gameObject, 3f);
            }
        }


    }


}