using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuoteNode : MonoBehaviour
{
    [SerializeField] TMP_InputField quote;
    [SerializeField] TMP_Dropdown emotion;
    [SerializeField] TMP_InputField effect;

    QuoteData data;

    public void Setup(QuoteData data)
    {
        this.data = data;
        quote.text = data.quote;
        emotion.value = data.emotion;
        effect.text = data.effect;
    }
}
