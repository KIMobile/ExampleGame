using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changes : MonoBehaviour
{
    
    public void addMoney()
    {
        int newMoney = NewPlayer.getMoney();
        newMoney += 50;
        NewPlayer.setMoney(newMoney);
    }

    public void minusEnergy()
    {
        int newEnergy = NewPlayer.getEnergy();
        newEnergy -= 20;
        NewPlayer.setEnergy(newEnergy);
    }


}
