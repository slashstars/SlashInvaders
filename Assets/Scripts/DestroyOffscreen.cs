using UnityEngine;
using System.Collections;

public class DestroyOffscreen : MonoBehaviour {

    // Update is called once per frame
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    
}
