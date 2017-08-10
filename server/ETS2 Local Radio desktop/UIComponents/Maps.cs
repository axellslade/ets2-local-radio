using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ETS2_Local_Radio_server.UIComponents
{
    public partial class Maps : UserControl
    {
        public Maps()
        {
            InitializeComponent();
        }

        private void Maps_Load(object sender, EventArgs e)
        {
            try
            {
                string[] fileEntries = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\maps\\ats");
                foreach (string fileName in fileEntries)
                {
                    var item = new ListViewItem(Path.GetFileNameWithoutExtension(fileName));
                    item.Checked = true;
                    item.Group = listView1.Groups[0];
                    listView1.Items.Add(item);
                }
            } catch (Exception ex)
            {
                Log.Write(ex.ToString());
            }
        }
    }
}
