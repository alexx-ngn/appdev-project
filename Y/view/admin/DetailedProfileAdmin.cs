using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y.view.admin
{
    public partial class DetailedProfileAdmin : Form
    {
        public EventHandler banClicked;
        public DetailedProfileAdmin()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            banClicked?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("User has been banned.");
            this.Close();
        }
    }
}
