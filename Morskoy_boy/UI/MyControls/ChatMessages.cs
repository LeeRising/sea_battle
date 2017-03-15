using System.Drawing;
using System.Windows.Forms;

namespace Morskoy_boy.UI.MyControls
{
    public enum MessageType
    {
        myMessage,
        reviverMessage
    }
    public partial class ChatMessages : UserControl
    {
        public ChatMessages(string messagetext,string datelabel,Image avatar, MessageType messageType)
        {
            InitializeComponent();
            switch (messageType)
            {
                case MessageType.myMessage:
                    avaPb.Location = new Point(3, 3);
                    messageText.Location = new Point(91, 3);
                    messageText.TextAlign = HorizontalAlignment.Left;
                    dateLabel.Location = new Point(91, 58);
                    break;
                case MessageType.reviverMessage:
                    avaPb.Location = new Point(245, 3);
                    messageText.Location = new Point(3, 3);
                    messageText.TextAlign = HorizontalAlignment.Right;
                    dateLabel.Location = new Point(145, 58);
                    break;
            }
            avaPb.Image = avatar;
            messageText.Text = messagetext;
            dateLabel.Text = datelabel;
        }
    }
}
