using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opgave2 : MonoBehaviour
{
    IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < 10; i++)
        {
            print("coroutine update");
        }
        yield return new WaitForSeconds(0.5f);
        print("coroutine einde");
    }

    IEnumerator Start()
    {
        print("Ik start nu de coroutine");
        yield return StartCoroutine("WaitAndPrint");
    }
}
