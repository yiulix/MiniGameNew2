using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowchartManger : MonoBehaviour
{
    private int NumofIteam;
    private int NumofPlayer;
    public Fungus.Flowchart flowchart;

    public void setiteam(int i)
    {
        NumofIteam = i;
        
    }
    public void setPlayer(int i)
    {
        NumofPlayer = i;
        switch (NumofPlayer)
        {
            case 1:
                {
                    flowchart.SetBooleanVariable("Isplayer", GameData.c0.isPlayer);
                    break;
                }
            case 2:
                {
                    flowchart.SetBooleanVariable("Isplayer", GameData.c1.isPlayer);
                    break;
                }
            case 3:
                {
                    flowchart.SetBooleanVariable("Isplayer", GameData.c2.isPlayer);
                    break;
                }
        }
    }
    public void GiveNum()
    {
        switch (NumofPlayer)
        {
            case 1:
                {
                    powerup(GameData.c0);
                    if (GameData.c0.isPlayer)
                        break;
                    else if (GameData.c1.isPlayer)
                        GameData.c1.relationships[0] += 5;
                    else if (GameData.c2.isPlayer)
                        GameData.c2.relationships[0] += 5;
                    break;
                }
            case 2:
                {
                    powerup(GameData.c1);
                    if (GameData.c1.isPlayer)
                        break;
                    else if (GameData.c0.isPlayer)
                        GameData.c0.relationships[1] += 5;
                    else if (GameData.c2.isPlayer)
                        GameData.c2.relationships[1] += 5;
                    break;
                }
            case 3:
                {
                    powerup(GameData.c2);
                    if (GameData.c2.isPlayer)
                        break;
                    else if (GameData.c1.isPlayer)
                        GameData.c1.relationships[2] += 5;
                    else if (GameData.c0.isPlayer)
                        GameData.c0.relationships[2] += 5;
                    break;
                }
        }

    }
    private void powerup(Character character)
    {
        switch (NumofIteam)
        {
            case 1:
                {//角色i增加生命
                    character.health += 20;
                    break;
                }
            case 2:
                {//角色i增加攻击力
                    character.attack += 10;
                    break;
                }
            case 3:
                {//角色i增加防御力
                    character.defense += 5;
                    break;
                }
        }
    }
    public void IsKeyplot()
    {
        //是否触发关键剧情
    }
}
