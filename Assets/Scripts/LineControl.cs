using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineControl : MonoBehaviour
{
    public Vector3 objectPos;
    public void OnMouseDown()
    {
        objectPos = Camera.main.WorldToScreenPoint(transform.position);

        if (CompareTag("Cizgi"))
        {
            Destroy(gameObject);
        }
    }
    void OnMouseDrag()
    {
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objectPos.z);
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }

}
