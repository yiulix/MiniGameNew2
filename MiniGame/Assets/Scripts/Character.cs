using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character:MonoBehaviour
{
    public string name;
    public bool isPlayer = false;
    public int ID;
    public int health;
    public int defense;
    public int attack;

    public int[] relationships;

    public int[] relationshipChange;

    // initialize character attributes by its ID
    public void Init(int ID)
    {
        
    }

    public void TakeDamage()
    {

    }

    private void Update()
    {
        CheckChanges();
    }

    void CheckChanges()
    {

    }
}

public static class GameData
{
    public static Character c0;
    public static Character c1;
    public static Character c2;

    public static int floor = 1;

}
