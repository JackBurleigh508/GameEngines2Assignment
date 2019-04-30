using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazers : MonoBehaviour
{
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fire());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fire()
    {
        yield return new WaitForSeconds(20.0f);
        particle.SetActive(true);
        yield return new WaitForSeconds(10.0f);
        particle.SetActive(false);
    }

    
}
