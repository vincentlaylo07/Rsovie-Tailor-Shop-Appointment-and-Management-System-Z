using System.Media;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.Classes
{
    internal class PlaySound
    {
        // The z and x keys at the beginning of the PlaySound method are
        // positioned close to the left shift key, which I use for naming the methods.

        // Methods
        public async Task zPlaySound()
        {
            await Task.Run(() =>
            {
                using (SoundPlayer soundPlayer = new SoundPlayer("ZSound.wav"))
                {
                    soundPlayer.Play();
                }
            });
        }

        public async Task xPlaySound()
        {
            await Task.Run(() =>
            {
                using (SoundPlayer soundPlayer = new SoundPlayer("ZSound2.wav"))
                {
                    soundPlayer.Play();
                }
            });
        }
    }
}
