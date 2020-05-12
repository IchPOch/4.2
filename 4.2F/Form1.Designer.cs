namespace _4._2F
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
            this.N = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.j = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(0, 78);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(100, 20);
            this.N.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите N";
            // 
            // j
            // 
            this.j.Location = new System.Drawing.Point(0, 104);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(75, 23);
            this.j.TabIndex = 2;
            this.j.Text = "Жмак";
            this.j.UseVisualStyleBackColor = true;
            this.j.Click += new System.EventHandler(this.j_Click);
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(144, 12);
            this.V.Multiline = true;
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Size = new System.Drawing.Size(795, 671);
            this.V.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 596);
            this.Controls.Add(this.V);
            this.Controls.Add(this.j);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button j;
        private System.Windows.Forms.TextBox V;
    }
}

