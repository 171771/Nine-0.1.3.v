using UnityEngine;
using System.Collections;
public class CameraChange : MonoBehaviour
{
    public GameObject obj;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    private bool camActive;
    private Ray ray;
    private RaycastHit hitInfo;
    private bool hit;

    void Start()
    {
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = false;
        camActive = false;
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if (hitInfo.collider.tag == "XMirror")
            {
                Debug.Log("seibeen");
                obj.SetActive(false);
                cam1.enabled = true;
                camActive = true;
            }
            else if (hitInfo.collider.tag == "YMirror")
            {
                Debug.Log("seibeen");
                obj.SetActive(false);
                cam2.enabled = true;
                camActive = true;
            }
            else if (hitInfo.collider.tag == "XYMirror")
            {
                Debug.Log("seibeen");
                obj.SetActive(false);
                cam3.enabled = true;
                camActive = true;
            }
        }
        else if(camActive == true)
        {
            if (OVRInput.Get(OVRInput.Button.Two))
            {
                Debug.Log("seoneem");
            }
        }
    }
}
