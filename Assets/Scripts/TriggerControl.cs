using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag.Equals("Cube1")) //Kup yem'e carpti mi?
        {
            Destroy(other.gameObject); // yem'i yok et
            CubeScaler.instance.GetCube1(); //fonk. cagir
        }
        if (other.transform.tag.Equals("Cube5")) //Kup yem'e carpti mi?
        {
            Destroy(other.gameObject); // yem'i yok et
            CubeScaler.instance.GetCube5(); //fonk. cagir
        }
        if (other.transform.tag.Equals("Barrier1")) //Kup engele carpti mi?
        {
            other.transform.GetComponent<Collider>().enabled = false;
            CubeScaler.instance.Barrier1(); //fonk. cagir
        }
        if (other.transform.tag.Equals("Barrier2")) //Kup engele carpti mi?
        {
            other.transform.GetComponent<Collider>().enabled = false;
            CubeScaler.instance.Barrier2(); //fonk. cagir
        }
        if (other.transform.tag.Equals("Barrier3")) //Kup engele carpti mi?
        {
            other.transform.GetComponent<Collider>().enabled = false;
            CubeScaler.instance.Barrier3(); //fonk. cagir
        }
        if (other.transform.tag.Equals("Barrier5")) //Kup engele carpti mi?
        {
            other.transform.GetComponent<Collider>().enabled = false;
            CubeScaler.instance.Barrier5(); //fonk. cagir
        }
        if (other.transform.tag.Equals("Barrier6")) //Kup engele carpti mi?
        {
            other.transform.GetComponent<Collider>().enabled = false;
            CubeScaler.instance.Barrier6(); //fonk. cagir
        }
        if (other.transform.tag.Equals("Barrier9")) //Kup engele carpti mi?
        {
            other.transform.GetComponent<Collider>().enabled = false;
            CubeScaler.instance.Barrier9(); //fonk. cagir
        }
        if (other.transform.tag.Equals("Barrier11")) //Kup engele carpti mi?
        {
            other.transform.GetComponent<Collider>().enabled = false;
            CubeScaler.instance.Barrier11(); //fonk. cagir
        }
        if (other.transform.tag.Equals("FinishPad")) //Kup Finish'e geldi mi?
        {
            other.transform.GetComponent<Collider>().enabled = false;
            CubeScaler.instance.FinishPad=true;
        }
    }
}
