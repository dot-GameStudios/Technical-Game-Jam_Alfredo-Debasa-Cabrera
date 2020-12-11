using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfScript : MonoBehaviour
{
    public string newHolderPosNode;
    public Vector2 HolderMoveSpeed;

    private DataVector2 newHolderPos;
    private bool holderCanMove;

    public Data DataContainer;


    // Start is called before the first frame update
    void Start()
    {
        //holderCanMove = false;
        //if (newHolderPosNode != null)
        //{
        //    newHolderPos = DataContainer.GetVector2(newHolderPosNode);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //if (holderCanMove)
        //{

        //    if (transform.position.y > newHolderPos.Value.y)
        //    {
        //        transform.position += new Vector3(HolderMoveSpeed.x, HolderMoveSpeed.y, transform.position.z);
        //    }
        //    else
        //    {
        //        holderCanMove = false;
        //    }

        //}
    }

    //public void Balance()
    //{
    //    holderCanMove = true;
    //}
}
