using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fracturetest : MonoBehaviour
{
    private GameObject Plane;
    //private Trigger triggerScript;
    //public void TriggerDestruction(Vector3 triggerPosition, float magnitude);

    // Start is called before the first frame update
    void Start()
    {
        Plane = GameObject.FindWithTag("Finish");
        //triggerScript = Plane.GetComponent<Trigger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Plane)
        {
            //TriggerDestruction(gameObject.Position, 1.0f);
        }
    }
}
