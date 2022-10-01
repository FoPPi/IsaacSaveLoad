namespace IsaacSaveLoad
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.CloseLable = new System.Windows.Forms.Label();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.SavedPicture = new System.Windows.Forms.PictureBox();
            this.LoadedPicture = new System.Windows.Forms.PictureBox();
            this.SelectSavePicture = new System.Windows.Forms.PictureBox();
            this.SelectLoadPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SavedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSavePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectLoadPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.Color.Transparent;
            this.SaveButton.Location = new System.Drawing.Point(103, 236);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 44);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.MouseLeave += new System.EventHandler(this.SaveButton_MouseLeave);
            this.SaveButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SaveButton_MouseMove);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Transparent;
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.ForeColor = System.Drawing.Color.Transparent;
            this.LoadButton.Location = new System.Drawing.Point(122, 298);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(131, 54);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            this.LoadButton.MouseLeave += new System.EventHandler(this.LoadButton_MouseLeave);
            this.LoadButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoadButton_MouseMove);
            // 
            // CloseLable
            // 
            this.CloseLable.AutoSize = true;
            this.CloseLable.BackColor = System.Drawing.Color.Transparent;
            this.CloseLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLable.Location = new System.Drawing.Point(315, 9);
            this.CloseLable.Name = "CloseLable";
            this.CloseLable.Size = new System.Drawing.Size(18, 17);
            this.CloseLable.TabIndex = 5;
            this.CloseLable.Text = "X";
            this.CloseLable.Click += new System.EventHandler(this.CloseLable_Click);
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.Transparent;
            this.MovePanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.MovePanel.Location = new System.Drawing.Point(-1, -1);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(347, 27);
            this.MovePanel.TabIndex = 7;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.MovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // SavedPicture
            // 
            this.SavedPicture.BackColor = System.Drawing.Color.Transparent;
            this.SavedPicture.Image = global::IsaacSaveLoad.Properties.Resources._777;
            this.SavedPicture.Location = new System.Drawing.Point(103, 175);
            this.SavedPicture.Name = "SavedPicture";
            this.SavedPicture.Size = new System.Drawing.Size(107, 43);
            this.SavedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SavedPicture.TabIndex = 8;
            this.SavedPicture.TabStop = false;
            this.SavedPicture.Visible = false;
            // 
            // LoadedPicture
            // 
            this.LoadedPicture.BackColor = System.Drawing.Color.Transparent;
            this.LoadedPicture.Image = global::IsaacSaveLoad.Properties.Resources._888;
            this.LoadedPicture.Location = new System.Drawing.Point(103, 167);
            this.LoadedPicture.Name = "LoadedPicture";
            this.LoadedPicture.Size = new System.Drawing.Size(110, 51);
            this.LoadedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadedPicture.TabIndex = 9;
            this.LoadedPicture.TabStop = false;
            this.LoadedPicture.Visible = false;
            // 
            // SelectSavePicture
            // 
            this.SelectSavePicture.BackColor = System.Drawing.Color.Transparent;
            this.SelectSavePicture.Image = global::IsaacSaveLoad.Properties.Resources._375909238;
            this.SelectSavePicture.Location = new System.Drawing.Point(40, 242);
            this.SelectSavePicture.Name = "SelectSavePicture";
            this.SelectSavePicture.Size = new System.Drawing.Size(100, 50);
            this.SelectSavePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectSavePicture.TabIndex = 10;
            this.SelectSavePicture.TabStop = false;
            this.SelectSavePicture.Visible = false;
            // 
            // SelectLoadPicture
            // 
            this.SelectLoadPicture.BackColor = System.Drawing.Color.Transparent;
            this.SelectLoadPicture.Image = global::IsaacSaveLoad.Properties.Resources._375909238;
            this.SelectLoadPicture.Location = new System.Drawing.Point(50, 312);
            this.SelectLoadPicture.Name = "SelectLoadPicture";
            this.SelectLoadPicture.Size = new System.Drawing.Size(100, 50);
            this.SelectLoadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectLoadPicture.TabIndex = 11;
            this.SelectLoadPicture.TabStop = false;
            this.SelectLoadPicture.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.BackgroundImage = global::IsaacSaveLoad.Properties.Resources._999;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(345, 459);
            this.ControlBox = false;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseLable);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.SelectSavePicture);
            this.Controls.Add(this.SelectLoadPicture);
            this.Controls.Add(this.LoadedPicture);
            this.Controls.Add(this.SavedPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Isaac Save/Load";
            ((System.ComponentModel.ISupportInitialize)(this.SavedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSavePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectLoadPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label CloseLable;
        private System.Windows.Forms.Panel MovePanel;
        private System.Windows.Forms.PictureBox SavedPicture;
        private System.Windows.Forms.PictureBox LoadedPicture;
        private System.Windows.Forms.PictureBox SelectSavePicture;
        private System.Windows.Forms.PictureBox SelectLoadPicture;
    }
}

