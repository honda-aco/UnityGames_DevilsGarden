using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class RailroadCrossing05 : MyMonoBehaviour
    {
        public void MotionStop()
        {
            GetComponent<Animator>().SetBool("Stop", true);
            GetComponent<Animator>().SetBool("Pass", false);
        }

        public void MotionPass()
        {
            GetComponent<Animator>().SetBool("Pass", true);
            GetComponent<Animator>().SetBool("Stop", false);
        }
    }
}