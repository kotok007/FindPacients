namespace base_bsmp
{
    partial class settingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingForm));
            this.textBoxPatchDB = new System.Windows.Forms.TextBox();
            this.exitApplication = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.openFileDialogDB = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // textBoxPatchDB
            // 
            this.textBoxPatchDB.Enabled = false;
            this.textBoxPatchDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatchDB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPatchDB.Location = new System.Drawing.Point(13, 44);
            this.textBoxPatchDB.Name = "textBoxPatchDB";
            this.textBoxPatchDB.ReadOnly = true;
            this.textBoxPatchDB.Size = new System.Drawing.Size(618, 31);
            this.textBoxPatchDB.TabIndex = 12;
            // 
            // exitApplication
            // 
            this.exitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitApplication.Image = ((System.Drawing.Image)(resources.GetObject("exitApplication.Image")));
            this.exitApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitApplication.Location = new System.Drawing.Point(416, 146);
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exitApplication.Size = new System.Drawing.Size(215, 59);
            this.exitApplication.TabIndex = 11;
            this.exitApplication.Text = "Закрыть приложение";
            this.exitApplication.UseVisualStyleBackColor = true;
            this.exitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpen.Location = new System.Drawing.Point(13, 81);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOpen.Size = new System.Drawing.Size(176, 59);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Обзор";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(416, 146);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCancel.Size = new System.Drawing.Size(176, 59);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(234, 146);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSave.Size = new System.Drawing.Size(176, 59);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.Image = ((System.Drawing.Image)(resources.GetObject("buttonCheck.Image")));
            this.buttonCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheck.Location = new System.Drawing.Point(13, 146);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCheck.Size = new System.Drawing.Size(215, 59);
            this.buttonCheck.TabIndex = 7;
            this.buttonCheck.Text = "Проверить подключение";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // openFileDialogDB
            // 
            this.openFileDialogDB.Filter = "Файл БД (.db)|*.db";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusStrip1.Location = new System.Drawing.Point(0, 203);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(676, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(676, 225);
            this.Controls.Add(this.textBoxPatchDB);
            this.Controls.Add(this.exitApplication);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки программы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxPatchDB;
        public System.Windows.Forms.Button exitApplication;
        public System.Windows.Forms.Button buttonOpen;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialogDB;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}