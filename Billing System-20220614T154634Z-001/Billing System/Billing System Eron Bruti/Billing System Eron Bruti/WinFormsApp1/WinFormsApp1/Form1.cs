namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double buk = .40;
        double oriz = 1.56;
        double qumesht = 1.00;
        double domate = .60;
        double uj = .30;


        double[] items = new double[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] q = new double[7];

            q[0] = Convert.ToDouble(numBuk.Value);
            q[1] = Convert.ToDouble(numOriz.Value);
            q[2] = Convert.ToDouble(numQumesht.Value);
            q[3] = Convert.ToDouble(numDomate.Value);
            q[4] = Convert.ToDouble(numUj.Value);

            q[5] = q[0] + q[1] + q[2] + q[3] + q[4];

            lblnumitem.Text = Convert.ToString(q[5]);

            items[0] = q[0] * buk;
            items[1] = q[1] * oriz;
            items[2] = q[2] * qumesht;
            items[3] = q[3] * domate;
            items[4] = q[4] * uj;

            items[5] = items[0] + items[1] + items[2] + items[3] + items[4];

            lblTotal.Text = String.Format("{0:c2}", items[5]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numBuk.Value = 0;
            numOriz.Value = 0;
            numQumesht.Value = 0;
            numDomate.Value = 0;
            numUj.Value = 0;

            rtReceipt.Clear();
            lblBuk.Text = "0.00€";
            lblOriz.Text = "0.00€";
            lblQumesht.Text = "0.00€";
            lblDomate.Text = "0.00€";
            lblnumitem.Text = "0";
            lblUj.Text = "0.00€";
            lblTotal.Text = "0.00€";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(numBuk.Value);
            lblBuk.Text = String.Format("{0:c2}", i * buk);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            try
            {



                iExit = MessageBox.Show("Deshironi te dilni", "Billing Sistem Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(numDomate.Value);
            lblDomate.Text = String.Format("{0:c2}", i * domate);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Sistem Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                System.Drawing.Font fntString = new System.Drawing.Font("Arial", 18, FontStyle.Regular);
                e.Graphics.DrawString(rtReceipt.Text, fntString, Brushes.Black, 120, 120);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Sistem Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void numOriz_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(numOriz.Value);
            lblOriz.Text = String.Format("{0:c2}", i * oriz);
        }

        private void numQumesht_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(numQumesht.Value);
            lblQumesht.Text = String.Format("{0:c2}", i * qumesht);
        }

        private void numUj_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(numUj.Value);
            lblUj.Text = String.Format("{0:c2}", i * uj);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtReceipt.Clear();
            rtReceipt.AppendText(label2.Text + "\t" + "\t" + label3.Text + "\t"+ "\t"  + label4.Text + "\n" + "\n");
            rtReceipt.AppendText(label1.Text + "\t" + "\t" + numBuk.Value + "\t" + "\t" + "\t" + "\t"  + lblBuk.Text + "\n" + "\n");
            rtReceipt.AppendText(lbl2.Text + "\t" + "\t" + numOriz.Value + "\t" + "\t" + "\t" + "\t" + lblOriz.Text + "\n" + "\n");
            rtReceipt.AppendText(lbl3.Text + "\t" +  + numQumesht.Value + "\t" + "\t" + "\t" + "\t" + lblQumesht.Text + "\n" + "\n");
            rtReceipt.AppendText(lbl4.Text + "\t" +  + numDomate.Value + "\t" + "\t" + "\t" + "\t" + lblDomate.Text + "\n" + "\n");
            rtReceipt.AppendText(lbl5.Text + "\t" + "\t" + numUj.Value + "\t" + "\t" + "\t" + "\t"  + lblUj.Text + "\n" + "\n");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

