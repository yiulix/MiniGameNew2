using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageFill : MonoBehaviour
{
    public Camera bookCam;
    // Start is called before the first frame update
    void Start()
    {
        float h = Mathf.Tan(bookCam.fieldOfView * Mathf.Deg2Rad * 0.5f) * 10 * 2f;
        
        transform.localScale = new Vector3(h * bookCam.aspect, h, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
