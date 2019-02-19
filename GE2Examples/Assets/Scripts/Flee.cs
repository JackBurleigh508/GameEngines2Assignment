using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if (targetGameObject != null)
        {
            target = targetGameObject.transform.position;
        }
    }

    public override Vector3 Calculate()
    {
        return boid.FleeForce(target);
    }
}
