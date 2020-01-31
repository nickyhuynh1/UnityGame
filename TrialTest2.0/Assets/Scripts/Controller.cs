using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Transform rtouch;
    public Transform ltouch;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        rtouch.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        ltouch.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
    }
}
