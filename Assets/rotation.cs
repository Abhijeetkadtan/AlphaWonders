using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //float degreesPerSecond = 20;
    private void Update()
    {
    transform.Rotate(0f,10* Time.deltaTime,0f ,Space.Self);
    }
}
