namespace Lab08
{
    partial class fMain
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
            this.tbBikeInfo = new System.Windows.Forms.TextBox();
            this.btnAddBike = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // tbBikeInfo
            // 
            this.tbBikeInfo.Location = new System.Drawing.Point(12, 12);
            this.tbBikeInfo.Multiline = true;
            this.tbBikeInfo.Name = "tbBikeInfo";
            this.tbBikeInfo.ReadOnly = true;
            this.tbBikeInfo.Size = new System.Drawing.Size(588, 409);
            this.tbBikeInfo.TabIndex = 0;
            this.tbBikeInfo.TextChanged += new System.EventHandler(this.tbBikeInfo_TextChanged);
            // 
            // btnAddBike
            // 
            this.btnAddBike.Location = new System.Drawing.Point(640, 29);
            this.btnAddBike.Name = "btnAddBike";
            this.btnAddBike.Size = new System.Drawing.Size(148, 31);
            this.btnAddBike.TabIndex = 1;
            this.btnAddBike.Text = "Додати велосипед";
            this.btnAddBike.UseVisualStyleBackColor = true;
            this.btnAddBike.Click += new System.EventHandler(this.btnAddBike_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(640, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddBike);
            this.Controls.Add(this.tbBikeInfo);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"Лабораторна робота №8\"";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBikeInfo;
        private System.Windows.Forms.Button btnAddBike;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

