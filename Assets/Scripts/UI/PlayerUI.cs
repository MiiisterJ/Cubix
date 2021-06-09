using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Platformer.Mechanics
{

    public class PlayerUI : MonoBehaviour
    {
        public PlayerController player;

        Image[] heart = new Image[3];
        Text token;
        //public Collectable
        // Start is called before the first frame update
        void Awake()
        {
            player = GameObject.Find("Player").GetComponent<PlayerController>(); 
            heart[0] = GameObject.Find("Game Canvas/Heart 1").GetComponent<Image>();
            heart[1] = GameObject.Find("Game Canvas/Heart 2").GetComponent<Image>();
            heart[2] = GameObject.Find("Game Canvas/Heart 3").GetComponent<Image>();

            token = GameObject.Find("Game Canvas/Collectable Text/Yellow Diamond/Text").GetComponent<Text>();
            //token.text = "0/" + player.collection.MaxTokens;
        }


        // Update is called once per frame
        void Update()
        {
            if (player.health.currentHP <= 2)
                heart[2].enabled = false;
            else heart[2].enabled = true;
            if (player.health.currentHP <= 1)
                heart[1].enabled = false;
            else heart[1].enabled = true;
            if (player.health.currentHP <= 0)
                heart[0].enabled = false;
            else heart[0].enabled = true;

            token.text = player.collection.Tokens + "/" + player.collection.MaxTokens;
        }

    }
}
