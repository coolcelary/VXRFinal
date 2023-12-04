using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testFall : MonoBehaviour
{
    int counter = 0;
    [SerializeField] int TimeToExpire;
    public Rigidbody segment1;
    public Rigidbody segment2;
    public Rigidbody segment3;
    public Rigidbody segment4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == TimeToExpire/4)
        {
            segment1.useGravity = true;
        }
        else if (counter == TimeToExpire / 3)
        {
            segment2.useGravity = true;
        }
        else if (counter == TimeToExpire / 2)
        {
            segment3.useGravity = true;
        }
        else if (counter == TimeToExpire / 1)
        {
            segment4.useGravity = true;
        }
    }
}
