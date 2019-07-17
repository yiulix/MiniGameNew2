using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowchartManger : MonoBehaviour
{
    private int NumofIteam;
    private int NumofPlayer;
    public void setiteam(int i)
    {
        NumofIteam = i;
    }
    public void setPlayer(int i)
    {
        NumofPlayer = i;
    }
    public void GiveNum()
    {
        switch (NumofPlayer)
        {
            case 1:
                {
                    powerup(1);
                    break;
                }
            case 2:
                {
                    powerup(2);
                    break;
                }
            case 3:
                {
                    powerup(3);
                    break;
                }
        }

    }
    private void powerup(int i)
    {
        switch (NumofIteam)
        {
            case 1:
                {//角色i增加生命与好感
                    break;
                }
            case 2:
                {//角色i增加攻击力与好感
                    break;
                }
            case 3:
                {//角色i增加攻击力与好感
                    break;
                }
        }
    }
    public void IsKeyplot()
    {
        //是否触发关键剧情
    }
}
