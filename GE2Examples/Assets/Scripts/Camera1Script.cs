using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1Script : MonoBehaviour
{
    public GameObject FirstSpawn;
    public GameObject NextCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Next()
    {
        FirstSpawn.SetActive(true);
        NextCamera.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
