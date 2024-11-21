namespace GoldDigger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculateBtn = new Button();
            label1 = new Label();
            rawDayPriceTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            sellerPriceTxt = new TextBox();
            label4 = new Label();
            goldWeightTxt = new TextBox();
            sellerProfitTxt = new TextBox();
            label5 = new Label();
            sellerProfitPriceTxt = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(101, 294);
            calculateBtn.Margin = new Padding(5);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(118, 40);
            calculateBtn.TabIndex = 4;
            calculateBtn.Text = "محاسبه";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 53);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 26);
            label1.TabIndex = 1;
            label1.Text = "قیمت روز طلا :";
            // 
            // rawDayPriceTxt
            // 
            rawDayPriceTxt.Location = new Point(20, 53);
            rawDayPriceTxt.Margin = new Padding(5);
            rawDayPriceTxt.Multiline = true;
            rawDayPriceTxt.Name = "rawDayPriceTxt";
            rawDayPriceTxt.Size = new Size(199, 23);
            rawDayPriceTxt.TabIndex = 1;
            rawDayPriceTxt.TextChanged += rawDayPriceTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 5);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 26);
            label2.TabIndex = 3;
            label2.Text = "محاسبه گر درصد سود";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 100);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 26);
            label3.TabIndex = 1;
            label3.Text = "قیمت فروشنده :";
            // 
            // sellerPriceTxt
            // 
            sellerPriceTxt.Location = new Point(20, 100);
            sellerPriceTxt.Margin = new Padding(5);
            sellerPriceTxt.Multiline = true;
            sellerPriceTxt.Name = "sellerPriceTxt";
            sellerPriceTxt.Size = new Size(199, 23);
            sellerPriceTxt.TabIndex = 2;
            sellerPriceTxt.TextChanged += sellerPriceTxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 150);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 26);
            label4.TabIndex = 1;
            label4.Text = "وزن طلا :";
            // 
            // goldWeightTxt
            // 
            goldWeightTxt.Location = new Point(20, 150);
            goldWeightTxt.Margin = new Padding(5);
            goldWeightTxt.Multiline = true;
            goldWeightTxt.Name = "goldWeightTxt";
            goldWeightTxt.Size = new Size(199, 23);
            goldWeightTxt.TabIndex = 3;
            // 
            // sellerProfitTxt
            // 
            sellerProfitTxt.Enabled = false;
            sellerProfitTxt.Location = new Point(20, 211);
            sellerProfitTxt.Margin = new Padding(5);
            sellerProfitTxt.Multiline = true;
            sellerProfitTxt.Name = "sellerProfitTxt";
            sellerProfitTxt.Size = new Size(171, 23);
            sellerProfitTxt.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 211);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 26);
            label5.TabIndex = 4;
            label5.Text = "درصد سود فروشنده :";
            // 
            // sellerProfitPriceTxt
            // 
            sellerProfitPriceTxt.Enabled = false;
            sellerProfitPriceTxt.Location = new Point(20, 249);
            sellerProfitPriceTxt.Margin = new Padding(5);
            sellerProfitPriceTxt.Multiline = true;
            sellerProfitPriceTxt.Name = "sellerProfitPriceTxt";
            sellerProfitPriceTxt.Size = new Size(171, 23);
            sellerProfitPriceTxt.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 246);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(124, 26);
            label6.TabIndex = 6;
            label6.Text = "مبلغ سود فروشنده :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 349);
            Controls.Add(sellerProfitPriceTxt);
            Controls.Add(label6);
            Controls.Add(sellerProfitTxt);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(goldWeightTxt);
            Controls.Add(sellerPriceTxt);
            Controls.Add(label4);
            Controls.Add(rawDayPriceTxt);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(calculateBtn);
            Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "طلا";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateBtn;
        private Label label1;
        private TextBox rawDayPriceTxt;
        private Label label2;
        private Label label3;
        private TextBox sellerPriceTxt;
        private Label label4;
        private TextBox goldWeightTxt;
        private TextBox sellerProfitTxt;
        private Label label5;
        private TextBox sellerProfitPriceTxt;
        private Label label6;
    }
}
