using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTrsah);
    }

    public void InsideTrsah(GameObject go)
    {
        go.SetActive(false);
    }
}
