using System;
using System.Globalization;
using Interface;
using UnityEngine;

namespace Script.Hero
{
    public class Yasuo : BaseHero, ISkillHero
    {
        public void NoiTai()
        {
            Debug.Log("Nội tại");
        }

        public void KyNang_Q()
        {
            Debug.Log("Kỹ Năng Q");
        }

        public void KyNang_W()
        {
            Debug.Log("Kỹ Năng W");
        }

        public void KyNang_E()
        {
            Debug.Log("Kỹ Năng E");
        }

        public void KyNang_R()
        {
            Debug.Log("Kỹ Năng R");
        }
        
    }
}