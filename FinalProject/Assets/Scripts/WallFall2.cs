using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFall2 : MonoBehaviour
{
    private GameObject TimerObject;
    private Timer2 timer_script;
    public Rigidbody segment1;
    public Rigidbody segment2;
    public Rigidbody segment3;
    public Rigidbody segment31;
    public Rigidbody segment4;
    public Rigidbody segment5;
    public Rigidbody segment6;

    // Start is called before the first frame update
    void Start()
    {
        TimerObject = GameObject.FindWithTag("WallTimer2");
        timer_script = TimerObject.GetComponent<Timer2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (segment1 != null && segment2 != null && segment3 != null && segment4 != null && segment5 != null && segment6 != null)
        {
            if (timer_script.currentTime >= .4f)
            {
                segment1.useGravity = true;
            }
            if (timer_script.currentTime >= .6f)
            {
                segment2.useGravity = true;
            }
            if (timer_script.currentTime >= .8f)
            {
                segment3.useGravity = true;
                segment31.useGravity = true;
            }
            if (timer_script.currentTime >= 1f)
            {
                segment4.useGravity = true;
            }
            if (timer_script.currentTime >= 1.2f)
            {
                segment5.useGravity = true;
            }
            if (timer_script.currentTime >= 1.4f)
            {
                segment6.useGravity = true;
            }
        }

    }
}
