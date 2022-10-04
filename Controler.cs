using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    float speed = 0.5f; 
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
     bool moving = true;
    }

    // Update is called once per frame
    void Update()
    {
     switch(i)
     {
        case 1:
            transform.position = transform.position + new Vector3(4,0);
            i=2;
            break; 
        case 2:
            transform.position = transform.position + new Vector3(0,4);
            i =3;
            break;
        case 3:
            transform.position = transform.position + new Vector3(-4,0);
            i=4;
            break;
        case 4:
            transform.position = transform.position + new Vector3(0,-4);
            i=1;
            break;
      }
        
      }
        
    
    
}
