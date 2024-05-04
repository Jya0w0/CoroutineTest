using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    public SpriteRenderer renderer;

    Coroutine coroutine = null;

    private void Awake()
    {
        Application.targetFrameRate = 30;
    }

    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            //Fade();
            coroutine = StartCoroutine(CoFade());
            //StartCoroutine("CoFade");
        }

        Debug.Log("COCOCO");

        
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("What!");
            //StopCoroutine(CoFade());
            //StopCoroutine("CoFade");
            //StopAllCoroutines();
            if (coroutine != null) StopCoroutine(coroutine);
        }
    }

    void Fade()
    {
        Color c = renderer.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 000.1f)
        {
            c.a = alpha;
            renderer.color = c;
            Debug.Log("WoW");
        }
    }

    IEnumerator CoFade()
    {
        Color c = renderer.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            c.a = alpha;
            renderer.color = c;
            yield return new WaitForSeconds(.1f);
            Debug.Log("WoW");
        }
    }
}
