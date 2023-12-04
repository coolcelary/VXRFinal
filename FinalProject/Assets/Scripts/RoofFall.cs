using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofFall : MonoBehaviour
{
    private GameObject TimerObject;
    private TimerRoof timer_script;
    public Rigidbody segment1;
    public Rigidbody segment11;
    public Rigidbody segment12;
    public Rigidbody segment13;
    public Rigidbody segment2;
    public Rigidbody segment3;
    public Rigidbody segment4;
    public Rigidbody segment41;
    public Rigidbody segment5;
    public GameObject segment5obj;
    public Rigidbody segment6;
    public Rigidbody segment61;
    public Rigidbody segment62;
    public Rigidbody segment7;
    public Rigidbody segmentextra;

    // Start is called before the first frame update
    void Start()
    {
        TimerObject = GameObject.FindWithTag("RoofTimer");
        timer_script = TimerObject.GetComponent<TimerRoof>();
    }

    // Update is called once per frame
    void Update()
    {
        if (segment1 != null && segment2 != null && segment3 != null && segment4 != null && segment5 != null && segment6 != null && segment7 != null && segment11 != null && segment12 != null && segment13 != null)
        {
            if (timer_script.currentTime >= .5f)
            {
                segment1.useGravity = true;
                segment11.useGravity = true;
                segment12.useGravity = true;
                segment13.useGravity = true;
            }
            if (timer_script.currentTime >= .7f)
            {
                segment2.useGravity = true;
            }
            if (timer_script.currentTime >= .9f)
            {
                segment3.useGravity = true;
            }
            if (timer_script.currentTime >= 1.1f)
            {
                segment4.useGravity = true;
                segment41.useGravity = true;
            }
            if (timer_script.currentTime >= 1.3f)
            {
                segment5obj.SetActive(false);
            }
            if (timer_script.currentTime >= 1.5f)
            {
                segment6.useGravity = true;
                segment61.useGravity = true;
                segment62.useGravity = true;
            }
            if (timer_script.currentTime >= 1.7f)
            {
                segment7.useGravity = true;
            }
            if (timer_script.currentTime >= 1f)
            {
                segmentextra.useGravity = true;
            }
        }

    }
}
