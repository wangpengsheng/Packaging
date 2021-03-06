﻿namespace Packaging
{
    partial class Frm_IOConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_RobotIndex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LL_Task = new System.Windows.Forms.Label();
            this.GC_Modbus = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Modbus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_RobotIndex
            // 
            this.CB_RobotIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_RobotIndex.FormattingEnabled = true;
            this.CB_RobotIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CB_RobotIndex.Location = new System.Drawing.Point(94, 530);
            this.CB_RobotIndex.Name = "CB_RobotIndex";
            this.CB_RobotIndex.Size = new System.Drawing.Size(121, 21);
            this.CB_RobotIndex.TabIndex = 9;
            this.CB_RobotIndex.SelectedIndexChanged += new System.EventHandler(this.CB_RobotCount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "当前机器人:";
            // 
            // LL_Task
            // 
            this.LL_Task.AutoSize = true;
            this.LL_Task.Location = new System.Drawing.Point(290, 534);
            this.LL_Task.Name = "LL_Task";
            this.LL_Task.Size = new System.Drawing.Size(67, 13);
            this.LL_Task.TabIndex = 10;
            this.LL_Task.Text = "当前任务：";
            // 
            // GC_Modbus
            // 
            this.GC_Modbus.Dock = System.Windows.Forms.DockStyle.Top;
            this.GC_Modbus.Location = new System.Drawing.Point(0, 0);
            this.GC_Modbus.MainView = this.gv;
            this.GC_Modbus.Name = "GC_Modbus";
            this.GC_Modbus.Size = new System.Drawing.Size(1027, 524);
            this.GC_Modbus.TabIndex = 11;
            this.GC_Modbus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.ActiveFilterEnabled = false;
            this.gv.GridControl = this.GC_Modbus;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsCustomization.AllowColumnMoving = false;
            this.gv.OptionsCustomization.AllowFilter = false;
            this.gv.OptionsCustomization.AllowGroup = false;
            this.gv.OptionsCustomization.AllowSort = false;
            this.gv.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv.OptionsView.EnableAppearanceOddRow = true;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.SynchronizeClones = false;
            this.gv.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_RowCellClick);
            // 
            // Frm_IOConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.GC_Modbus);
            this.Controls.Add(this.LL_Task);
            this.Controls.Add(this.CB_RobotIndex);
            this.Controls.Add(this.label1);
            this.Name = "Frm_IOConfig";
            this.Text = "Frm_IOConfig";
            ((System.ComponentModel.ISupportInitialize)(this.GC_Modbus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_RobotIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LL_Task;
        public DevExpress.XtraGrid.GridControl GC_Modbus;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
    }
}