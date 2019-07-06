using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    Transform t;
    // Start is called before the first frame update
    void Start()
    {
       t = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        t.position = new Vector3(this.t.position.x + 0.05f, this.t.position.y, this.t.position.z);
        Debug.Log("working!!");
    }
}
