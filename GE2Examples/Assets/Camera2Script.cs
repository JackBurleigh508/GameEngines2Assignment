using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Script : MonoBehaviour
{
    public GameObject badSpawn1;
    public GameObject badSpawn2;
    public GameObject badSpawn3;
    public GameObject badSpawn4;
    public GameObject badSpawn5;
    public GameObject badSpawn6;
    public GameObject badSpawn7;
    public GameObject badSpawn8;

    public GameObject Camera3;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "planet")
        {
            badSpawn1.SetActive(true);
            badSpawn2.SetActive(true);
            badSpawn3.SetActive(true);
            badSpawn4.SetActive(true);
            badSpawn5.SetActive(true);
            badSpawn6.SetActive(true);
            badSpawn7.SetActive(true);
            badSpawn8.SetActive(true);
        }

        if (other.tag == "bad")
        {
            Camera3.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
