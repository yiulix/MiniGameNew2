using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Do initialization here
public class GameStartScene : MonoBehaviour
{
    public PageManager pm;
    // Start is called before the first frame update
    void Start()
    {
        //initialize characters
        GameData.c0.Init(0, "师兄", 100, 10, 10, 2);
        GameData.c1.Init(1, "师姐", 100, 10, 10, 2);
        GameData.c2.Init(2, "师妹", 100, 10, 10, 15);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        pm.Act();
    }
}
