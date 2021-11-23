
namespace EzCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sumCredit_tb = new System.Windows.Forms.TextBox();
            this.perStavka_tb = new System.Windows.Forms.TextBox();
            this.timeInYear_tb = new System.Windows.Forms.TextBox();
            this.timeInMonth_tb = new System.Windows.Forms.TextBox();
            this.payInMount_tb = new System.Windows.Forms.TextBox();
            this.sumPay_tb = new System.Windows.Forms.TextBox();
            this.sumOverPay_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кредитный калькулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма кредита";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Процентная ставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Срок в годах";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Срок в месяцах";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Выплата в месяц";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Сумма переплаты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Общая сумма выплат ";
            // 
            // sumCredit_tb
            // 
            this.sumCredit_tb.Location = new System.Drawing.Point(223, 84);
            this.sumCredit_tb.Name = "sumCredit_tb";
            this.sumCredit_tb.Size = new System.Drawing.Size(173, 20);
            this.sumCredit_tb.TabIndex = 2;
            // 
            // perStavka_tb
            // 
            this.perStavka_tb.Location = new System.Drawing.Point(223, 110);
            this.perStavka_tb.Name = "perStavka_tb";
            this.perStavka_tb.Size = new System.Drawing.Size(173, 20);
            this.perStavka_tb.TabIndex = 3;
            // 
            // timeInYear_tb
            // 
            this.timeInYear_tb.Location = new System.Drawing.Point(223, 144);
            this.timeInYear_tb.Name = "timeInYear_tb";
            this.timeInYear_tb.Size = new System.Drawing.Size(173, 20);
            this.timeInYear_tb.TabIndex = 4;
            // 
            // timeInMonth_tb
            // 
            this.timeInMonth_tb.Location = new System.Drawing.Point(223, 170);
            this.timeInMonth_tb.Name = "timeInMonth_tb";
            this.timeInMonth_tb.ReadOnly = true;
            this.timeInMonth_tb.Size = new System.Drawing.Size(173, 20);
            this.timeInMonth_tb.TabIndex = 4;
            // 
            // payInMount_tb
            // 
            this.payInMount_tb.Location = new System.Drawing.Point(223, 209);
            this.payInMount_tb.Name = "payInMount_tb";
            this.payInMount_tb.ReadOnly = true;
            this.payInMount_tb.Size = new System.Drawing.Size(173, 20);
            this.payInMount_tb.TabIndex = 4;
            // 
            // sumPay_tb
            // 
            this.sumPay_tb.Location = new System.Drawing.Point(223, 235);
            this.sumPay_tb.Name = "sumPay_tb";
            this.sumPay_tb.ReadOnly = true;
            this.sumPay_tb.Size = new System.Drawing.Size(173, 20);
            this.sumPay_tb.TabIndex = 4;
            // 
            // sumOverPay_tb
            // 
            this.sumOverPay_tb.Location = new System.Drawing.Point(223, 261);
            this.sumOverPay_tb.Name = "sumOverPay_tb";
            this.sumOverPay_tb.ReadOnly = true;
            this.sumOverPay_tb.Size = new System.Drawing.Size(173, 20);
            this.sumOverPay_tb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Period,
            this.Payment,
            this.Procents,
            this.AllPayment,
            this.NeedToPay});
            this.dataGridView1.Location = new System.Drawing.Point(466, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 212);
            this.dataGridView1.TabIndex = 6;
            // 
            // Period
            // 
            this.Period.HeaderText = "Период";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Выплата кредита";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // Procents
            // 
            this.Procents.HeaderText = "Выплата процентов";
            this.Procents.Name = "Procents";
            this.Procents.ReadOnly = true;
            // 
            // AllPayment
            // 
            this.AllPayment.HeaderText = "Общая выплата";
            this.AllPayment.Name = "AllPayment";
            this.AllPayment.ReadOnly = true;
            // 
            // NeedToPay
            // 
            this.NeedToPay.HeaderText = "Осталось выплатить";
            this.NeedToPay.Name = "NeedToPay";
            this.NeedToPay.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 342);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sumOverPay_tb);
            this.Controls.Add(this.sumPay_tb);
            this.Controls.Add(this.payInMount_tb);
            this.Controls.Add(this.timeInMonth_tb);
            this.Controls.Add(this.timeInYear_tb);
            this.Controls.Add(this.perStavka_tb);
            this.Controls.Add(this.sumCredit_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Кредитный калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sumCredit_tb;
        private System.Windows.Forms.TextBox perStavka_tb;
        private System.Windows.Forms.TextBox timeInYear_tb;
        private System.Windows.Forms.TextBox timeInMonth_tb;
        private System.Windows.Forms.TextBox payInMount_tb;
        private System.Windows.Forms.TextBox sumPay_tb;
        private System.Windows.Forms.TextBox sumOverPay_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procents;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedToPay;
    }
}

