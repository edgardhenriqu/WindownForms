using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var PositionX = e.X;
                var PositionY = e.Y;
                //MessageBox.Show("Posição do mouse: (" + PositionX.ToString() + "," + PositionY.ToString() + ")");

                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = new ToolStripMenuItem();
                vToolTip001.Text = "Item do menu 1";
                ContextMenu.Items.Add(vToolTip001.Text);
                ContextMenu.Show(this,new Point(PositionX,PositionY));
            }
        }
    }
}
