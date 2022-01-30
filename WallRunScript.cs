using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRunScript : MonoBehaviour
{

    public GameObject Platform;
    public bool isOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //change ("f") to whatever key you want
    void Update()
    {
        if (Input.GetKey("f"))
        {
            StartCoroutine(WallRun());
        }

        if (Input.GetKeyUp("f"))
        {
            StartCoroutine(Stop());
        }
    }

    IEnumerator WallRun()
    {
        isOn = true;
        Platform.SetActive(true);
        yield return new WaitForSeconds(0f);
    }

    IEnumerator Stop()
    {
        isOn = false;
        Platform.SetActive(false); 
        yield return new WaitForSeconds(0f);
    }
}
