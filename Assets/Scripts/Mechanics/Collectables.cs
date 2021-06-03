using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{


    public class Collectables : MonoBehaviour
    {
        public int Tokens = 0;
        public int MaxTokens;
        TokenInstance[] scenetokens;
        public void Increment()
        {
            Tokens++;
        }
        // Start is called before the first frame update
        void Start()
        {
            scenetokens = UnityEngine.Object.FindObjectsOfType<TokenInstance>();
            MaxTokens = scenetokens.Length;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}