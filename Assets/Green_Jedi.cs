using UnityEngine;
using System.Collections;

public class Green_Jedi : MonoBehaviour
{
    public int health = 3;
    public bool jDied = false;

    void Update()
    {
        if (health == 0)
        {
            jDied = true;
        }
    }

}