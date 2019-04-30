using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1Script : MonoBehaviour
{
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;
    public GameObject Spawn5;
    public GameObject Spawn6;
    public GameObject NextCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        Spawn1.SetActive(true);
        Spawn2.SetActive(true);
        Spawn3.SetActive(true);
        Spawn4.SetActive(true);
        Spawn5.SetActive(true);
        Spawn6.SetActive(true);
        NextCamera.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
