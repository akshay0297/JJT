namespace Try1
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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addr = new System.Windows.Forms.TextBox();
            this.addCust = new System.Windows.Forms.Button();
            this.modBal = new System.Windows.Forms.Button();
            this.viewBal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(217, 136);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(272, 20);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADDRESS";
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(217, 183);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(272, 20);
            this.addr.TabIndex = 3;
            // 
            // addCust
            // 
            this.addCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCust.Location = new System.Drawing.Point(78, 324);
            this.addCust.Name = "addCust";
            this.addCust.Size = new System.Drawing.Size(159, 47);
            this.addCust.TabIndex = 4;
            this.addCust.Text = "ADD CUSTOMER";
            this.addCust.UseVisualStyleBackColor = true;
            this.addCust.Click += new System.EventHandler(this.addCust_Click);
            // 
            // modBal
            // 
            this.modBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBal.Location = new System.Drawing.Point(512, 324);
            this.modBal.Name = "modBal";
            this.modBal.Size = new System.Drawing.Size(152, 47);
            this.modBal.TabIndex = 6;
            this.modBal.Text = "MODIFY BALANCE";
            this.modBal.UseVisualStyleBackColor = true;
            this.modBal.Click += new System.EventHandler(this.modBal_Click);
            // 
            // viewBal
            // 
            this.viewBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBal.Location = new System.Drawing.Point(291, 324);
            this.viewBal.Name = "viewBal";
            this.viewBal.Size = new System.Drawing.Size(161, 47);
            this.viewBal.TabIndex = 7;
            this.viewBal.Text = "VIEW BALANCE";
            this.viewBal.UseVisualStyleBackColor = true;
            this.viewBal.Click += new System.EventHandler(this.viewBal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.viewBal);
            this.Controls.Add(this.modBal);
            this.Controls.Add(this.addCust);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Main Form ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.Button addCust;
        private System.Windows.Forms.Button modBal;
        private System.Windows.Forms.Button viewBal;
    }
}

