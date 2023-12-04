using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallwithtimer7 : MonoBehaviour
{
    private GameObject TimerObject;
    private Timer timer_script;
    public Rigidbody segment1;
    public Rigidbody segment2;
    public Rigidbody segment3;
    public Rigidbody segment4;
    public Rigidbody segment5;
    public Rigidbody segment6;
    public Rigidbody segment7;

    // Start is called before the first frame update
    void Start()
    {
        TimerObject = GameObject.FindWithTag("Timer");
        timer_script = TimerObject.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer_script.currentTime >= 10f && segment1 !=null)
        {
            segment1.useGravity = true;
        }
        if (timer_script.currentTime >= 10.2f)
        {
            segment2.useGravity = true;
        }
        if (timer_script.currentTime >= 10.4f)
        {
            segment3.useGravity = true;
        }
        if (timer_script.currentTime >= 10.6f)
        {
            segment4.useGravity = true;
        }
        if (timer_script.currentTime >= 10.8f)
        {
            segment5.useGravity = true;
        }
        if (timer_script.currentTime >= 11f)
        {
            segment6.useGravity = true;
        }
        if (timer_script.currentTime >= 11.2f)
        {
            segment7.useGravity = true;
        }
    }
}
