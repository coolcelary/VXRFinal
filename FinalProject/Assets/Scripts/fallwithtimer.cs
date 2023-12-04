using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallwithtimer : MonoBehaviour
{
    private GameObject TimerObject;
    private Timer timer_script;
    public Rigidbody segment1;
    public Rigidbody segment2;
    public Rigidbody segment3;
    public Rigidbody segment4;

    // Start is called before the first frame update
    void Start()
    {
        TimerObject = GameObject.FindWithTag("Timer");
        timer_script = TimerObject.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (segment1 != null && segment2 != null && segment3 != null && segment4 != null) 
        { 
            if(timer_script.currentTime >= 10f)
            {
                segment1.useGravity = true;  
            }
            if (timer_script.currentTime >= 10.2f)
            {
                segment2.useGravity = true;
            }
            if(timer_script.currentTime >= 10.4f)
            {
                segment3.useGravity = true;
            }
            if(timer_script.currentTime >= 10.6f)
            {
                segment4.useGravity = true;
            }
        }
        
    }
}
