using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    private Dictionary<int, Sprite> white_board, black_board;

    // Start is called before the first frame update
    void Start()
    {
        bool isPlayerWhite = false;

        InitializeBoard(isPlayerWhite);
    }

    void InitializeBoard(bool isPlayerWhite)
    {
        string board_to_disable_tag = isPlayerWhite ? "BlackBoard" : "WhiteBoard";


        foreach (Transform child in this.transform)
        {
            if (child.tag == board_to_disable_tag)
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
