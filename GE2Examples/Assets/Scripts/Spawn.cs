using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject fighters;
    public int numberOfFighters;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= numberOfFighters; i++)
        {
            Instantiate(fighters, this.transform.parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
