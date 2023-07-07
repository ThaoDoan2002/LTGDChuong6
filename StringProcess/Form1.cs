
using System.Text;
using System.Web;

namespace StringProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerTitle.Start();
            txtS1.Text = "  khoa CNTT, truong dai  hoc Mo  TP Ho Chi Minh";
        }

        private void timerTitle_Tick(object sender, EventArgs e)
        {
            //Cuon tu phai sang trai
            //lbTitle.Text = lbTitle.Text.Substring(1) + lbTitle.Text.Substring(0, 1);
            // Cuon chu tu trai sang phai
            lbTitle.Text = lbTitle.Text.Substring(lbTitle.Text.Length - 1, 1) + lbTitle.Text.Substring(0, lbTitle.Text.Length - 1);
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtIndex.Text);
            txtS1.Text = txtS1.Text.Insert(index, txtS2.Text);
        }

        private void btnReplaceS2S3_Click(object sender, EventArgs e)
        {
            if (txtS1.Text.Contains(txtS2.Text))
            {
                txtS1.Text = txtS1.Text.Replace(txtS2.Text, txtS3.Text);
            }
            else
            {
                MessageBox.Show($"Chuoi s2 /{txtS2.Text}/ khong duoc chua trong chuoi s1 /{txtS1.Text}/");
            }
        }

        private void btnDaoS1_Click(object sender, EventArgs e)
        {
            //StringBuilder str = new StringBuilder();
            //str.Append(txtS1.Text);
            //string s = "";
            //for (int i = txtS1.Text.Length - 1; i >= 0; i--)
            //{
            //    s += txtS1.Text[i];
            //}
            //txtS1.Text = "";
            //txtS1.Text = s;
            char[] delemiter = { ',', ' '};
            txtS1.Text = txtS1.Text.Trim();
            string[] listS1 = txtS1.Text.Split(delemiter);

            List<string> l = new List<String>();
            foreach (string str in listS1)
            {
                l.Add(str);
            }
            l.Reverse();//Chi co list moi reverse duoc
            txtS1.Text = "";
            foreach (string str in l)
            {
                txtS1.Text += str + "";
            }


        }

        private void btnXoaS2TrongS1_Click(object sender, EventArgs e)
        {
            if (txtS1.Text.Contains(txtS2.Text))
            {
                int i = txtS1.Text.IndexOf(txtS2.Text);
                txtS1.Text = txtS1.Text.Remove(i, txtS2.Text.Length);
            }
            else
            {
                MessageBox.Show($"Chuoi s2 /{txtS2.Text}/ khong duoc chua trong chuoi s1 /{txtS1.Text}/");
            }
        }

        private void btnChuanHoaChuoi_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Trim();
            txtS1.Text = txtS1.Text.Replace("  ", " ");
            string[] list = txtS1.Text.Split(' ');
            string kyTuDau = "";
            string chuois1 = "";
            for(int i = 0; i < list.Length; i++)
            {
                kyTuDau = list[i].Substring(0,1).ToUpper();
                chuois1 += kyTuDau + list[i].Remove(0, 1) + " ";
            }
            txtS1.Text = "";
            txtS1.Text = chuois1;
        }
    }
}