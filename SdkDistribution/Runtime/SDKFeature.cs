using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SdkDistribution
{
    public class SDKFeature : MonoBehaviour
    {
        public float dynamicCount = 0.1f;
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Dynamic Count: " + dynamicCount);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}


