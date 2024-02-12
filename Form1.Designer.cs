namespace ListBoxes
{
    partial class Form1
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
            this.listLeft = new System.Windows.Forms.ListBox();
            this.listRight = new System.Windows.Forms.ListBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonAllRight = new System.Windows.Forms.Button();
            this.buttonAllLeft = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLeft
            // 
            this.listLeft.AllowDrop = true;
            this.listLeft.FormattingEnabled = true;
            this.listLeft.ItemHeight = 16;
            this.listLeft.Location = new System.Drawing.Point(12, 12);
            this.listLeft.Name = "listLeft";
            this.listLeft.Size = new System.Drawing.Size(180, 196);
            this.listLeft.TabIndex = 0;
            this.listLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.listLeft_DragDrop);
            this.listLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_DragEnter);
            this.listLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listLeft_MouseDown);
            // 
            // listRight
            // 
            this.listRight.AllowDrop = true;
            this.listRight.FormattingEnabled = true;
            this.listRight.ItemHeight = 16;
            this.listRight.Location = new System.Drawing.Point(264, 12);
            this.listRight.Name = "listRight";
            this.listRight.Size = new System.Drawing.Size(180, 196);
            this.listRight.TabIndex = 1;
            this.listRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.listRight_DragDrop);
            this.listRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_DragEnter);
            this.listRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listRight_MouseDown);
            // 
            // buttonRight
            // 
            this.buttonRight.Enabled = false;
            this.buttonRight.Location = new System.Drawing.Point(207, 52);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 25);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonAllRight
            // 
            this.buttonAllRight.Location = new System.Drawing.Point(207, 81);
            this.buttonAllRight.Name = "buttonAllRight";
            this.buttonAllRight.Size = new System.Drawing.Size(40, 25);
            this.buttonAllRight.TabIndex = 2;
            this.buttonAllRight.Text = ">>";
            this.buttonAllRight.UseVisualStyleBackColor = true;
            this.buttonAllRight.Click += new System.EventHandler(this.buttonAllRight_Click);
            // 
            // buttonAllLeft
            // 
            this.buttonAllLeft.Location = new System.Drawing.Point(207, 110);
            this.buttonAllLeft.Name = "buttonAllLeft";
            this.buttonAllLeft.Size = new System.Drawing.Size(40, 25);
            this.buttonAllLeft.TabIndex = 2;
            this.buttonAllLeft.Text = "<<";
            this.buttonAllLeft.UseVisualStyleBackColor = true;
            this.buttonAllLeft.Click += new System.EventHandler(this.buttonAllLeft_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Enabled = false;
            this.buttonLeft.Location = new System.Drawing.Point(207, 139);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 25);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 222);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonAllLeft);
            this.Controls.Add(this.buttonAllRight);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.listRight);
            this.Controls.Add(this.listLeft);
            this.Name = "Form1";
            this.Text = "ListBoxes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLeft;
        private System.Windows.Forms.ListBox listRight;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonAllRight;
        private System.Windows.Forms.Button buttonAllLeft;
        private System.Windows.Forms.Button buttonLeft;
    }
}

