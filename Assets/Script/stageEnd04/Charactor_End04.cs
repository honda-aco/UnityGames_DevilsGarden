using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class Charactor_End04 : Charactor
    {
        /// <summary>
        /// アニメーションを「座る」に設定
        /// </summary>
        public void Sit()
        {
            GetComponent<Animator>().SetBool("Stand", false);
            GetComponent<Animator>().SetBool("Walk", false);
            GetComponent<Animator>().SetBool("Run", false);
            GetComponent<Animator>().SetBool("Sit", true);
        }
    }
}