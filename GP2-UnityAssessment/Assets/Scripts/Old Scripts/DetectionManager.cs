using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionManager : MonoBehaviour
{
    public HybridController HC;

    public bool Detected;

    void Update()
    {
        if(HC.isVisible == false)
        {
            Detected = false;
        }
    }
}
