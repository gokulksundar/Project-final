using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jupiter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(this.transform.parent.position, this.transform.parent.up, 65 * Time.deltaTime);
    }
}
