using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAnWD
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private Form activeChild = null;

        private void LoadChildForm(Form frm)
        {
            if (activeChild != null)
            {
                activeChild.Close();
                panelHost.Controls.Clear();
                activeChild = null;
            }

            activeChild = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelHost.Controls.Add(frm);
            frm.Show();
        }

        private void btnGiaSu_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmGiaSu());
        }

        private void btnHocVien_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmHocVien());
        }

        private void btnGhepLop_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmGhepLop());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmThongKe());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (activeChild != null)
            {
                // Re-create the active form so it reloads data
                var type = activeChild.GetType();
                LoadChildForm((Form)Activator.CreateInstance(type));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}