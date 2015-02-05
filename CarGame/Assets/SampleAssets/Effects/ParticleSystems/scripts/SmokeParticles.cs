using UnityEngine;

namespace UnitySampleAssets.Effects
{
    public class SmokeParticles : MonoBehaviour
    {

        public AudioClip[] extinguishSounds;

        private void Start()
        {
            audio.clip = extinguishSounds[Random.Range(0, extinguishSounds.Length)];
            audio.Play();
        }
    }
}