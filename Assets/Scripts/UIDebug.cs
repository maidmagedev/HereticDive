using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDebug : MonoBehaviour
{
    TextMeshProUGUI tM;
    PlayerMovement pMove;

    // Start is called before the first frame update
    void Start()
    {
        tM = GetComponent<TextMeshProUGUI>();
        pMove = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        tM.text = "SPEED: " + pMove.rb.velocity;
        tM.text += "\nDRAG: " + pMove.rb.drag;
        tM.text += "\nISGROUNDED: " + pMove.grounded;

    }
}
