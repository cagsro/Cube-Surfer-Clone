using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
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
        if (other.gameObject.tag=="Engel")
        {
            this.transform.parent=null;
            this.tag="Untagged";
            GetComponent<BoxCollider>().enabled=false;
            other.gameObject.GetComponent<BoxCollider>().enabled=false;
            Yontem2.instance.newPos--;
            if (Yontem2.instance.newPos<0)
            {
                return;
            } 
        }
    }
}
