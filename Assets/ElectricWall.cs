using UnityEngine;
using System.Collections.Generic;

// Starting in 2 seconds.
// a projectile will be launched every 0.3 seconds

public class ElectricWall : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("OnAndOff", 2.0f, 3.0f);
    }

    void OnAndOff()
    {
        int chance = Random.Range(0, 5);
        Debug.Log(chance);
        for (int i = 0; i < transform.childCount; ++i)
        {
            if (chance == 1)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
            
        }
    }
}
