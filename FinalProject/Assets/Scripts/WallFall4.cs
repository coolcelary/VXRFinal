using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFall4 : MonoBehaviour
{
    private GameObject TimerObject;
    private Timer4 timer_script;
    public Rigidbody segment1;
    public Rigidbody segment2;
    public Rigidbody segment21;
    public Rigidbody segment22;
    public Rigidbody segment23;
    public Rigidbody segment3;
    public Rigidbody segment4;

    // Start is called before the first frame update
    void Start()
    {
        TimerObject = GameObject.FindWithTag("WallTimer4");
        timer_script = TimerObject.GetComponent<Timer4>();
    }

    // Update is called once per frame
    void Update()
    {
        if (segment1 != null && segment2 != null && segment3 != null && segment4 != null)
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
            }
        }

    }
}
