using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    int counter = 0;
    [SerializeField] int TimeToExpire;
    public GameObject destroyedVersion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == TimeToExpire )
        {
            Instantiate(destroyedVersion, transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(gameObject);
        }
    }
}
