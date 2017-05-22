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
            this.cboxfrom = new System.Windows.Forms.ComboBox();
            this.cboxto = new System.Windows.Forms.ComboBox();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dtetimecal = new System.Windows.Forms.DateTimePicker();
            this.dtetimeclock = new System.Windows.Forms.DateTimePicker();
            this.liview = new System.Windows.Forms.ListView();
            this.clmabfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmankunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmdauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmgleis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnshowtable = new System.Windows.Forms.Button();
            this.btnshowmapsstart = new System.Windows.Forms.Button();
            this.btnshowmapsend = new System.Windows.Forms.Button();
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
            // cboxfrom
            // 
            this.cboxfrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboxfrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxfrom.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cboxfrom.FormattingEnabled = true;
            this.cboxfrom.Location = new System.Drawing.Point(28, 56);
            this.cboxfrom.Name = "cboxfrom";
            this.cboxfrom.Size = new System.Drawing.Size(217, 21);
            this.cboxfrom.TabIndex = 0;
            this.cboxfrom.DropDown += new System.EventHandler(this.cboxload_DropDown);
            this.cboxfrom.TextChanged += new System.EventHandler(this.cbox_TextChanged);
            // 
            // cboxto
            // 
            this.cboxto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cboxto.FormattingEnabled = true;
            this.cboxto.Location = new System.Drawing.Point(422, 56);
            this.cboxto.Name = "cboxto";
            this.cboxto.Size = new System.Drawing.Size(217, 21);
            this.cboxto.TabIndex = 2;
            this.cboxto.DropDown += new System.EventHandler(this.cboxload_DropDown);
            this.cboxto.TextChanged += new System.EventHandler(this.cbox_TextChanged);
            // 
            // btnchange
            // 
            this.btnchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchange.Location = new System.Drawing.Point(303, 40);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(75, 48);
            this.btnchange.TabIndex = 1;
            this.btnchange.Text = "⟺";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnsearch.Enabled = false;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.Location = new System.Drawing.Point(675, 40);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(205, 48);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Verbindung suchen";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // dtetimecal
            // 
            this.dtetimecal.Location = new System.Drawing.Point(28, 107);
            this.dtetimecal.Name = "dtetimecal";
            this.dtetimecal.Size = new System.Drawing.Size(217, 20);
            this.dtetimecal.TabIndex = 3;
            // 
            // dtetimeclock
            // 
            this.dtetimeclock.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtetimeclock.Location = new System.Drawing.Point(303, 107);
            this.dtetimeclock.Name = "dtetimeclock";
            this.dtetimeclock.ShowUpDown = true;
            this.dtetimeclock.Size = new System.Drawing.Size(75, 20);
            this.dtetimeclock.TabIndex = 4;
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
            // btnshowtable
            // 
            this.btnshowtable.BackColor = System.Drawing.SystemColors.Control;
            this.btnshowtable.Enabled = false;
            this.btnshowtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowtable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnshowtable.Location = new System.Drawing.Point(675, 94);
            this.btnshowtable.Name = "btnshowtable";
            this.btnshowtable.Size = new System.Drawing.Size(205, 48);
            this.btnshowtable.TabIndex = 6;
            this.btnshowtable.Text = "Fahrplan anzeigen";
            this.btnshowtable.UseVisualStyleBackColor = false;
            this.btnshowtable.Click += new System.EventHandler(this.btnshowtable_Click);
            // 
            // btnshowmapsstart
            // 
            this.btnshowmapsstart.Location = new System.Drawing.Point(28, 78);
            this.btnshowmapsstart.Name = "btnshowmapsstart";
            this.btnshowmapsstart.Size = new System.Drawing.Size(217, 23);
            this.btnshowmapsstart.TabIndex = 9;
            this.btnshowmapsstart.Text = "Abfahrtsort anzeigen(Maps)";
            this.btnshowmapsstart.UseVisualStyleBackColor = true;
            this.btnshowmapsstart.Click += new System.EventHandler(this.btnshowmapsfrom_Click);
            // 
            // btnshowmapsend
            // 
            this.btnshowmapsend.Location = new System.Drawing.Point(422, 78);
            this.btnshowmapsend.Name = "btnshowmapsend";
            this.btnshowmapsend.Size = new System.Drawing.Size(217, 23);
            this.btnshowmapsend.TabIndex = 10;
            this.btnshowmapsend.Text = "Ankunftsort anzeigen(Maps)";
            this.btnshowmapsend.UseVisualStyleBackColor = true;
            this.btnshowmapsend.Click += new System.EventHandler(this.btnshowmapsto_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 431);
            this.Controls.Add(this.btnshowmapsend);
            this.Controls.Add(this.btnshowmapsstart);
            this.Controls.Add(this.btnshowtable);
            this.Controls.Add(this.liview);
            this.Controls.Add(this.dtetimeclock);
            this.Controls.Add(this.dtetimecal);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.cboxto);
            this.Controls.Add(this.cboxfrom);
            this.Controls.Add(this.lblnach);
            this.Controls.Add(this.lblvon);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schweizer Fahrplan";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TextChanged += new System.EventHandler(this.cbox_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvon;
        private System.Windows.Forms.Label lblnach;
        private System.Windows.Forms.ComboBox cboxfrom;
        private System.Windows.Forms.ComboBox cboxto;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DateTimePicker dtetimecal;
        private System.Windows.Forms.DateTimePicker dtetimeclock;
        private ListView liview;
        private Button btnshowtable;
        private ColumnHeader clmgleis;
        private ColumnHeader clmabfahrt;
        private ColumnHeader clmankunft;
        private ColumnHeader clmdauer;
        private Button btnshowmapsstart;
        private Button btnshowmapsend;
    }
}