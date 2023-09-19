using DJM.CoreServices;
using DJM.CoreServices.ServiceLocator;
using UnityEngine;

namespace DJM.Utilities.Audio
{
    internal sealed class PlayAudioEffectOnDestroy : MonoBehaviour
    {
        private ITransientSoundService _transientSoundService;
        
        [SerializeField] private AudioClip audioClip;
        [SerializeField] private bool randomisePitch;
        private void Awake() => _transientSoundService = DJMServiceLocator.Resolve<ITransientSoundService>();

        private void OnDestroy()
        {
            if(randomisePitch) _transientSoundService.PlaySoundRandomPitch(audioClip);
            else _transientSoundService.PlaySound(audioClip);
        }
    }
}