using System.Windows.Forms;

namespace SwissTransport
{
    partial class FrmMain
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
            this.lblvon = new System.Windows.Forms.Label();
            this.lblnach = new System.Windows.Forms.Label();
            this.cboxvon = new System.Windows.Forms.ComboBox();
            this.cboxnach = new System.Windows.Forms.ComboBox();
            this.btnchange = new System.Windows.Forms.Button();
            this.lview = new System.Windows.Forms.Button();
            this.dtetimecal = new System.Windows.Forms.DateTimePicker();
            this.dtetimeclock = new System.Windows.Forms.DateTimePicker();
            this.liview = new System.Windows.Forms.ListView();
            this.clmabfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmankunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmdauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmgleis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnplananzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvon
            // 
            this.lblvon.AutoSize = true;
            this.lblvon.Location = new System.Drawing.Point(25, 40);
            this.lblvon.Name = "lblvon";
            this.lblvon.Size = new System.Drawing.Size(26, 13);
            this.lblvon.TabIndex = 0;
            this.lblvon.Text = "Von";
            // 
            // lblnach
            // 
            this.lblnach.AutoSize = true;
            this.lblnach.Location = new System.Drawing.Point(419, 40);
            this.lblnach.Name = "lblnach";
            this.lblnach.Size = new System.Drawing.Size(33, 13);
            this.lblnach.TabIndex = 1;
            this.lblnach.Text = "Nach";
            // 
            // cboxvon
            // 
            this.cboxvon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxvon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxvon.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cboxvon.FormattingEnabled = true;
            this.cboxvon.Location = new System.Drawing.Point(28, 56);
            this.cboxvon.Name = "cboxvon";
            this.cboxvon.Size = new System.Drawing.Size(217, 21);
            this.cboxvon.TabIndex = 2;
            this.cboxvon.DropDown += new System.EventHandler(this.cboxload_DropDown);
            // 
            // cboxnach
            // 
            this.cboxnach.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cboxnach.FormattingEnabled = true;
            this.cboxnach.Location = new System.Drawing.Point(422, 56);
            this.cboxnach.Name = "cboxnach";
            this.cboxnach.Size = new System.Drawing.Size(217, 21);
            this.cboxnach.TabIndex = 3;
            this.cboxnach.DropDown += new System.EventHandler(this.cboxload_DropDown);
            // 
            // btnchange
            // 
            this.btnchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchange.Location = new System.Drawing.Point(303, 40);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(75, 48);
            this.btnchange.TabIndex = 4;
            this.btnchange.Text = "⟺";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // lview
            // 
            this.lview.BackColor = System.Drawing.SystemColors.Control;
            this.lview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lview.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lview.Location = new System.Drawing.Point(675, 40);
            this.lview.Name = "lview";
            this.lview.Size = new System.Drawing.Size(205, 48);
            this.lview.TabIndex = 5;
            this.lview.Text = "Verbindung suchen";
            this.lview.UseVisualStyleBackColor = false;
            this.lview.Click += new System.EventHandler(this.Btnsuchen_Click);
            // 
            // dtetimecal
            // 
            this.dtetimecal.Location = new System.Drawing.Point(28, 107);
            this.dtetimecal.Name = "dtetimecal";
            this.dtetimecal.Size = new System.Drawing.Size(217, 20);
            this.dtetimecal.TabIndex = 6;
            // 
            // dtetimeclock
            // 
            this.dtetimeclock.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtetimeclock.Location = new System.Drawing.Point(303, 107);
            this.dtetimeclock.Name = "dtetimeclock";
            this.dtetimeclock.ShowUpDown = true;
            this.dtetimeclock.Size = new System.Drawing.Size(75, 20);
            this.dtetimeclock.TabIndex = 7;
            // 
            // liview
            // 
            this.liview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmabfahrt,
            this.clmankunft,
            this.clmdauer,
            this.clmgleis});
            this.liview.Location = new System.Drawing.Point(28, 173);
            this.liview.Name = "liview";
            this.liview.Size = new System.Drawing.Size(852, 246);
            this.liview.TabIndex = 8;
            this.liview.UseCompatibleStateImageBehavior = false;
            this.liview.View = System.Windows.Forms.View.Details;
            // 
            // clmabfahrt
            // 
            this.clmabfahrt.Text = "Abfahrt";
            this.clmabfahrt.Width = 180;
            // 
            // clmankunft
            // 
            this.clmankunft.Text = "Ankunft";
            this.clmankunft.Width = 180;
            // 
            // clmdauer
            // 
            this.clmdauer.Text = "Dauer";
            this.clmdauer.Width = 100;
            // 
            // clmgleis
            // 
            this.clmgleis.Text = "Gleis";
            // 
            // btnplananzeigen
            // 
            this.btnplananzeigen.BackColor = System.Drawing.SystemColors.Control;
            this.btnplananzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplananzeigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnplananzeigen.Location = new System.Drawing.Point(675, 94);
            this.btnplananzeigen.Name = "btnplananzeigen";
            this.btnplananzeigen.Size = new System.Drawing.Size(205, 48);
            this.btnplananzeigen.TabIndex = 9;
            this.btnplananzeigen.Text = "Fahrplan anzeigen";
            this.btnplananzeigen.UseVisualStyleBackColor = false;
            this.btnplananzeigen.Click += new System.EventHandler(this.btnplananzeigen_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 431);
            this.Controls.Add(this.btnplananzeigen);
            this.Controls.Add(this.liview);
            this.Controls.Add(this.dtetimeclock);
            this.Controls.Add(this.dtetimecal);
            this.Controls.Add(this.lview);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.cboxnach);
            this.Controls.Add(this.cboxvon);
            this.Controls.Add(this.lblnach);
            this.Controls.Add(this.lblvon);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schweizer Fahrplan";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvon;
        private System.Windows.Forms.Label lblnach;
        private System.Windows.Forms.ComboBox cboxvon;
        private System.Windows.Forms.ComboBox cboxnach;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button lview;
        private System.Windows.Forms.DateTimePicker dtetimecal;
        private System.Windows.Forms.DateTimePicker dtetimeclock;
        private ListView liview;
        private Button btnplananzeigen;
        private ColumnHeader clmgleis;
        private ColumnHeader clmabfahrt;
        private ColumnHeader clmankunft;
        private ColumnHeader clmdauer;
    }
}