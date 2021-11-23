using System.Drawing;
using System.Windows.Forms;

namespace BrawlCrate.BrawlManagers.CostumeManager.Portrait_Viewers
{
    public class CostumeNumberLabel : Label
    {
        public void UpdateImage(int charNum, int costumeNum, int masqID, bool confident)
        {
            Text = $"Char {charNum} / Costume {costumeNum} / Masq {masqID}";
            if (!confident)
            {
                Text += " (?)";
            }

            BackColor = costumeNum < 0 ? Color.Red
                : confident ? Color.LightGreen
                : Color.Yellow;
        }
    }
}