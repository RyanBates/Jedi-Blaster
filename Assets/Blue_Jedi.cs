using UnityEngine;
using System.Collections;

public class Blue_Jedi : MonoBehaviour
{
    public int health = 1;
    public bool dJedi = false;

    void Update()
    {
        if (health == 0)
        {
            dJedi = true;
        }
    }
    
}