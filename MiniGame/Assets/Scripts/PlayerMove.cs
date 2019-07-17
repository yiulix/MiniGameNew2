using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 targetPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane p = new Plane(new Vector3(0, 0, -1), 0);
            float enter;
            if (p.Raycast(ray, out enter))
            {
                targetPos = ray.GetPoint(enter);
            }
        }

        //有时间再改这里
        transform.position = Vector3.Lerp(transform.position, targetPos,5 * Time.deltaTime);
    }
}
