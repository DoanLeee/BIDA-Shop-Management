using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO4
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            frm_Table display = new frm_Table();
            //display = new frm_Table();
            //display.TopLevel = false;
            //display.Dock = DockStyle.Fill;
            //this.Controls.Add(display);
            //display.Show(); 

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            frm_Table mh = new frm_Table();
            mh.MdiParent = this;
            mh.Show();
        }

        private void pic_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn thật sự muốn kết thúc ca?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}


//
//                       _oo0oo_
//                      o8888888o
//                      88" . "88
//                      (| -_- |)
//                      0\  =  /0
//                    ___/`---'\___
//                  .' \\|     |// '.
//                 / \\|||  :  |||// \
//                / _||||| -:- |||||- \
//               |   | \\\  -  /// |   |
//               | \_|  ''\---/''  |_/ |
//               \  .-\__  '-'  ___/-. /
//             ___'. .'  /--.--\  `. .'___
//          ."" '<  `.___\_<|>_/___.' >' "".
//         | | :  `- \`.;`\ _ /`;.`/ - ` : | |
//         \  \ `_.   \_ __\ /__ _/   .-` /  /
//     =====`-.____`.___ \_____/___.-`___.-'=====
//                       `=---='
//
//
//     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
