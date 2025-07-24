using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ParticleScript : MonoBehaviour
{
    [SerializeField]
    RectTransform FxHolder;
    [SerializeField]
    Image CircleImage;
    [SerializeField]
    float maxTime;
    // Start is called before the first frame update
    
    public void ApplyEffect(float progress)
    {
        var progressElapsed = progress / maxTime;
        CircleImage.fillAmount = Mathf.Lerp(0, 1, progressElapsed);
        FxHolder.rotation = Quaternion.Euler(new Vector3(0f, 0f, -progressElapsed * 360));
    }
}
