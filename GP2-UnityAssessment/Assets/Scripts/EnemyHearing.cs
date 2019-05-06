using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHearing : MonoBehaviour
{
    public GameObject Player;
    public HybridController HC;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject == Player)
        {
            HC.isAudible = true;
        }
    }
}
