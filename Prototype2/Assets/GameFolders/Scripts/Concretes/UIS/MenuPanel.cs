using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prototype2.Managers;

namespace Prototype2.UIS
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
    }
}
