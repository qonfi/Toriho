//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // (needs NetworkBehaviour)
//using UnityEngine.UI;
using System;
using UnityEngine;

namespace Fiziks2D
{


    public class CircleCaster2D : IRayCaster2D
    {
        public float Radius { get; private set; }
        public float RayLength { get; private set; }
        public int Mask { get; private set; }

        public GameObject LastDetectedObject { get; set; }
        public GameObject ObjectBeingDetected { get; set; }


        public CircleCaster2D(int groundLayer, float _radius = 0.5f, float _rayLength = 2f)
        {
            Radius = 0.5f;
            RayLength = 1f;
            Mask = (1 << groundLayer);
        }


        public bool Cast(Vector2 origin)
        {
            RaycastHit2D hit =
                Physics2D.CircleCast(origin, Radius, Vector2.down, RayLength, Mask);


            if ( hit.collider != null)
            {
                GameObject detectedObject = hit.collider.gameObject;
                LastDetectedObject = detectedObject;
                ObjectBeingDetected = detectedObject;
                return true;
            }

            ObjectBeingDetected = null;
            return false;
        }
    }



}