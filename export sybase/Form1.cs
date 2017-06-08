using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Sybase.Data.AseClient;

namespace export_sybase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["dbconnection"].ToString();

            AseCommand cmd = new AseCommand();

            AseConnection conn = new AseConnection(connStr);

            if (string.IsNullOrEmpty(txtSQL.Text.Trim()))
            {
                txtSQL.Focus();
                MessageBox.Show("請輸入指令!", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtPath.Text.Trim()))
            {
                txtPath.Focus();
                MessageBox.Show("請輸入路徑!", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtTerminator.Text.Trim()))
            {
                txtTerminator.Focus();
                MessageBox.Show("請輸入分隔符號!", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                cmd.CommandText = txtSQL.Text.Trim();
                cmd.CommandTimeout = 60;
                cmd.Connection = conn;
                cmd.Connection.Open();

                Stopwatch watch = new Stopwatch();
                watch.Start();
                AseDataReader dr = cmd.ExecuteReader();
                int intCount = 0;

                if (dr.HasRows)
                {
                    DirectoryInfo file = new DirectoryInfo(txtPath.Text.Trim());
                    int intCloumn = 0;

                    if (!file.Exists)
                        file.Create();

                    intCloumn = chkColumn.Checked ? 0 : 1;

                    string strFileName = txtPath.Text.Trim() + "export.txt";
                    while (new FileInfo(strFileName).Exists)
                    {
                        Random rnd = new Random();
                        strFileName = txtPath.Text.Trim() + "export_" + rnd.Next(1, 1000) + ".txt";
                    }

                    StreamWriter SaveFile = new StreamWriter(
                       File.Open(strFileName, FileMode.CreateNew), Encoding.UTF8);

                    StringBuilder strTemp = new StringBuilder();

                    if (intCloumn == 0) //欄位
                    {
                        strTemp.Length = 0;
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            strTemp.Append(dr.GetName(i) + txtTerminator.Text.Trim());
                        }

                        SaveFile.WriteLine(strTemp.ToString().Trim());
                        intCloumn = 1;
                    }

                    strTemp.Length = 0;
                    while (dr.Read())
                    {
                        //明細
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            strTemp.Append(dr[i] == System.DBNull.Value
                                    ? ""
                                    : dr[i].ToString().Trim() + txtTerminator.Text.Trim());
                        }

                        intCount += 1;
                        strTemp.AppendLine("");

                        if (intCount >= 100000)      //多筆寫一次
                        {
                            SaveFile.WriteLine(strTemp.ToString().Trim());
                            intCount = 0;
                            strTemp.Length = 0;
                        }

                        //SaveFile.WriteLine(strTemp.ToString().Trim());
                    }

                    if (strTemp.Length > 0)
                        SaveFile.WriteLine(strTemp.ToString().Trim());

                    SaveFile.Close();
                    SaveFile.Dispose();
                }

                dr.Close();
                dr.Dispose();
                watch.Stop();

                MessageBox.Show("匯出完成，共花費" + watch.ElapsedMilliseconds.ToString() + "毫秒", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                watch = null;
            }
            catch (AseException ase)
            {
                MessageBox.Show(ase.Message.ToString(), "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open || cmd.Connection.State == ConnectionState.Connecting)
                {
                    cmd.Connection.Close();
                }
                cmd.Dispose();
                cmd = null;
            }
        }
    }
}
