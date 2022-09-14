namespace GUIExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 새로만들ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 라벨변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "라벨변경";
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void 테스트ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        int STEP = 20;
        private void 상태증가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value + STEP > toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            }
            else
            {
                toolStripProgressBar1.Value += STEP;    
            }
        }

        private void 상태감소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value - STEP < toolStripProgressBar1.Minimum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            }
            else
            {
                toolStripProgressBar1.Value -= STEP;
            }
        }
    }
}