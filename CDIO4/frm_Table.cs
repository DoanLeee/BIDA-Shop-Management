
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

    public partial class frm_Table : Form
    {
        ClassChung generalclass = new ClassChung();
        frm_Main main = new frm_Main();

        

        private List<Table> tables;
        public frm_Table()
        {

            InitializeComponent();
            //show frm_table fill on frm_main
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Parent = main;
            this.Size = new Size(main.ClientSize.Width, main.ClientSize.Height);
            this.Location = new Point((main.ClientSize.Width - this.Width) / 2, (main.ClientSize.Height - this.Height) / 2);

            LoadTables();

        }


        private void LoadTables()
        {
            List<TableUserControl> tableUserControls = generalclass.GetTableUserControlsFromDatabase();
            foreach (var tableUserControl in tableUserControls)
            {
                flowLayoutPanelTables.Controls.Add(tableUserControl);
            }
    
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
