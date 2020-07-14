using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingSound : MonoBehaviour
{
    private void Start()
    {
        if (FindObjectsOfType(GetType()).Length>1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
