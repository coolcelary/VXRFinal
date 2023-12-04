using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerRoof : MonoBehaviour
{
    public float currentTime;

    void Update()
    {
        currentTime += Time.deltaTime;
    }
}
