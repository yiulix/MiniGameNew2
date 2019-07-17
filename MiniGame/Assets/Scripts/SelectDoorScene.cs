using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDoorScene : MonoBehaviour
{
    public PageManager pgm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Decide what content is behind each door
    void GenerateDoors()
    {

    }

    public void SelectDoor1()
    {
        Debug.Log("SelectDoor1");
        pgm.Act();
        SceneManager.LoadScene("Battle");
    }

    public void SelectDoor2()
    {

    }

    public void SelectDoor3()
    {

    }
}
