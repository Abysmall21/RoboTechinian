using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] GameObject[] button;
    [Header ("Color Order")]
    [SerializeField] List<int> colorOrder;

    // Start is called before the first frame update
    void Start()
    {
        PlayGame();
    }

    void PlayGame()
    {
        PickRandomColor();
    }

    void PickRandomColor()
    {
        int rnd = Random.Range(0, button.Length);
        button[rnd].PressButton();
        colorOrder.Add(rnd);
    }
}
