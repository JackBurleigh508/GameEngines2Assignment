using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{
    public GameObject Camera3;
    public GameObject Camera4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire()
    {
        Camera4.SetActive(true);
        Camera3.SetActive(false);
    }
}
