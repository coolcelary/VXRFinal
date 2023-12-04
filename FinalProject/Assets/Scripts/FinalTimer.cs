using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTimer : MonoBehaviour
{
    public float currentTime;

    void Update()
    {
        currentTime += Time.deltaTime;
    }
}
