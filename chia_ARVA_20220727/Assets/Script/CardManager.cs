
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
namespace chia.AR.Vuforia
{

    /// <summary>
    /// �Ϥ����Ѻ޲z
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("KID�Ϥ�����")]
        private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("�p�M�h")]
        private Animator aniKnight;
        [SerializeField, Header("�������s")]
        private Button btnAttack;
        [SerializeField, Header("�������s���D")]
        private VirtualButtonBehaviour vbbJump;

        private string parVictory = "Ĳ�o�ӧQ";
        private AudioSource audBGM;
        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);//�ؼЧ��ƥ�   //.AddListener(��k)
            observerKID.OnTargetLost.AddListener(CardLost);//�ؼп򥢨ƥ�
            btnAttack.onClick.AddListener(Attack);//���s�I���ƥ�
            vbbJump.RegisterOnButtonPressed(OnJmpPressed);
            audBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }

        private void OnJmpPressed(VirtualButtonBehaviour obj)
        {
            print("<color=#3366dd>���D<color>");
        }

        /// <summary>
        /// �Ϥ����Ѧ��\
        /// </summary>
        private void CardFound()
        {
            print("<color=yellow>���d��</color>");
            aniKnight.SetTrigger(parVictory);
            audBGM.Play();
        }
        /// <summary>
        /// �Ϥ����ѥ���
        /// </summary>
        private void CardLost()
        {
            print("<color=red>�d�����ѥ���</color>");
            audBGM.Stop();
        }
        private void Attack()
        {
            print("<color=#9955aa>����!!!</color>");
        }
    }
}