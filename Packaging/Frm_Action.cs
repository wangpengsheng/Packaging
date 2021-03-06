﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RobotKit;
using StaubliRobot;
using System.Threading;



namespace Packaging
{
    public partial class Frm_Action : Std_Form
    {
        DataBaseManage db = new DataBaseManage();
        string FileName;
        public Frm_Action()
        {
          InitializeComponent();

          CB_RobotIndex.Items.Clear();

            CB_RobotIndex.Items.AddRange(TxtData.RobotIndex);

                        
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            Edit_Action frm = new Edit_Action(gv.GetSelectedRows()[0]);
            frm.ShowDialog();
            Frm_Action_Load(this, null);
        }

        private void Frm_Action_Load(object sender, EventArgs e)
        {

        }

        private void BT_Teach_Click(object sender, EventArgs e)
        {
            if (TxtData.DataBase.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            if (TxtData.DataBase.ToolMode != 1)
            {
                MessageBox.Show("请切换到手动模式!");
                return;
            }


            TxtData.PublicData.ErrorCode = 0;

            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Poll));
            Frm_Wait frm = new Frm_Wait(true);
            frm.ShowDialog();
            Frm_Action_Load(this, null);

        }



        private void Poll(object target)
        {


            //if (!db.SaveAction())
            //{
            //    TxtData.PublicData.ErrorCode = 2;
            //    return;
            //}

            //FtpClient ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);


            //if (!ftp.UploadAction())
            //{
            //    TxtData.PublicData.ErrorCode = 22;
            //    return;
            //}

            //if (!SoapInstance.SoapRead.SetAppdata("nInterfaceType", 4))
            //{
            //    TxtData.PublicData.ErrorCode = 12;
            //    return;
            //}
            //TxtData.PublicData.ErrorCode = 40;
        }

        private void BT_Import_Click(object sender, EventArgs e)
        {
            if ((FileName = PublicFunc.OpenDir_Show()) == null)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;

            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait("", false);
            frm.ShowDialog();
            Frm_Action_Load(this, null);

        }

        private void BT_OutPort_Click(object sender, EventArgs e)
        {
            if ((FileName = PublicFunc.SfD_Show()) == null)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;

            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollOutport));
            Frm_Wait frm = new Frm_Wait("", false);
            frm.ShowDialog();

        }

        void PollImport(object target)
        {
            //TxtData.PublicData.ErrorCode = db.ImportAction(FileName) == 0 ? 40 : 18;

        }


        void PollOutport(object target)
        {

            //TxtData.PublicData.ErrorCode = db.SaveAction(FileName) ? 40 : 2;
                        
        }

        private void CB_RobotIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv.Columns.Clear();
            GC_Modbus.DataSource = db.GetDV_Action();
            //去除其中的列和题头
            //   GC_Modbus.
            
            if (gv.RowCount > 12)
            {
                gv.Columns.Remove(gv.Columns["ID"]);
                gv.Columns.Remove(gv.Columns["REMARK"]);


                                

                for (int i = 1; i < 21; i++)
                {
                    if (i >= ((CB_RobotIndex.SelectedIndex) * 3 + 1) && i <= (CB_RobotIndex.SelectedIndex + 1) * 3)
                    {
                    }
                    else
                    {
                        gv.Columns.Remove(gv.Columns["IO" + i.ToString()]);
                    }

                } for (int i = 1; i < 5; i++)
                {
                    if (i!=CB_RobotIndex.SelectedIndex+1)
                    {
                        gv.Columns.Remove(gv.Columns["BP" + i.ToString()]);
                    }
                    
                
                }
                gv.Columns["INDEX"].Caption = "序号";
                gv.Columns["BP"+(CB_RobotIndex.SelectedIndex+1).ToString()].Caption = "备注";
                gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

                for (int i = 1; i <= 3; i++)
                {
                    gv.Columns["IO" + (CB_RobotIndex.SelectedIndex * 3 + i).ToString()].Caption = "动作" + i.ToString();
                }
            }



                        
        }


    }
}
