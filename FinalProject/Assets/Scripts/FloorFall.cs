using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorFall : MonoBehaviour
{
    private GameObject TimerObject;
    private TimerFloor timer_script;
    public Rigidbody segment1;
    public Rigidbody segment2;
    public Rigidbody segment21;
    public Rigidbody segment22;
    public Rigidbody segment23;
    public Rigidbody segment3;
    public Rigidbody segment4;
    public Rigidbody segment41;
    public Rigidbody segment5;
    public Rigidbody segment51;
    public Rigidbody segment52;
    public Rigidbody segment53;
    public Rigidbody segment54;
    public Rigidbody segment55;
    public Rigidbody segment56;
    public Rigidbody segment57;
    public Rigidbody segment58;
    public Rigidbody segment59;
    public Rigidbody segment510;
    public Rigidbody segment511;
    public Rigidbody segment512;

    // Start is called before the first frame update
    void Start()
    {
        TimerObject = GameObject.FindWithTag("FloorTimer");
        timer_script = TimerObject.GetComponent<TimerFloor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (segment1 != null && segment2 != null && segment3 != null && segment4 != null && segment5 != null)
        {
            if (timer_script.currentTime >= .2f)
            {
                segment1.useGravity = true;
            }
            if (timer_script.currentTime >= .4f)
            {
                segment2.useGravity = true;
                segment21.useGravity = true;
                segment22.useGravity = true;
                segment23.useGravity = true;
            }
            if (timer_script.currentTime >= .6f)
            {
                segment3.useGravity = true;
            }
            if (timer_script.currentTime >= .8f)
            {
                segment4.useGravity = true;
                segment41.useGravity = true;
            }
            if (timer_script.currentTime >= 1f)
            {
                segment5.useGravity = true;
                segment51.useGravity = true;
                segment52.useGravity = true;
                segment53.useGravity = true;
                segment54.useGravity = true;
                segment55.useGravity = true;
                segment56.useGravity = true;
                segment57.useGravity = true;
                segment58.useGravity = true;
                segment59.useGravity = true;
                segment510.useGravity = true;
                segment511.useGravity = true;
                segment512.useGravity = true;
            }
        }

    }
}
