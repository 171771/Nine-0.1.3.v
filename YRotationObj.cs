using UnityEngine;
using System.Collections;

public class YRotationObj : MonoBehaviour
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

        if (OVRInput.Get(OVRInput.Button.SecondaryShoulder))
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                if (hitInfo.collider.tag == "YMirror")
                {
                    Debug.Log(hitInfo.collider.tag);
                    RotationMirror = hitInfo.transform.gameObject;                    
                    RotationMirror.transform.Rotate(new Vector3(-Input.GetAxis("Oculus_GearVR_LIndexTrigger"), 0, 0));
                }
            }
            else if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            {
                if (hitInfo.collider.tag == "YMirror")
                {
                    Debug.Log(hitInfo.collider.tag);
                    RotationMirror = hitInfo.transform.gameObject;                    
                     RotationMirror.transform.Rotate(new Vector3(-Input.GetAxis("Oculus_GearVR_RIndexTrigger"), 0, 0));
                    
                }
            }
        }
    }
}