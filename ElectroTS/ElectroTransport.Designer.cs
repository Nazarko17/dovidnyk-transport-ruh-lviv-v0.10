using System;

namespace ElectroTS
{
    partial class ElectroTransport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTransportID = new System.Windows.Forms.Label();
            this.txtFinish2 = new System.Windows.Forms.TextBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtFinish1 = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStops1 = new System.Windows.Forms.TextBox();
            this.lblStops1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.nudTranportID = new System.Windows.Forms.NumericUpDown();
            this.lblVersion = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStops2 = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStops2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranportID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransportID
            // 
            this.lblTransportID.AutoSize = true;
            this.lblTransportID.BackColor = System.Drawing.Color.Transparent;
            this.lblTransportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransportID.ForeColor = System.Drawing.Color.Lavender;
            this.lblTransportID.Location = new System.Drawing.Point(33, 134);
            this.lblTransportID.Name = "lblTransportID";
            this.lblTransportID.Size = new System.Drawing.Size(25, 20);
            this.lblTransportID.TabIndex = 1;
            this.lblTransportID.Text = "№";
            // 
            // txtFinish2
            // 
            this.txtFinish2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFinish2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtFinish2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFinish2.Location = new System.Drawing.Point(20, 299);
            this.txtFinish2.Name = "txtFinish2";
            this.txtFinish2.Size = new System.Drawing.Size(201, 26);
            this.txtFinish2.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtFinish2, "Введіть кінцеву зупинку №2");
            this.txtFinish2.TextChanged += new System.EventHandler(this.TxtFinish2_TextChanged);
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.BackColor = System.Drawing.Color.Transparent;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinish.Location = new System.Drawing.Point(166, 380);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(0, 20);
            this.lblFinish.TabIndex = 3;
            // 
            // txtInterval
            // 
            this.txtInterval.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtInterval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInterval.Location = new System.Drawing.Point(146, 157);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(75, 26);
            this.txtInterval.TabIndex = 6;
            this.toolTip.SetToolTip(this.txtInterval, "Введіть інтервал руху");
            this.txtInterval.TextChanged += new System.EventHandler(this.TxtInterval_TextChanged);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.BackColor = System.Drawing.Color.Transparent;
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInterval.ForeColor = System.Drawing.Color.Lavender;
            this.lblInterval.Location = new System.Drawing.Point(142, 133);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(86, 20);
            this.lblInterval.TabIndex = 5;
            this.lblInterval.Text = "Інтервал";
            // 
            // txtFinish1
            // 
            this.txtFinish1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFinish1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtFinish1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFinish1.Location = new System.Drawing.Point(20, 267);
            this.txtFinish1.Name = "txtFinish1";
            this.txtFinish1.Size = new System.Drawing.Size(201, 26);
            this.txtFinish1.TabIndex = 8;
            this.toolTip.SetToolTip(this.txtFinish1, "Введіть кінцеву зупинку №1");
            this.txtFinish1.TextChanged += new System.EventHandler(this.TxtFinish1_TextChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.ForeColor = System.Drawing.Color.Lavender;
            this.lblStart.Location = new System.Drawing.Point(52, 246);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(139, 20);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Кінцеві зупинки";
            // 
            // txtStops1
            // 
            this.txtStops1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStops1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStops1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStops1.Location = new System.Drawing.Point(241, 156);
            this.txtStops1.Multiline = true;
            this.txtStops1.Name = "txtStops1";
            this.txtStops1.Size = new System.Drawing.Size(201, 169);
            this.txtStops1.TabIndex = 10;
            this.toolTip.SetToolTip(this.txtStops1, "Введіть зупинки прямого маршруту");
            this.txtStops1.TextChanged += new System.EventHandler(this.TxtStops1_TextChanged);
            // 
            // lblStops1
            // 
            this.lblStops1.AutoSize = true;
            this.lblStops1.BackColor = System.Drawing.Color.Transparent;
            this.lblStops1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStops1.ForeColor = System.Drawing.Color.Lavender;
            this.lblStops1.Location = new System.Drawing.Point(250, 133);
            this.lblStops1.Name = "lblStops1";
            this.lblStops1.Size = new System.Drawing.Size(183, 20);
            this.lblStops1.TabIndex = 9;
            this.lblStops1.Text = "Зупинки(прямий рух)";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Тролейбус",
            "Трамвай"});
            this.cmbType.Location = new System.Drawing.Point(20, 211);
            this.cmbType.MaxDropDownItems = 2;
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(201, 28);
            this.cmbType.TabIndex = 11;
            this.toolTip.SetToolTip(this.cmbType, "Оберіть тип електричного транспорту");
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.ForeColor = System.Drawing.Color.Lavender;
            this.lblType.Location = new System.Drawing.Point(50, 188);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(141, 20);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Тип транспорту";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(56, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 41);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Додати";
            this.toolTip.SetToolTip(this.btnAdd, "Натисніть, щоб додати новий маршрут");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 3;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(278, 426);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 41);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Оновити";
            this.toolTip.SetToolTip(this.btnUpdate, "Натисніть, щоб оновити доданий маршрут");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(278, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 41);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Очистити";
            this.toolTip.SetToolTip(this.btnClear, "Натисніть, щоб очистити текстові поля");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(501, 426);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 41);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Видалити";
            this.toolTip.SetToolTip(this.btnDelete, "Натисніть, щоб видалити доданий маршрут");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // dgvContactList
            // 
            this.dgvContactList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvContactList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContactList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvContactList.ColumnHeadersHeight = 30;
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContactList.EnableHeadersVisualStyles = false;
            this.dgvContactList.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvContactList.Location = new System.Drawing.Point(680, 188);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactList.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.dgvContactList.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvContactList.Size = new System.Drawing.Size(838, 279);
            this.dgvContactList.TabIndex = 17;
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(1069, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Пошук";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.Location = new System.Drawing.Point(680, 156);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(838, 26);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Lavender;
            this.lblLogo.Location = new System.Drawing.Point(187, 67);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(1160, 40);
            this.lblLogo.TabIndex = 20;
            this.lblLogo.Text = "ДОВІДНИК РУХУ ЕЛЕКТРИЧНОГО ТРАНСПОРТУ МІСТА ЛЬВОВА";
            // 
            // nudTranportID
            // 
            this.nudTranportID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nudTranportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTranportID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nudTranportID.Location = new System.Drawing.Point(20, 157);
            this.nudTranportID.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.nudTranportID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTranportID.Name = "nudTranportID";
            this.nudTranportID.Size = new System.Drawing.Size(54, 26);
            this.nudTranportID.TabIndex = 21;
            this.toolTip.SetToolTip(this.nudTranportID, "Введіть номер транспорту");
            this.nudTranportID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTranportID.ValueChanged += new System.EventHandler(this.NudTranportID_ValueChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersion.ForeColor = System.Drawing.Color.Lavender;
            this.lblVersion.Location = new System.Drawing.Point(1416, 482);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(102, 15);
            this.lblVersion.TabIndex = 22;
            this.lblVersion.Text = "Бета-версія 0.12";
            this.lblVersion.MouseEnter += new System.EventHandler(this.lblVersion_MouseEnter);
            this.lblVersion.MouseLeave += new System.EventHandler(this.lblVersion_MouseLeave);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Підказка";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btnExit.Location = new System.Drawing.Point(1481, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 46);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "X";
            this.toolTip.SetToolTip(this.btnExit, "Закрити програму");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(1424, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "—";
            this.toolTip.SetToolTip(this.button1, "Згорнути програму");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // txtStops2
            // 
            this.txtStops2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStops2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtStops2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStops2.Location = new System.Drawing.Point(462, 156);
            this.txtStops2.Multiline = true;
            this.txtStops2.Name = "txtStops2";
            this.txtStops2.Size = new System.Drawing.Size(201, 169);
            this.txtStops2.TabIndex = 25;
            this.toolTip.SetToolTip(this.txtStops2, "Введіть зупинки зворотнього маршруту");
            this.txtStops2.TextChanged += new System.EventHandler(this.TxtStops2_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrice.Location = new System.Drawing.Point(80, 157);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(60, 26);
            this.txtPrice.TabIndex = 27;
            this.toolTip.SetToolTip(this.txtPrice, "Введіть вартість проїзду");
            this.txtPrice.TextChanged += new System.EventHandler(this.TxtPrice_TextChanged);
            // 
            // lblStops2
            // 
            this.lblStops2.AutoSize = true;
            this.lblStops2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStops2.ForeColor = System.Drawing.Color.Lavender;
            this.lblStops2.Location = new System.Drawing.Point(459, 134);
            this.lblStops2.Name = "lblStops2";
            this.lblStops2.Size = new System.Drawing.Size(204, 20);
            this.lblStops2.TabIndex = 26;
            this.lblStops2.Text = "Зупинки(зворотній рух)";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.Lavender;
            this.lblPrice.Location = new System.Drawing.Point(85, 133);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 20);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "Ціна";
            // 
            // ElectroTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1544, 506);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblStops2);
            this.Controls.Add(this.txtStops2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.nudTranportID);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtStops1);
            this.Controls.Add(this.lblStops1);
            this.Controls.Add(this.txtFinish1);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.txtFinish2);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblTransportID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ElectroTransport";
            this.Text = "Довідник руху електричного транспорту м. Львова";
            this.Load += new System.EventHandler(this.MarshrutDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranportID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTransportID;
        private System.Windows.Forms.TextBox txtFinish2;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox txtFinish1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStops1;
        private System.Windows.Forms.Label lblStops1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.NumericUpDown nudTranportID;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStops2;
        private System.Windows.Forms.Label lblStops2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}

