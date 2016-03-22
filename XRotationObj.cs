using UnityEngine;
using System.Collections;

public class XRotationObj : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hitInfo;
    public float turnSpeed = 5.0f;
    public GameObject RotationMirror;
    public float angle;

    void Update()
    {
        hitInfo = new RaycastHit();

        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (OVRInput.Get(OVRInput.Button.PrimaryShoulder))
        {
            // rotation left
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                if (hitInfo.collider.tag == "XMirror")
                {
                    RotationMirror = hitInfo.transform.gameObject;
                    if (RotationMirror.transform.rotation.y > -0.5f)
                        RotationMirror.transform.Rotate(new Vector3(0, Input.GetAxis("Oculus_GearVR_LIndexTrigger"), 0));
                    Debug.Log("x rotation = " + RotationMirror.transform.rotation.x);
                    Debug.Log("y rotation = " + RotationMirror.transform.rotation.y);
                }
            }
            // rotation right
            else if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            {
                if (hitInfo.collider.tag == "XMirror")
                {
                    RotationMirror = hitInfo.transform.gameObject;
                    if (RotationMirror.transform.rotation.y < 0.5f)
                        RotationMirror.transform.Rotate(new Vector3(0, Input.GetAxis("Oculus_GearVR_RIndexTrigger"), 0));
                    Debug.Log("x rotation = " + RotationMirror.transform.rotation.x);
                    Debug.Log("y rotation = " + RotationMirror.transform.rotation.y);
                }
            }
        }
    }
}