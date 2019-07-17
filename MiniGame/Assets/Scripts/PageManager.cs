using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    public RenderTexture rt;
    public GameObject bookCam;
    public GameObject page;
    public GameObject rPage;
    public GameObject lPage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Act()
    {
        GameObject mainCam = GameObject.FindWithTag("MainCamera");
        mainCam.GetComponent<Camera>().targetTexture = rt;

        bookCam.SetActive(true);
        page.SetActive(true);
        rPage.SetActive(true);
        lPage.SetActive(true);
        
    }
}
