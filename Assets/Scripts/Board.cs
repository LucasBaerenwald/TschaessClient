using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateBoard(true);
    }

    void CreateBoard(bool isPlayerWhite)
    {
        string boardToDisable = "WhiteBoard";

        if (isPlayerWhite)
        {
            boardToDisable = "BlackBoard";
        }

        foreach (Transform child in this.transform)
        {
            if (child.tag == boardToDisable)
            {
                child.gameObject.SetActive(false);
            }
        }

    }
}
