using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int _hp;
    public int MaxHp = 200;

    private int Hp
    
    {
        get { return _hp; }
        set
        {
            if (value < 0)
            {
                _hp = 0;
            }

            else if (value > MaxHp)
            {
                _hp = MaxHp;
            }
            else
            {
                _hp = value;
            }
        }
           
    }
            

    public int Healvalue;
    public int Harmvalue;
    void Start()
    {
        Hp = 100;
    }

    public void Heal()
    {
        Hp += Healvalue;
        Debug.Log(Hp);
    }

    public void Harm()
    {
        Hp -= Harmvalue;
        Debug.Log(Hp);
    }
}


