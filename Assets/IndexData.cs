using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexData : MonoBehaviour
{
    public enum VoiceOverSelection
    {
        VOICE_OVER_01 = 0,
        VOICE_OVER_02 = 1,
        VOICE_OVER_03 = 2,
        VOICE_OVER_04 = 3,
        VOICE_OVER_05 = 4,
        VOICE_OVER_06 = 5,
        VOICE_OVER_07 = 6,
        VOICE_OVER_08 = 7,
        VOICE_OVER_09 = 8,
        VOICE_OVER_10 = 9,
        VOICE_OVER_11 = 10,
        VOICE_OVER_12 = 11
    }


    [System.Serializable] //nos permite ver el tipo de dato en el inspector
    public class VoiceOver //definir como un cat�logo de datos
    {
        public AudioClip audioClip;
        public VoiceOverSelection catalogIndex;
    }


    public class ScrVoiceOverLogic : MonoBehaviour
    {
        public VoiceOver[] voiceOverLists; //se llen� en el inspector

        public void ReproduceVoiceOver(VoiceOverSelection index)
        {
            this.gameObject.GetComponent<AudioSource>().Stop(); //para detener lo que estaba reproduciendo
            this.gameObject.GetComponent<AudioSource>().clip = voiceOverLists[(int)index].audioClip;
            this.gameObject.GetComponent<AudioSource>().Play();
            //vamos a rescatar al componente hermano de este script, que es el audio source
            //y a este audio source vamos a cambiarle el audio clip
            //con respecto al indice del trigger que toc� el avatar,
            //del que est� realmente en la lista de los voice overs

        }
    }


}
