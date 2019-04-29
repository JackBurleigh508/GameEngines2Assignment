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
            GameObject fighter = Instantiate(fighters);
            fighter.transform.parent = transform;
            fighter.transform.localPosition = new Vector3(0 + Random.Range(-50, 50), 0 + Random.Range(-50, 50), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
