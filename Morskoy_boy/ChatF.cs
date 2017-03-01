using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Morskoy_boy
{
    public partial class ChatF : MaterialForm
    {
        public ChatF(string friends_name)
        {
            InitializeComponent();
            Text = friends_name;
            //Юзатьи табконтрол и тейбл лейаут
        }
    }
}
