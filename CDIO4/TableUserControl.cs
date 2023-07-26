using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDIO4
{
    public partial class TableUserControl : UserControl
    {
        public event EventHandler btn_OpenTableClick;
        public event EventHandler btn_ThanhToanClick;
        public event EventHandler btn_GoiMonClick;
        public event EventHandler TimerTick;
        public TableUserControl()
        {
            InitializeComponent();
        }

        public void SetTableStatus(string tableName, string status)
        {
            lb_NameTable.Text = tableName;
        }
        public void UpdateTableInfo(int tableID, string tableName, string tableStatus)
        {
            // Cập nhật thông tin của bàn trong các controls trong UserControl
        }
        private void btn_OpenTable_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btn_GoiMon_Click(object sender, EventArgs e)
        {

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
