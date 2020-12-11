using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    private bool isGrabbed;
    private Camera mainCam;
    private Rigidbody2D ObjectRigidbody;

    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        isGrabbed = false;
        ObjectRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        if (isGrabbed)
        {
            transform.position = new Vector2 (mousePos.x, mousePos.y);
        }
    }

    private void OnMouseDown()
    {
        isGrabbed = true;
        ObjectRigidbody.gravityScale = 0;
    }

    private void OnMouseUp()
    {
        isGrabbed = false;
        ObjectRigidbody.gravityScale = 1;
    }
}
