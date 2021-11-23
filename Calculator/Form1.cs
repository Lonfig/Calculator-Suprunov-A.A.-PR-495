using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double sumCredit = Convert.ToDouble(sumCredit_tb.Text);
            double perStavka = Convert.ToDouble(perStavka_tb.Text);
            double timeInYear = Convert.ToDouble(timeInYear_tb.Text);
            double timeInMonth = (timeInYear * 12);
            this.timeInMonth_tb.Text = "" + Math.Round(timeInMonth, 2);
            double payInMount = -1* sumCredit * perStavka / 100 / 12 * Math.Pow(1 + perStavka / 100 / 12, timeInMonth) / (Math.Pow(1 + perStavka / 100 / 12, timeInMonth) - 1);
            payInMount_tb.Text = "" + Math.Round(payInMount, 2);
            double sumPay = payInMount * timeInMonth;
            sumPay_tb.Text = "" + Math.Round(sumPay, 2);
            double sumOverPay = sumPay - sumCredit;
            sumOverPay_tb.Text = "" + Math.Round(sumOverPay, 2);

            double body = sumCredit;

            for(int period = 1; period <= timeInMonth; period++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[period-1].Cells[0].Value = period;
                double vk = payInMount * Math.Pow(1 + perStavka / 100/12, period - timeInMonth - 1);
                dataGridView1.Rows[period-1].Cells[1].Value = Math.Round(vk,2);
                double vp = payInMount * (1 - Math.Pow(1 + perStavka / 100/12, period - timeInMonth - 1));
                dataGridView1.Rows[period-1].Cells[2].Value = Math.Round(vp, 2);
                dataGridView1.Rows[period-1].Cells[3].Value = Math.Round(vk + vp,2);
                body += vk;
                dataGridView1.Rows[period-1].Cells[4].Value = Math.Round(body,2);
            }
        }
    }
}
