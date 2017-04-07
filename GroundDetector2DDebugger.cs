
using UnityEngine;
using Fiziks2D;
using System;

namespace IMGUI
{


    public class GroundDetector2DDebugger : MonoBehaviour, IDebuggerRow
    {
        [SerializeField] private GroundDetector2D detector;
        public bool Visible { get; set; }
        

        public void Display()
        {
            if (detector == null)
            {
                GUILayout.Box("GroundDetector2D == null");
                return;
            }

            GUILayout.Box("IsGrounding\n" + detector.IsGrounding);
            GUILayout.Box("___LastDetectedGround___\n" + detector.LastDetectedGround + "\n" +
                "__GroundBeingDetected__\n" + detector.GroundBeingDetected);
        }
    }


}