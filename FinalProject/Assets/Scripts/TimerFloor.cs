using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerFloor : MonoBehaviour
{
    public float currentTime;

    void Update()
    {
        currentTime += Time.deltaTime;
    }
}
