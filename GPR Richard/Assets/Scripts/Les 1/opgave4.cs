using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opgave4 : MonoBehaviour
{
    public Renderer rend;
    public float fadetime;
    public Button fadebutton;

    void Start()
    {
    }

    IEnumerator Fade()
    {
        for (float i = 1f; i >= 0; i -= 0.1f)
        {
            Color c = rend.material.color;
            c.a = i;
            rend.material.color = c;
            yield return null;
            //yield return new WaitForSeconds(fadetime);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("fading");
            Fade();
        }
    }
}
