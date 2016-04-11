using UnityEngine;
using System.Collections;

public class Yellow_Jedi : MonoBehaviour
{
    public int health = 2;
    public bool dJedi = false;

    void Update()
    {
        if (health == 0)
        {
            dJedi = true;
        }
    }

}