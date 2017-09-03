namespace WindowsForms___Sorting_Algorithms
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuickSort = new System.Windows.Forms.Button();
            this.MergeSort = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.HeapSort = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(86, 42);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(86, 94);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(100, 20);
            this.Output.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // QuickSort
            // 
            this.QuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickSort.Location = new System.Drawing.Point(98, 120);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(75, 23);
            this.QuickSort.TabIndex = 4;
            this.QuickSort.Text = "QuickSort";
            this.QuickSort.UseVisualStyleBackColor = true;
            this.QuickSort.Click += new System.EventHandler(this.QuickSort_Click);
            // 
            // MergeSort
            // 
            this.MergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeSort.Location = new System.Drawing.Point(98, 149);
            this.MergeSort.Name = "MergeSort";
            this.MergeSort.Size = new System.Drawing.Size(75, 23);
            this.MergeSort.TabIndex = 5;
            this.MergeSort.Text = "MergeSort";
            this.MergeSort.UseVisualStyleBackColor = true;
            this.MergeSort.Click += new System.EventHandler(this.MergeSort_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BubbleSort.Location = new System.Drawing.Point(98, 178);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(75, 23);
            this.BubbleSort.TabIndex = 6;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // HeapSort
            // 
            this.HeapSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeapSort.Location = new System.Drawing.Point(98, 207);
            this.HeapSort.Name = "HeapSort";
            this.HeapSort.Size = new System.Drawing.Size(75, 23);
            this.HeapSort.TabIndex = 7;
            this.HeapSort.Text = "HeapSort";
            this.HeapSort.UseVisualStyleBackColor = true;
            this.HeapSort.Click += new System.EventHandler(this.HeapSort_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(216, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 20);
            this.button5.TabIndex = 8;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(2, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sorting App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.HeapSort);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.MergeSort);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QuickSort;
        private System.Windows.Forms.Button MergeSort;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button HeapSort;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
    }
}

