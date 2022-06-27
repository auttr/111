using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS : MonoBehaviour
{
    public Camera cam;
    public SphereCollider sc;
    public CapsuleCollider cc;
    public BoxCollider bb;
    public Transform t;
    public Transform a;
    public Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {

        print("²`«×:" + cam.depth);
        print("¥b®|:" + sc.radius);
        cam.backgroundColor = Color.red;
        cc.transform.localScale = new Vector3(3, 2, 1);
       
    }
    // Update is called once per frame
    void Update()
    {
        bb.transform.LookAt(t);
        bb.transform.Translate(new Vector3(1,0,0));
        rb.velocity = new Vector3(0, 10, 0);

    }
}
