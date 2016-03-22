using UnityEngine;
using System.Collections;

public class XYRotationObj : MonoBehaviour
{

    private Ray ray;
    private RaycastHit hitInfo;
    public float turnSpeed = 50f;
    public GameObject RotationMirror;

    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
        hitInfo = new RaycastHit();

        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (OVRInput.Get(OVRInput.Button.PrimaryShoulder))
        {
            // rotation up
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                if (hitInfo.collider.tag == "XYMirror")
                {
                    Debug.Log(hitInfo.collider.name);
                    RotationMirror = hitInfo.transform.gameObject;
                    RotationMirror.transform.Rotate(new Vector3(0, -Input.GetAxis("Oculus_GearVR_LIndexTrigger"), 0));
                }
            }
            // rotation down
            else if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            {
                if (hitInfo.collider.tag == "XYMirror")
                {
                    Debug.Log("hihihih");
                    RotationMirror = hitInfo.transform.gameObject;
                    RotationMirror.transform.Rotate(new Vector3(0, -Input.GetAxis("Oculus_GearVR_RIndexTrigger"), 0));
                }
            }
        }

        if (OVRInput.Get(OVRInput.Button.SecondaryShoulder))
        {
            // rotation up
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                if (hitInfo.collider.tag == "XYMirror")
                {
                    Debug.Log(hitInfo.collider.name);
                    RotationMirror = hitInfo.transform.gameObject;
                    RotationMirror.transform.Rotate(new Vector3(-Input.GetAxis("Oculus_GearVR_LIndexTrigger"), 0, 0));
                }
            }
            // rotation down
            else if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            {
                if (hitInfo.collider.tag == "XYMirror")
                {
                    Debug.Log("hihihxyajdkaldfa");
                    RotationMirror = hitInfo.transform.gameObject;
                    RotationMirror.transform.Rotate(new Vector3(-Input.GetAxis("Oculus_GearVR_RIndexTrigger"), 0, 0));
                }
            }
        }

    }
}