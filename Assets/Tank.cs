using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	public int health = 10;
    public bool died = false;

    void Update()
    {
        if (health == 0)
        {
            died = true;
            print("you just died\n");
        }
    }

}
