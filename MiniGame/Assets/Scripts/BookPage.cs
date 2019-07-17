using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BookPage : MonoBehaviour
{
    //material of the page object
    private Material m_Material;
    public GameObject bookCam;

    void Start()
    {
        m_Material = GetComponent<MeshRenderer>().material;
        m_Material.SetFloat("_Angle", 0);
        m_Material.DOFloat(180, "_Angle", 5);
        bookCam.transform.DORotate(new Vector3(-23, 0, 0), 5);
        bookCam.transform.DOLocalMove(new Vector3(0, -3, -14), 5);
    }


    void Update()
    {
        
    }
}
