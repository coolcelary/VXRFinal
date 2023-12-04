using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalFall : MonoBehaviour
{
    private GameObject TimerObject;
    private FinalTimer timer_script;
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
        TimerObject = GameObject.FindWithTag("FinalTimer");
        timer_script = TimerObject.GetComponent<FinalTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (segment1 != null && segment2 != null && segment3 != null && segment4 != null && segment5)
        {
            if (timer_script.currentTime >= .2f)
            {
                segment1.useGravity = true;
                segment2.useGravity = true;
                segment3.useGravity = true;
                segment4.useGravity = true;
                segment5.useGravity = true;
                segment6.useGravity = true;
                segment7.useGravity = true;
            }
        }
    }
}
