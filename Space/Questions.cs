using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        private void questionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.questionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.questionsDataSet);

        }

        private void Questions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'questionsDataSet.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.questionsDataSet.Questions);
            Random rand = new Random();
            

        }

        private void responseALabel_Click(object sender, EventArgs e)
        {

        }
    }
}
