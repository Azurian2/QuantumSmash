using UnityEngine;
using System.Collections;

public class BouncingTitle : MonoBehaviour {

    public float value = 1f; //1 by default in inspector

    //This method is executed every frame
    private void Update()
    {
        //we store scale of this transform in temporary variable
        Vector3 temp = transform.localScale;

        //We change the values for this saved variable (not actual transform scale)
        temp.x = value;
        temp.y = value;
        temp.z = value;

        //We assign temp variable back to transform scale
        transform.localScale = temp;
    }
}

