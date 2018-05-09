namespace Try1
{
    partial class Form2
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
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.credit = new System.Windows.Forms.RadioButton();
            this.item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.addEntry = new System.Windows.Forms.Button();
            this.delEntry = new System.Windows.Forms.Button();
            this.printBal = new System.Windows.Forms.Button();
            this.debit = new System.Windows.Forms.RadioButton();
            this.viewBal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(28, 12);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(678, 252);
            this.dg1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.debit);
            this.groupBox1.Controls.Add(this.credit);
            this.groupBox1.Location = new System.Drawing.Point(388, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.Location = new System.Drawing.Point(16, 18);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(67, 20);
            this.credit.TabIndex = 0;
            this.credit.TabStop = true;
            this.credit.Text = "Credit";
            this.credit.UseVisualStyleBackColor = true;
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(147, 304);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(199, 20);
            this.item.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(147, 346);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(199, 20);
            this.amount.TabIndex = 5;
            // 
            // addEntry
            // 
            this.addEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEntry.Location = new System.Drawing.Point(35, 412);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(215, 49);
            this.addEntry.TabIndex = 6;
            this.addEntry.Text = "Add Entry";
            this.addEntry.UseVisualStyleBackColor = true;
            // 
            // delEntry
            // 
            this.delEntry.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.delEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEntry.Location = new System.Drawing.Point(282, 412);
            this.delEntry.Name = "delEntry";
            this.delEntry.Size = new System.Drawing.Size(204, 49);
            this.delEntry.TabIndex = 7;
            this.delEntry.Text = "Delete Entry";
            this.delEntry.UseVisualStyleBackColor = true;
            // 
            // printBal
            // 
            this.printBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBal.Location = new System.Drawing.Point(510, 412);
            this.printBal.Name = "printBal";
            this.printBal.Size = new System.Drawing.Size(215, 49);
            this.printBal.TabIndex = 8;
            this.printBal.Text = "Print Balance Sheet";
            this.printBal.UseVisualStyleBackColor = true;
            // 
            // debit
            // 
            this.debit.AutoSize = true;
            this.debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debit.Location = new System.Drawing.Point(16, 54);
            this.debit.Name = "debit";
            this.debit.Size = new System.Drawing.Size(63, 20);
            this.debit.TabIndex = 9;
            this.debit.TabStop = true;
            this.debit.Text = "Debit";
            this.debit.UseVisualStyleBackColor = true;
            // 
            // viewBal
            // 
            this.viewBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBal.Location = new System.Drawing.Point(510, 311);
            this.viewBal.Name = "viewBal";
            this.viewBal.Size = new System.Drawing.Size(215, 49);
            this.viewBal.TabIndex = 9;
            this.viewBal.Text = "View Balance";
            this.viewBal.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 489);
            this.Controls.Add(this.viewBal);
            this.Controls.Add(this.printBal);
            this.Controls.Add(this.delEntry);
            this.Controls.Add(this.addEntry);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton credit;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button addEntry;
        private System.Windows.Forms.Button delEntry;
        private System.Windows.Forms.Button printBal;
        private System.Windows.Forms.RadioButton debit;
        private System.Windows.Forms.Button viewBal;
    }
}