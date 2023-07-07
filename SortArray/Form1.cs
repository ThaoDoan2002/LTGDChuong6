using System;

namespace SortArray
{
    public partial class Form1 : Form
    {
        private int[] arr;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void taoMang()
        {
            this.arr = new int[int.Parse(txtSoPhanTu.Text)];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
        }
    
        private void mangDao()
        {
            txtMangDao.Text = "";
            List<int> l = new List<int>();
            for(int i = 0; i < this.arr.Length; i++)
            {
                l.Add(this.arr[i]);
            }

            l.Reverse();
            for (int i = 0; i < l.Count; i++)
            {
                if (i != l.Count - 1)
                {
                    txtMangDao.Text += l[i].ToString() + ",";
                }
                else
                {
                    txtMangDao.Text += l[i].ToString();
                }
            }
        }

        private void hienThiMang(int[] arr)
        {
              for (int i = 0; i < arr.Length; i++)
            {
                if(i != arr.Length - 1)
                {
                    txtMangBanDau.Text += arr[i].ToString() + ",";
                }
                else
                {
                    txtMangBanDau.Text += arr[i].ToString();
                }
          
            }
        }

        private void btnTaoMangNgauNhien_Click(object sender, EventArgs e)
        {
            txtMangBanDau.Text = "";
            txtMangTang.Text = "";
            txtMangGiam.Text = "";
            txtMangDao.Text = "";
            txtChanTangLeGiam.Text = "";
            taoMang();
            hienThiMang(this.arr);
            
        }

        private void sapXepMang()
        {
            txtMangTang.Text = "";
            txtMangGiam.Text = "";
            List<int> num = new List<int>();
            for(int i =0; i < this.arr.Length; i++)
            {
                num.Add(arr[i]);
            }
            num.Sort();
            for (int i = 0; i < num.Count; i++)
            {
                if (i != num.Count - 1)
                {
                    txtMangTang.Text += num[i].ToString() + ",";
                }
                else
                {
                    txtMangTang.Text += num[i].ToString();
                }
            }

            num.Reverse();
            for (int i = 0; i < num.Count; i++)
            {
                if (i != num.Count - 1)
                {
                    txtMangGiam.Text += num[i].ToString() + ",";
                }
                else
                {
                    txtMangGiam.Text += num[i].ToString();
                }
            }
        }
        private void chanTangLeGiam()
        {
            List<int> chan = new List<int>();
            List<int> le = new List<int>();
            for(int i = 0; i <  arr.Length; i++)
            {
                if (arr[i] %2 == 0) {
                    chan.Add(arr[i]);
                }
                else
                {
                    le.Add(arr[i]);
                }
            }
            chan.Sort();
            le.Sort();
            le.Reverse();
            foreach(int i in chan)
            {
                txtChanTangLeGiam.Text += i.ToString() + ",";
            }
            for(int i = 0; i < le.Count;i++)
            {
                if(i != le.Count - 1)
                {
                    txtChanTangLeGiam.Text += le[i].ToString() + ",";
                }
                else
                {
                    txtChanTangLeGiam.Text += le[i].ToString();
                }
             
            }
        }
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            sapXepMang();
            mangDao();
            chanTangLeGiam();
        }
    }
}