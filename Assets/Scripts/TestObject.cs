﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestObject : MonoBehaviour
{
    private bool isGrabbed;
    private bool touchedGround;
    private Camera mainCam;
    private Rigidbody2D ObjectRigidbody;


    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        touchedGround = false;
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
            transform.position = new Vector2(mousePos.x, mousePos.y);
        }
    }

    private void OnMouseDown()
    {
        if (!touchedGround)
        {
            isGrabbed = true;
            ObjectRigidbody.gravityScale = 0;

        }
    }

    private void OnMouseUp()
    {
        if (!touchedGround)
        {
            isGrabbed = false;
            ObjectRigidbody.gravityScale = 1;

        }
    }

    public void ChangeRigidBodyType(string newType)
    {
        if (newType == "Dynamic")
        {
            ObjectRigidbody.bodyType = RigidbodyType2D.Dynamic;
        }
        else if (newType == "Kinematic")
        {
            ObjectRigidbody.bodyType = RigidbodyType2D.Kinematic;
        }
        else if (newType == "Static")
        {
            ObjectRigidbody.bodyType = RigidbodyType2D.Static;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Environment")
        {
            touchedGround = true;
        }
    }
}
