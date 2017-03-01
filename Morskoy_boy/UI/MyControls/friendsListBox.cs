using System.Drawing;
using System.Windows.Forms;

namespace Morskoy_boy.UI.MyControls
{
    class friendsListBoxItem
    {
        private string _user_name;
        private string _user_rank;
        public string _state;
        private Image _user_avatar;
        

        public friendsListBoxItem(string user_name, string user_rank, Image user_avatar,string state)
        {
            _user_name = user_name;
            _user_rank = user_rank;
            _user_avatar = user_avatar;
            _state = state;
        }

        public string User_name
        {
            get { return _user_name; }
            set { _user_name = value; }
        }

        public string User_rank
        {
            get { return _user_rank; }
            set { _user_rank = value; }
        }

        public Image User_avatar
        {
            get { return _user_avatar; }
            set { _user_avatar = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void drawItem(DrawItemEventArgs e, Padding margin, 
                             Font nameFont, Font rankFont,Font stateFont, StringFormat aligment, 
                             Size imageSize)
        {            

            // if selected, mark the background differently
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

            // draw some item separator
            e.Graphics.DrawLine(Pens.DarkGray, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);

            // draw item image
            e.Graphics.DrawImage(this.User_avatar, e.Bounds.X + margin.Left, e.Bounds.Y + margin.Top, imageSize.Width, imageSize.Height);

            // calculate bounds
            Rectangle nameBounds = new Rectangle(e.Bounds.X + margin.Horizontal + imageSize.Width,
                                                  e.Bounds.Y + margin.Top,
                                                  e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal,
                                                  (int)nameFont.GetHeight());
            
            Rectangle rankBounds = new Rectangle(e.Bounds.X + margin.Horizontal + imageSize.Width,
                                                   e.Bounds.Y + (int)nameFont.GetHeight() + margin.Top+5,
                                                   e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal,
                                                   (int)rankFont.GetHeight()+2);

            Rectangle stateBounds = new Rectangle(e.Bounds.X + margin.Horizontal + imageSize.Width,
                                                   e.Bounds.Y + (int)rankFont.GetHeight() + margin.Top+25,
                                                   e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal,
                                                   (int)stateFont.GetHeight()+2);

            // draw the text within the bounds
            e.Graphics.DrawString(this.User_name, nameFont, Brushes.Black, nameBounds, aligment);
            e.Graphics.DrawString(this.User_rank, rankFont, Brushes.Blue, rankBounds, aligment);

            if (_state == "Online")
                e.Graphics.DrawString(this.State, stateFont, Brushes.Green, stateBounds, aligment);
            if (_state == "Afk")
                e.Graphics.DrawString(this.State, stateFont, Brushes.Purple, stateBounds, aligment);
            if (_state == "Busy")
                e.Graphics.DrawString(this.State, stateFont, Brushes.IndianRed, stateBounds, aligment);
            if (_state != "Busy" & _state != "Online" & _state != "Afk")
                e.Graphics.DrawString(this.State, stateFont, Brushes.Black, stateBounds, aligment);

            // put some focus rectangle
            e.DrawFocusRectangle();
        
        }

    }

    public partial class friendsListBox : ListBox
    {

        private Size _imageSize;
        private StringFormat _fmt;
        private Font _nameFont;
        private Font _rankFont;
        private Font _stateFont;

        public friendsListBox(Font nameFont, Font rankFont,Font stateFont, Size imageSize, 
                         StringAlignment aligment, StringAlignment lineAligment)
        {
            _nameFont = nameFont;
            _rankFont = rankFont;
            _stateFont = stateFont;
            _imageSize = imageSize;
            this.ItemHeight = _imageSize.Height + this.Margin.Vertical;
            _fmt = new StringFormat();
            _fmt.Alignment = aligment;
            _fmt.LineAlignment = lineAligment;
        }

        public friendsListBox()
        {
            InitializeComponent();
            _imageSize = new Size(80,60);
            this.ItemHeight = _imageSize.Height + this.Margin.Vertical;
            _fmt = new StringFormat();
            _fmt.Alignment = StringAlignment.Near;
            _fmt.LineAlignment = StringAlignment.Near;
            _rankFont = _stateFont = new Font("Rockwell", (float)10.3);
            _nameFont = new Font("Verdana",(float)10.3);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // prevent from error Visual Designer
            if (this.Items.Count > 0)            
            {
                friendsListBoxItem item = (friendsListBoxItem)this.Items[e.Index];                
                item.drawItem(e, this.Margin, _nameFont, _rankFont,_stateFont, _fmt, this._imageSize);
            }                            
        }
       

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
