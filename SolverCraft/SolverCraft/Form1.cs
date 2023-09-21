using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SolverCraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();

            if (selectedValue == "Расчет энтропии")
            {
                // Создать и показать форму для расчета энтропии
                FormEntropyCalculation formEntropy = new FormEntropyCalculation();
                formEntropy.Show();
            }
            else if (selectedValue == "Решить диффуры")
            {
                // Создать и показать форму для решения дифференциальных уравнений
                FormDifferentialEquations formDiffEq = new FormDifferentialEquations();
                formDiffEq.Show();
            }
            else if (selectedValue == "Сварить кофе")
            {
                // Создать и показать форму для сварки кофе
                FormCoffeeBrewing formCoffee = new FormCoffeeBrewing();
                formCoffee.Show();
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem.ToString();

            if (selectedValue == "Решить диффуры")
            {
                // Выводим пример псевдовычисления диффура в textbox1
                textBox1.Text = "Пример вычисления диффура: y'' + 2y' + y = 0";
            }
            else if (selectedValue == "Оптимизация памяти пк")
            {
                try
                {
                    // Запускаем программу для расчета энтропии
                    System.Diagnostics.Process.Start(@"C:\Users\apce1\Desktop\Physics_Platform_ITMO\ReduceMemory.lnk");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
