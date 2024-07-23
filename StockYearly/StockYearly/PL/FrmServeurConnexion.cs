using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockYearly.PL
{
    public partial class FrmServeurConnexion : Form
    {
        public FrmServeurConnexion()
        {
            InitializeComponent();
        }

        private void btnFindServers_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    //ProgressBar1.Visible = True


                    cmbServers.Items.AddRange(GetSQLServerList());

                    //ProgressBar1.Visible = False

                    cmbServers.DroppedDown = true;


                }
                catch (Exception ex)
                {
                    string mymsg = "Erreur pour avoir la connexion au serveur sql" + Environment.NewLine + "Il se peut que vous avez entrer le nom du serveur nanuellement";
                    MessageBox.Show(mymsg, "Erreur SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
            
        }



        private string[] GetSQLServerList()
        {
            SqlDataSourceEnumerator dse = SqlDataSourceEnumerator.Instance;
            DataTable dt = dse.GetDataSources();
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            string[] SQLServers = new string[dt.Rows.Count];
            int f = -1;
            foreach (DataRow r in dt.Rows)
            {
                string SQLServer = r["ServerName"].ToString();
                string Instance = r["InstanceName"].ToString();
                if (Instance != null && !string.IsNullOrEmpty(Instance))
                {
                    SQLServer += "\\" + Instance;
                }
                SQLServers[System.Math.Max(System.Threading.Interlocked.Increment(ref f), f - 1)] = SQLServer;
            }
            Array.Sort(SQLServers);
            return SQLServers;
        }

        private void btn_ConnexionServeur_Click(object sender, EventArgs e)
        {
            try
            {

                string STR_Con_SERVER = null;
                if (chkUseWindowsSecurity.Checked == false)
                {
                    STR_Con_SERVER = "Data Source=" + cmbServers.Text.Trim(' ') + ";User ID=" + txtUserName.Text.Trim(' ') + ";password=" + txtPassword.Text.Trim(' ') + ";Integrated Security=false";
                    Properties.Settings.Default.Name_SA = txtUserName.Text;
                    Properties.Settings.Default.Pas_SA = txtPassword.Text;
                    Properties.Settings.Default.Server_Name = cmbServers.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    STR_Con_SERVER = " Data Source=" + cmbServers.Text.Trim(' ') + ";Integrated Security=True";
                    Properties.Settings.Default.Name_SA = "";
                    Properties.Settings.Default.Pas_SA = "";
                    Properties.Settings.Default.Server_Name = cmbServers.Text;
                    Properties.Settings.Default.Save();
                }


                SqlConnection Con_1 = new SqlConnection(STR_Con_SERVER);
                Con_1.Open();
                Con_1.Close();
                Properties.Settings.Default.Str_Server_Con = STR_Con_SERVER;
                Properties.Settings.Default.Save();
                MessageBox.Show("Connexion établie avec succée au serveur " + cmbServers.Text, "Connexion au SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();

                string nomServeur = Properties.Settings.Default.Server_Name;
                //MessageBox.Show("Serveur en cours :" + nomServeur);
                MainMenu FrmMain = new MainMenu();
                FrmMain.toolStripStatus_NomServeur.Text = "Nom du Serveur Actuel: " + nomServeur;

            }
            catch (Exception ex)
            {
                string mymsg2 = "Connexion échouée avec le serveur" + Environment.NewLine + "Peut etre vous navez pas séléctionner le nom du serveur ...";
                MessageBox.Show(mymsg2, "Erreur de connexion au SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
