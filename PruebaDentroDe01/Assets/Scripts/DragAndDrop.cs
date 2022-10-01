using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DragAndDrop : MonoBehaviour
{
    private float zcoordOfMouse;
    //private float xcoordOfMouse;
    private Vector3 mouse_offset;

    private void OnMouseDown()
    {
        zcoordOfMouse = Camera.main.WorldToScreenPoint(transform.position).z;
        //xcoordOfMouse = Camera.main.WorldToScreenPoint(transform.position).x;
        mouse_offset = transform.position - mouseWorldPos();
    }

    private void OnMouseDrag()
    {
        transform.position = mouseWorldPos() + mouse_offset;
    }

    private Vector3 mouseWorldPos()
    {
        Vector3 mpos = Input.mousePosition;
        mpos.z = zcoordOfMouse;
        //mpos.x = xcoordOfMouse;
        return Camera.main.ScreenToWorldPoint(mpos);
    }

}
