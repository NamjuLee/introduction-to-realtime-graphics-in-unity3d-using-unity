using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Rhino;

public class Box : MonoBehaviour
{
    Transform t;
    Rhino.Geometry.Point3d p0;
    Rhino.Geometry.Point3d p1;
    Rhino.Geometry.Line ln;
    float time;
    // Start is called before the first frame update
    void Start()
    {

      p0  = new Rhino.Geometry.Point3d(0,0,0);
      p1  = new Rhino.Geometry.Point3d(20,20,0);

    Vector3 v = new Vector3(0,0,0);
       t = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        t.position = new Vector3(this.t.position.x + 0.05f, this.t.position.y, this.t.position.z);
        Debug.Log("working!!");
    
        Debug.DrawLine(new Vector3((float)p0.X, (float)p0.Y, (float)p0.Z), new Vector3((float)p1.X, (float)p1.Y, (float)p1.Z) );

        float v = Mathf.Sin(this.time);

        p0.X = v * 10;

        time+= 0.01f;
    }
}
