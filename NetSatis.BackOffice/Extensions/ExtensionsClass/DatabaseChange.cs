using NetSatis.Entities.Context;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.BackOffice.Extensions.ExtensionsClass
{
   public static class DatabaseChange
    {
        public static void dbSetet()
        {




            NetSatisContext context = new NetSatisContext();
            // MessageBox.Show();
            string connectionString = context.Database.Connection.ConnectionString;


          //  connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", parcalar[1], vt, parcalar[5], parcalar[7]);
          //try
          //{
          //    SqlHelper helper = new SqlHelper(connectionString);
          //    if (helper.IsConnection)
          //    //    MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
          //}
          //catch (Exception ex)
          //{
          //   // MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //}

            //
            //****



            //Set connection string
            // connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("eenwindConnection", connectionString);
                  //  MessageBox.Show("Your connection string has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
