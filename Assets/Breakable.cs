using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakble : MonoBehaviour
{
    public List<GameObject> breakablePieces;
    public float timerToBreak = 2;
    private float timer = 0;
    private void Start()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(false);
        }
    }

    public void Break()
    {

        timer += Time.deltaTime;

        if (timer > timerToBreak)
        {
            foreach (var item in breakablePieces)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }

            gameObject.SetActive(false);
        }


    }
}
