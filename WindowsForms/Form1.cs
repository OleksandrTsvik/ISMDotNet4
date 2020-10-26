using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrayLibrary;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMaxElementArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }

            labelResultMaxElementArray.Text = Class1.MaxElementArray(arr).ToString();
            labelMaxElementArray.Visible = true;
            labelResultMaxElementArray.Visible = true;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            labelMaxElementArray.Visible = false;
            labelResultMaxElementArray.Visible = false;
            labelSumNegativeElements.Visible = false;
            labelResultSumNegativeElements.Visible = false;
            labelIndexMaxElementArray.Visible = false;
            labelResultIndexMaxElementArray.Visible = false;
            labelMaxModuloElementArray.Visible = false;
            labelResultMaxModuloElementArray.Visible = false;
            labelSumIndicesPositiveElements.Visible = false;
            labelResultSumIndicesPositiveElements.Visible = false;
            labelCountIntegersArray.Visible = false;
            labelResultCountIntegersArray.Visible = false;

            int count = int.Parse(textBoxNumberElementsArray.Text);
            dataGridViewArray.ColumnCount = count;
            dataGridViewArray.RowCount = 1;

            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                dataGridViewArray.Columns[i].HeaderCell.Value = i.ToString();
                dataGridViewArray[i, 0].Value = rnd.Next(-200, 200);
                dataGridViewArray.Columns[i].Width = 45;
            }
        }

        private void buttonSumNegativeElements_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }

            labelResultSumNegativeElements.Text = Class1.SumNegativeElements(arr).ToString();
            labelSumNegativeElements.Visible = true;
            labelResultSumNegativeElements.Visible = true;
        }

        private void buttonIndexMaxElementArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }

            labelResultIndexMaxElementArray.Text = Class1.IndexMaxElementArray(arr).ToString();
            labelIndexMaxElementArray.Visible = true;
            labelResultIndexMaxElementArray.Visible = true;
        }

        private void buttonMaxModuloElementArray_Click_1(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }

            labelResultMaxModuloElementArray.Text = Class1.MaxModuloElementArray(arr).ToString();
            labelMaxModuloElementArray.Visible = true;
            labelResultMaxModuloElementArray.Visible = true;
        }

        private void buttonSumIndicesPositiveElements_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }

            labelResultSumIndicesPositiveElements.Text = Class1.SumIndicesPositiveElements(arr).ToString();
            labelSumIndicesPositiveElements.Visible = true;
            labelResultSumIndicesPositiveElements.Visible = true;
        }

        private void buttonCountIntegersArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }

            labelResultCountIntegersArray.Text = Class1.CountIntegersArray(arr).ToString();
            labelCountIntegersArray.Visible = true;
            labelResultCountIntegersArray.Visible = true;
        }

        private void buttonSortAndReverseArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewArray.ColumnCount];
            int count = dataGridViewArray.ColumnCount;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }

            arr = Class1.SortAndReverseArray(arr);
            for (int i = 0; i < count; i++)
            {
                dataGridViewArray[i, 0].Value = arr[i].ToString();
            }
        }

        private void buttonRemoveNegativeElementsArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }

            arr = Class1.RemoveNegativeElementsArray(arr);
            int count = arr.Length;
            dataGridViewArray.ColumnCount = count;

            for (int i = 0; i < count; i++)
            {
                dataGridViewArray[i, 0].Value = arr[i].ToString();
            }
        }
    }
}
