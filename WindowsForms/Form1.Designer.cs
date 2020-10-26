namespace WindowsForms
{
    partial class Form1
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
            this.labelNumberElementsArray = new System.Windows.Forms.Label();
            this.textBoxNumberElementsArray = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.buttonSumNegativeElements = new System.Windows.Forms.Button();
            this.labelSumNegativeElements = new System.Windows.Forms.Label();
            this.buttonMaxElementArray = new System.Windows.Forms.Button();
            this.labelMaxElementArray = new System.Windows.Forms.Label();
            this.labelIndexMaxElementArray = new System.Windows.Forms.Label();
            this.labelMaxModuloElementArray = new System.Windows.Forms.Label();
            this.labelSumIndicesPositiveElements = new System.Windows.Forms.Label();
            this.labelCountIntegersArray = new System.Windows.Forms.Label();
            this.labelResultSumNegativeElements = new System.Windows.Forms.Label();
            this.labelResultMaxElementArray = new System.Windows.Forms.Label();
            this.labelResultIndexMaxElementArray = new System.Windows.Forms.Label();
            this.labelResultMaxModuloElementArray = new System.Windows.Forms.Label();
            this.labelResultSumIndicesPositiveElements = new System.Windows.Forms.Label();
            this.labelResultCountIntegersArray = new System.Windows.Forms.Label();
            this.buttonIndexMaxElementArray = new System.Windows.Forms.Button();
            this.buttonMaxModuloElementArray = new System.Windows.Forms.Button();
            this.buttonSumIndicesPositiveElements = new System.Windows.Forms.Button();
            this.buttonCountIntegersArray = new System.Windows.Forms.Button();
            this.buttonSortAndReverseArray = new System.Windows.Forms.Button();
            this.buttonRemoveNegativeElementsArray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumberElementsArray
            // 
            this.labelNumberElementsArray.AutoSize = true;
            this.labelNumberElementsArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNumberElementsArray.Location = new System.Drawing.Point(50, 36);
            this.labelNumberElementsArray.Name = "labelNumberElementsArray";
            this.labelNumberElementsArray.Size = new System.Drawing.Size(202, 20);
            this.labelNumberElementsArray.TabIndex = 0;
            this.labelNumberElementsArray.Text = "Кількість елементів масива:";
            // 
            // textBoxNumberElementsArray
            // 
            this.textBoxNumberElementsArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxNumberElementsArray.Location = new System.Drawing.Point(258, 33);
            this.textBoxNumberElementsArray.Name = "textBoxNumberElementsArray";
            this.textBoxNumberElementsArray.Size = new System.Drawing.Size(125, 27);
            this.textBoxNumberElementsArray.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonGenerate.Location = new System.Drawing.Point(440, 36);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(205, 29);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Згенерувати масив";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AllowUserToDeleteRows = false;
            this.dataGridViewArray.AllowUserToOrderColumns = true;
            this.dataGridViewArray.AllowUserToResizeRows = false;
            this.dataGridViewArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(50, 97);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.RowHeadersWidth = 51;
            this.dataGridViewArray.RowTemplate.Height = 24;
            this.dataGridViewArray.Size = new System.Drawing.Size(1117, 196);
            this.dataGridViewArray.TabIndex = 3;
            // 
            // buttonSumNegativeElements
            // 
            this.buttonSumNegativeElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSumNegativeElements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSumNegativeElements.Location = new System.Drawing.Point(50, 325);
            this.buttonSumNegativeElements.Name = "buttonSumNegativeElements";
            this.buttonSumNegativeElements.Size = new System.Drawing.Size(446, 29);
            this.buttonSumNegativeElements.TabIndex = 4;
            this.buttonSumNegativeElements.Text = "Порахувати суму від’ємних елементів масиву";
            this.buttonSumNegativeElements.UseVisualStyleBackColor = true;
            this.buttonSumNegativeElements.Click += new System.EventHandler(this.buttonSumNegativeElements_Click);
            // 
            // labelSumNegativeElements
            // 
            this.labelSumNegativeElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSumNegativeElements.AutoSize = true;
            this.labelSumNegativeElements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSumNegativeElements.Location = new System.Drawing.Point(525, 325);
            this.labelSumNegativeElements.Name = "labelSumNegativeElements";
            this.labelSumNegativeElements.Size = new System.Drawing.Size(161, 20);
            this.labelSumNegativeElements.TabIndex = 12;
            this.labelSumNegativeElements.Text = "Сума від’ємних чисел:";
            this.labelSumNegativeElements.Visible = false;
            // 
            // buttonMaxElementArray
            // 
            this.buttonMaxElementArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMaxElementArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMaxElementArray.Location = new System.Drawing.Point(50, 360);
            this.buttonMaxElementArray.Name = "buttonMaxElementArray";
            this.buttonMaxElementArray.Size = new System.Drawing.Size(446, 29);
            this.buttonMaxElementArray.TabIndex = 4;
            this.buttonMaxElementArray.Text = "Знайти максимальний елемент масиву";
            this.buttonMaxElementArray.UseVisualStyleBackColor = true;
            this.buttonMaxElementArray.Click += new System.EventHandler(this.buttonMaxElementArray_Click);
            // 
            // labelMaxElementArray
            // 
            this.labelMaxElementArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaxElementArray.AutoSize = true;
            this.labelMaxElementArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMaxElementArray.Location = new System.Drawing.Point(525, 360);
            this.labelMaxElementArray.Name = "labelMaxElementArray";
            this.labelMaxElementArray.Size = new System.Drawing.Size(234, 20);
            this.labelMaxElementArray.TabIndex = 12;
            this.labelMaxElementArray.Text = "Максимальний елемент масиву:";
            this.labelMaxElementArray.Visible = false;
            // 
            // labelIndexMaxElementArray
            // 
            this.labelIndexMaxElementArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIndexMaxElementArray.AutoSize = true;
            this.labelIndexMaxElementArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelIndexMaxElementArray.Location = new System.Drawing.Point(525, 395);
            this.labelIndexMaxElementArray.Name = "labelIndexMaxElementArray";
            this.labelIndexMaxElementArray.Size = new System.Drawing.Size(293, 20);
            this.labelIndexMaxElementArray.TabIndex = 12;
            this.labelIndexMaxElementArray.Text = "Індекс максимального елемента масиву:";
            this.labelIndexMaxElementArray.Visible = false;
            // 
            // labelMaxModuloElementArray
            // 
            this.labelMaxModuloElementArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaxModuloElementArray.AutoSize = true;
            this.labelMaxModuloElementArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMaxModuloElementArray.Location = new System.Drawing.Point(525, 430);
            this.labelMaxModuloElementArray.Name = "labelMaxModuloElementArray";
            this.labelMaxModuloElementArray.Size = new System.Drawing.Size(319, 20);
            this.labelMaxModuloElementArray.TabIndex = 12;
            this.labelMaxModuloElementArray.Text = "Максимальний за модулем елемент масиву:";
            this.labelMaxModuloElementArray.Visible = false;
            // 
            // labelSumIndicesPositiveElements
            // 
            this.labelSumIndicesPositiveElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSumIndicesPositiveElements.AutoSize = true;
            this.labelSumIndicesPositiveElements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSumIndicesPositiveElements.Location = new System.Drawing.Point(525, 465);
            this.labelSumIndicesPositiveElements.Name = "labelSumIndicesPositiveElements";
            this.labelSumIndicesPositiveElements.Size = new System.Drawing.Size(248, 20);
            this.labelSumIndicesPositiveElements.TabIndex = 12;
            this.labelSumIndicesPositiveElements.Text = "Сума індексів додатних елементів:";
            this.labelSumIndicesPositiveElements.Visible = false;
            // 
            // labelCountIntegersArray
            // 
            this.labelCountIntegersArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountIntegersArray.AutoSize = true;
            this.labelCountIntegersArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCountIntegersArray.Location = new System.Drawing.Point(525, 500);
            this.labelCountIntegersArray.Name = "labelCountIntegersArray";
            this.labelCountIntegersArray.Size = new System.Drawing.Size(220, 20);
            this.labelCountIntegersArray.TabIndex = 12;
            this.labelCountIntegersArray.Text = "Кількість цілих чисел у масиві:";
            this.labelCountIntegersArray.Visible = false;
            // 
            // labelResultSumNegativeElements
            // 
            this.labelResultSumNegativeElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultSumNegativeElements.AutoSize = true;
            this.labelResultSumNegativeElements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelResultSumNegativeElements.Location = new System.Drawing.Point(870, 325);
            this.labelResultSumNegativeElements.Name = "labelResultSumNegativeElements";
            this.labelResultSumNegativeElements.Size = new System.Drawing.Size(198, 20);
            this.labelResultSumNegativeElements.TabIndex = 12;
            this.labelResultSumNegativeElements.Text = "ResultSumNegativeElements";
            this.labelResultSumNegativeElements.Visible = false;
            // 
            // labelResultMaxElementArray
            // 
            this.labelResultMaxElementArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultMaxElementArray.AutoSize = true;
            this.labelResultMaxElementArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelResultMaxElementArray.Location = new System.Drawing.Point(870, 360);
            this.labelResultMaxElementArray.Name = "labelResultMaxElementArray";
            this.labelResultMaxElementArray.Size = new System.Drawing.Size(166, 20);
            this.labelResultMaxElementArray.TabIndex = 12;
            this.labelResultMaxElementArray.Text = "ResultMaxElementArray";
            this.labelResultMaxElementArray.Visible = false;
            // 
            // labelResultIndexMaxElementArray
            // 
            this.labelResultIndexMaxElementArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultIndexMaxElementArray.AutoSize = true;
            this.labelResultIndexMaxElementArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelResultIndexMaxElementArray.Location = new System.Drawing.Point(870, 395);
            this.labelResultIndexMaxElementArray.Name = "labelResultIndexMaxElementArray";
            this.labelResultIndexMaxElementArray.Size = new System.Drawing.Size(202, 20);
            this.labelResultIndexMaxElementArray.TabIndex = 12;
            this.labelResultIndexMaxElementArray.Text = "ResultIndexMaxElementArray";
            this.labelResultIndexMaxElementArray.Visible = false;
            // 
            // labelResultMaxModuloElementArray
            // 
            this.labelResultMaxModuloElementArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultMaxModuloElementArray.AutoSize = true;
            this.labelResultMaxModuloElementArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelResultMaxModuloElementArray.Location = new System.Drawing.Point(870, 430);
            this.labelResultMaxModuloElementArray.Name = "labelResultMaxModuloElementArray";
            this.labelResultMaxModuloElementArray.Size = new System.Drawing.Size(218, 20);
            this.labelResultMaxModuloElementArray.TabIndex = 12;
            this.labelResultMaxModuloElementArray.Text = "ResultMaxModuloElementArray";
            this.labelResultMaxModuloElementArray.Visible = false;
            // 
            // labelResultSumIndicesPositiveElements
            // 
            this.labelResultSumIndicesPositiveElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultSumIndicesPositiveElements.AutoSize = true;
            this.labelResultSumIndicesPositiveElements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelResultSumIndicesPositiveElements.Location = new System.Drawing.Point(870, 465);
            this.labelResultSumIndicesPositiveElements.Name = "labelResultSumIndicesPositiveElements";
            this.labelResultSumIndicesPositiveElements.Size = new System.Drawing.Size(234, 20);
            this.labelResultSumIndicesPositiveElements.TabIndex = 12;
            this.labelResultSumIndicesPositiveElements.Text = "ResultSumIndicesPositiveElements";
            this.labelResultSumIndicesPositiveElements.Visible = false;
            // 
            // labelResultCountIntegersArray
            // 
            this.labelResultCountIntegersArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultCountIntegersArray.AutoSize = true;
            this.labelResultCountIntegersArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelResultCountIntegersArray.Location = new System.Drawing.Point(870, 500);
            this.labelResultCountIntegersArray.Name = "labelResultCountIntegersArray";
            this.labelResultCountIntegersArray.Size = new System.Drawing.Size(176, 20);
            this.labelResultCountIntegersArray.TabIndex = 12;
            this.labelResultCountIntegersArray.Text = "ResultCountIntegersArray";
            this.labelResultCountIntegersArray.Visible = false;
            // 
            // buttonIndexMaxElementArray
            // 
            this.buttonIndexMaxElementArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIndexMaxElementArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonIndexMaxElementArray.Location = new System.Drawing.Point(50, 395);
            this.buttonIndexMaxElementArray.Name = "buttonIndexMaxElementArray";
            this.buttonIndexMaxElementArray.Size = new System.Drawing.Size(446, 29);
            this.buttonIndexMaxElementArray.TabIndex = 13;
            this.buttonIndexMaxElementArray.Text = "Знайти номер (індекс) максимального елемента масиву";
            this.buttonIndexMaxElementArray.UseVisualStyleBackColor = true;
            this.buttonIndexMaxElementArray.Click += new System.EventHandler(this.buttonIndexMaxElementArray_Click);
            // 
            // buttonMaxModuloElementArray
            // 
            this.buttonMaxModuloElementArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMaxModuloElementArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMaxModuloElementArray.Location = new System.Drawing.Point(50, 430);
            this.buttonMaxModuloElementArray.Name = "buttonMaxModuloElementArray";
            this.buttonMaxModuloElementArray.Size = new System.Drawing.Size(446, 29);
            this.buttonMaxModuloElementArray.TabIndex = 14;
            this.buttonMaxModuloElementArray.Text = "Знайти максимальний за модулем елемент масиву";
            this.buttonMaxModuloElementArray.UseVisualStyleBackColor = true;
            this.buttonMaxModuloElementArray.Click += new System.EventHandler(this.buttonMaxModuloElementArray_Click_1);
            // 
            // buttonSumIndicesPositiveElements
            // 
            this.buttonSumIndicesPositiveElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSumIndicesPositiveElements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSumIndicesPositiveElements.Location = new System.Drawing.Point(50, 465);
            this.buttonSumIndicesPositiveElements.Name = "buttonSumIndicesPositiveElements";
            this.buttonSumIndicesPositiveElements.Size = new System.Drawing.Size(446, 29);
            this.buttonSumIndicesPositiveElements.TabIndex = 15;
            this.buttonSumIndicesPositiveElements.Text = "Порахувати суму індексів додатних елементів";
            this.buttonSumIndicesPositiveElements.UseVisualStyleBackColor = true;
            this.buttonSumIndicesPositiveElements.Click += new System.EventHandler(this.buttonSumIndicesPositiveElements_Click);
            // 
            // buttonCountIntegersArray
            // 
            this.buttonCountIntegersArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCountIntegersArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCountIntegersArray.Location = new System.Drawing.Point(50, 500);
            this.buttonCountIntegersArray.Name = "buttonCountIntegersArray";
            this.buttonCountIntegersArray.Size = new System.Drawing.Size(446, 29);
            this.buttonCountIntegersArray.TabIndex = 16;
            this.buttonCountIntegersArray.Text = "Порахувати кількість цілих чисел у масиві";
            this.buttonCountIntegersArray.UseVisualStyleBackColor = true;
            this.buttonCountIntegersArray.Click += new System.EventHandler(this.buttonCountIntegersArray_Click);
            // 
            // buttonSortAndReverseArray
            // 
            this.buttonSortAndReverseArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSortAndReverseArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSortAndReverseArray.Location = new System.Drawing.Point(50, 535);
            this.buttonSortAndReverseArray.Name = "buttonSortAndReverseArray";
            this.buttonSortAndReverseArray.Size = new System.Drawing.Size(446, 29);
            this.buttonSortAndReverseArray.TabIndex = 17;
            this.buttonSortAndReverseArray.Text = "Відсортувати масив за спаданням значень елементів масиву";
            this.buttonSortAndReverseArray.UseVisualStyleBackColor = true;
            this.buttonSortAndReverseArray.Click += new System.EventHandler(this.buttonSortAndReverseArray_Click);
            // 
            // buttonRemoveNegativeElementsArray
            // 
            this.buttonRemoveNegativeElementsArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveNegativeElementsArray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRemoveNegativeElementsArray.Location = new System.Drawing.Point(50, 570);
            this.buttonRemoveNegativeElementsArray.Name = "buttonRemoveNegativeElementsArray";
            this.buttonRemoveNegativeElementsArray.Size = new System.Drawing.Size(446, 29);
            this.buttonRemoveNegativeElementsArray.TabIndex = 18;
            this.buttonRemoveNegativeElementsArray.Text = "Видалити з масиву від’ємні елементи";
            this.buttonRemoveNegativeElementsArray.UseVisualStyleBackColor = true;
            this.buttonRemoveNegativeElementsArray.Click += new System.EventHandler(this.buttonRemoveNegativeElementsArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 637);
            this.Controls.Add(this.buttonRemoveNegativeElementsArray);
            this.Controls.Add(this.buttonSortAndReverseArray);
            this.Controls.Add(this.buttonCountIntegersArray);
            this.Controls.Add(this.buttonSumIndicesPositiveElements);
            this.Controls.Add(this.buttonMaxModuloElementArray);
            this.Controls.Add(this.buttonIndexMaxElementArray);
            this.Controls.Add(this.labelResultCountIntegersArray);
            this.Controls.Add(this.labelCountIntegersArray);
            this.Controls.Add(this.labelResultSumIndicesPositiveElements);
            this.Controls.Add(this.labelSumIndicesPositiveElements);
            this.Controls.Add(this.labelResultMaxModuloElementArray);
            this.Controls.Add(this.labelMaxModuloElementArray);
            this.Controls.Add(this.labelResultIndexMaxElementArray);
            this.Controls.Add(this.labelIndexMaxElementArray);
            this.Controls.Add(this.labelResultMaxElementArray);
            this.Controls.Add(this.labelMaxElementArray);
            this.Controls.Add(this.labelResultSumNegativeElements);
            this.Controls.Add(this.labelSumNegativeElements);
            this.Controls.Add(this.buttonMaxElementArray);
            this.Controls.Add(this.buttonSumNegativeElements);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxNumberElementsArray);
            this.Controls.Add(this.labelNumberElementsArray);
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1234, 684);
            this.Name = "Form1";
            this.Text = "ISMDotNet4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberElementsArray;
        private System.Windows.Forms.TextBox textBoxNumberElementsArray;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button buttonSumNegativeElements;
        private System.Windows.Forms.Label labelSumNegativeElements;
        private System.Windows.Forms.Button buttonMaxElementArray;
        private System.Windows.Forms.Label labelMaxElementArray;
        private System.Windows.Forms.Label labelIndexMaxElementArray;
        private System.Windows.Forms.Label labelMaxModuloElementArray;
        private System.Windows.Forms.Label labelSumIndicesPositiveElements;
        private System.Windows.Forms.Label labelCountIntegersArray;
        private System.Windows.Forms.Label labelResultSumNegativeElements;
        private System.Windows.Forms.Label labelResultMaxElementArray;
        private System.Windows.Forms.Label labelResultIndexMaxElementArray;
        private System.Windows.Forms.Label labelResultMaxModuloElementArray;
        private System.Windows.Forms.Label labelResultSumIndicesPositiveElements;
        private System.Windows.Forms.Label labelResultCountIntegersArray;
        private System.Windows.Forms.Button buttonIndexMaxElementArray;
        private System.Windows.Forms.Button buttonMaxModuloElementArray;
        private System.Windows.Forms.Button buttonSumIndicesPositiveElements;
        private System.Windows.Forms.Button buttonCountIntegersArray;
        private System.Windows.Forms.Button buttonSortAndReverseArray;
        private System.Windows.Forms.Button buttonRemoveNegativeElementsArray;
    }
}

