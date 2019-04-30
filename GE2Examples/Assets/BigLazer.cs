using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigLazer : MonoBehaviour
{
    public GameObject Laser;
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Laser.SetActive(true);
            Text.SetActive(false);
        }
    }
}
