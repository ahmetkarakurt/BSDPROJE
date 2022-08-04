using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using NetSatis.Entities.Context;

namespace NetSatis.BackOffice.Ajanda
{
    public partial class FrmAjanda : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        public FrmAjanda()
        {
            InitializeComponent();
       
            context.BSD_TBL_EFAppointments.Load();
            context.BSD_TBL_EFResources.Load();

            schedulerControl1.DataStorage.Appointments.DataSource = context.BSD_TBL_EFAppointments.Local.ToBindingList();
            schedulerControl1.DataStorage.Resources.DataSource= context.BSD_TBL_EFResources.Local.ToBindingList();
        }

        private void FrmAjanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();
        }
    }
}