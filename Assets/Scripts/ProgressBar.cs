using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public GameObject player;
    public GameObject finishLine;
    Image progressBar;
    float Distance;
    // Start is called before the first frame update
    void Start()
    {
        progressBar = GetComponent<Image>();
        Distance = finishLine.transform.position.z;

        progressBar.fillAmount = player.transform.position.z/Distance;
    }

    // Update is called once per frame
    void Update()
    {
        if(progressBar.fillAmount<1)
        {
            progressBar.fillAmount = player.transform.position.z/Distance;
        }
    }
}
