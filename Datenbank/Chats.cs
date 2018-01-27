using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datenbank
{
    public partial class Chats : Form
    {
        List<string> ListChats = new List<string>();
        public Chats()
        {
            InitializeComponent();
            // Get values into ListChats
            foreach (string s in ListChats)
            {
                Panel P = new Panel();
                P.Size = new Size(100,20);

            }
        }
    }
}
