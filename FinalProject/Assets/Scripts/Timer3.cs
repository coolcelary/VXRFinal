using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer3 : MonoBehaviour
{
    public float currentTime;

    void Update()
    {
        currentTime += Time.deltaTime;
    }
}
