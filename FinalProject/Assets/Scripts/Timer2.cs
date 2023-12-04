using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer2 : MonoBehaviour
{
    public float currentTime;

    void Update()
    {
        currentTime += Time.deltaTime;
    }
}
