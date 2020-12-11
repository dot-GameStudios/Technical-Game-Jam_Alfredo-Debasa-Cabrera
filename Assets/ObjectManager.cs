using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObjectManager : MonoBehaviour
{
    public GameObject Shelf;
    public GameObject[] PlatformHolders;
    public GameObject[] RigidbodyObjects;
    public Data DataContainer;

    private DataVector2 newHolderPos;
    private bool holderCanMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
