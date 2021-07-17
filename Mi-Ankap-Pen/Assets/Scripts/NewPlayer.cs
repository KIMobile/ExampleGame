using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : MonoBehaviour
{
    public Text userName;
    public Text healthPoints;
    public Text powerPoints;
    public Text energyPoints;
    public Text IntellectPoints;
    public Text PsychologyPoints;
    public Text moneyCount;

    private static string anun;
    private static int hp;
    private static int MaxHp = 70;
    private static int power;
    private static int MaxPower = 60;
    private static int energy;
    private static int MaxEnergy = 60;
    private static double Intellect;
    private static int Psychology;
    private static int MaxPsychology = 100;
    private static int money;

    void Start()
    {
        startGame();
    }

    public void setAnun()
    {
        anun = InputFieldToText.getAnun();
        userName.text = anun;
    }

    private void setHp()
    {
        hp = MaxHp;
    }

    public static void setHp(int points)
    {
        if (points >= 0)
        {
            hp = points;
        }
    }

    public static int getHp()
    {
        return hp;
    }

    public static void setMaxHP(int points)
    {
        if (points >= 0)
        {
            MaxHp = points;
        }
    }

    public static int getMaxHP()
    {
        return MaxHp;
    }

    private void setPower()
    {
        power = MaxPower;
    }

    public static void setPower(int points)
    {
        if (points >= 0)
        {
            power = points;
        }
    }

    public static int getPower()
    {
        return power;
    }

    public static void setMaxPower(int points)
    {
        if (points >= 0)
        {
            MaxPower = points;
        }
    }

    public static int getMaxPower()
    {
        return MaxPower;
    }

    private void setEnergy()
    {
        energy = MaxEnergy;
    }

    public static void setEnergy( int points)
    {
        if (points >= 0)
        {
            energy = points;
        }
    }

    public static int getEnergy()
    {
        return energy;
    }

    public static void setMaxEnergy(int points)
    {
        if (points >= 0)
        {
            MaxEnergy = points;
        }
    }

    public static int getMaxEnergy()
    {
        return MaxEnergy;
    }

    public static void setIntellect()
    {
        Intellect = 0;
    }

    public static void setIntellect(double points)
    {
        if (points >= 0)
        {
            Intellect = points;
        }
    }

    public static double getIntellect()
    {
        return Intellect;
    }

    public static void setPsychology()
    {
        Psychology = MaxPsychology;
    }

    public static void setPsychology(int points)
    {
        if (points >= 0)
        {
            Psychology = points;
        }
    }

    public static int getPsychology()
    {
        return Psychology;
    }

    public static void setMaxPsychology(int points)
    {
        if (points >= 0)
        {
            MaxPsychology = points;
        }
    }

    public static int getMaxPsychology()
    {
        return MaxPsychology;
    }

    private void setMoney()
    {
        money = 50;
    }

    public static void setMoney(int points)
    {
        if (points >= 0)
        {
            money = points;
        }
    }

    public static int getMoney()
    {
        return money;
    }


    public void startGame()
    {
        setAnun();
        setHp();
        setPower();
        setEnergy();
        setIntellect();
        setPsychology();
        setMoney();
        healthPoints.text = getHp().ToString() + "/" + getMaxHP().ToString();
        powerPoints.text = getPower().ToString() + "/" + getMaxPower().ToString();
        energyPoints.text = getEnergy().ToString() + "/" + getMaxEnergy().ToString();
        IntellectPoints.text = getIntellect().ToString();
        PsychologyPoints.text = getPsychology().ToString() + "/" + getPsychology().ToString();
        moneyCount.text = getMoney().ToString() + "$";
    }

    void Update()
    {
        healthPoints.text = getHp().ToString() + "/" + getMaxHP().ToString();
        powerPoints.text = getPower().ToString() + "/" + getMaxPower().ToString();
        energyPoints.text = getEnergy().ToString() + "/" + getMaxEnergy().ToString();
        IntellectPoints.text = getIntellect().ToString();
        PsychologyPoints.text = getPsychology().ToString() + "/" + getPsychology().ToString();
        moneyCount.text = getMoney().ToString() + "$";
    }
}
