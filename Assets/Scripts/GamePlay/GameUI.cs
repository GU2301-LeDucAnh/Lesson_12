using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Button lvUpBtn;

    // Start is called before the first frame update
    public void Init()
    {
        lvUpBtn.onClick.AddListener(LvUpEffect);
    }

    // Update is called once per frame
    void LvUpEffect()
    {
        GamePlayController.Instance.particleController.LevelUp();
    }
}
