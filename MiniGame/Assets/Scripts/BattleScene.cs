﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScene : MonoBehaviour
{
    public PageManager pgm;
    int turn = -1; // 0 for c0, 2 for c1, 4 for c2, 1,3,5 for monster
    public Monster monster;

    string[] toDialog; // who, whom, dmg

    // Start is called before the first frame update
    void Start()
    {
        toDialog = new string[3];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            pgm.Act();
        }
    }

    void StartBattle()
    {
        turn = 0;
    }

    void NextTurn()
    {
        turn += 1;
        if (turn == 6)
        {
            turn = 0;
        }
    }

    //called once per click in battle
    public string[] OneTurn()
    {
        if (turn == 0)
        {
            int dmg = GameData.c0.attack - monster.defense;
            monster.health -= dmg;
            toDialog[0] = GameData.c0.name;
            toDialog[1] = monster.name;
            toDialog[2] = dmg.ToString();
        }
        if (turn == 2)
        {
            monster.health -= GameData.c1.attack;
            int dmg = GameData.c1.attack - monster.defense;
            monster.health -= dmg;
            toDialog[0] = GameData.c1.name;
            toDialog[1] = monster.name;
            toDialog[2] = dmg.ToString();
        }
        if (turn == 4)
        {
            monster.health -= GameData.c2.attack;
            int dmg = GameData.c2.attack - monster.defense;
            monster.health -= dmg;
            toDialog[0] = GameData.c2.name;
            toDialog[1] = monster.name;
            toDialog[2] = dmg.ToString();
        }
        //monster attack
        else
        {
            int r = (int)(Random.value * 3);
            int dmg;
            if (r == 0)
            {
                dmg = monster.attack - GameData.c0.defense;
                toDialog[0] = monster.name;
                toDialog[1] = GameData.c0.name;
                toDialog[2] = dmg.ToString();
            }
            if (r == 1)
            {
                dmg = monster.attack - GameData.c1.defense;
                toDialog[0] = monster.name;
                toDialog[1] = GameData.c1.name;
                toDialog[2] = dmg.ToString();
            }
            if (r == 2)
            {
                dmg = monster.attack - GameData.c2.defense;
                toDialog[0] = monster.name;
                toDialog[1] = GameData.c2.name;
                toDialog[2] = dmg.ToString();
            }

        }

        if (monster.health <= 0)
        {
            BattleWin();
        }
        NextTurn();

        return toDialog;
    }

    void GenerateMonster()
    {

    }

    void BattleWin()
    {

    }

    void BattleLose()
    {

    }
}
