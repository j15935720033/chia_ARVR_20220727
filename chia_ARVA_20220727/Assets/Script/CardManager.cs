using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace chia.AR.Vuforia
{

    /// <summary>
    /// 圖片辨識管理
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("KID圖片辨識")]
        private DefaultObserverEventHandler observerKID;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);//.AddListener(方法)
            observerKID.OnTargetLost.AddListener(CardLost);
        }
        /// <summary>
        /// 圖片辨識成功
        /// </summary>
        private void CardFound()
        {
            print("<color=yellow>找到卡片</color>");
        }
        /// <summary>
        /// 圖片辨識失敗
        /// </summary>
        private void CardLost()
        {
            print("<color=red>卡片辨識失敗</color>");
        }
    }
}