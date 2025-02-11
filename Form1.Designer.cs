namespace ASSMT_1
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
            label1 = new Label();
            label2 = new Label();
            profits = new TextBox();
            reset = new Button();
            principal = new TextBox();
            total = new TextBox();
            label3 = new Label();
            apple = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            meta = new TextBox();
            groupBox4 = new GroupBox();
            label7 = new Label();
            nvidia = new TextBox();
            groupBox5 = new GroupBox();
            label8 = new Label();
            tesla = new TextBox();
            tenure = new TextBox();
            label5 = new Label();
            enter = new Button();
            invested = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            google = new TextBox();
            ratePanel = new TableLayoutPanel();
            teslaLabel = new Label();
            nvidiaLabel = new Label();
            metaLabel = new Label();
            googleLabel = new Label();
            appleLabel = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label12 = new Label();
            label17 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            ratePanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 77);
            label1.Name = "label1";
            label1.Size = new Size(244, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter Principal Amount: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 463);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 1;
            label2.Text = "Profits: ";
            label2.Click += label2_Click;
            // 
            // profits
            // 
            profits.Location = new Point(355, 470);
            profits.Name = "profits";
            profits.ReadOnly = true;
            profits.Size = new Size(154, 23);
            profits.TabIndex = 10;
            // 
            // reset
            // 
            reset.Location = new Point(734, 496);
            reset.Name = "reset";
            reset.Size = new Size(301, 43);
            reset.TabIndex = 8;
            reset.Text = "&Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += lblShimCount_Click;
            // 
            // principal
            // 
            principal.Location = new Point(355, 86);
            principal.Name = "principal";
            principal.Size = new Size(154, 23);
            principal.TabIndex = 0;
            principal.TextChanged += lblErrorMessage_TextChanged;
            // 
            // total
            // 
            total.Location = new Point(355, 516);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(154, 23);
            total.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 509);
            label3.Name = "label3";
            label3.Size = new Size(142, 30);
            label3.TabIndex = 11;
            label3.Text = "Total Returns:";
            // 
            // apple
            // 
            apple.Location = new Point(19, 52);
            apple.Name = "apple";
            apple.Size = new Size(154, 23);
            apple.TabIndex = 0;
            apple.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 19);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 1;
            label4.Text = "Apple";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(apple);
            groupBox1.Location = new Point(36, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(meta);
            groupBox3.Location = new Point(448, 214);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(70, 19);
            label6.Name = "label6";
            label6.Size = new Size(63, 30);
            label6.TabIndex = 14;
            label6.Text = "Meta";
            // 
            // meta
            // 
            meta.Location = new Point(19, 52);
            meta.Name = "meta";
            meta.Size = new Size(154, 23);
            meta.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(nvidia);
            groupBox4.Location = new Point(654, 214);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 100);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(62, 19);
            label7.Name = "label7";
            label7.Size = new Size(74, 30);
            label7.TabIndex = 14;
            label7.Text = "Nvidia";
            // 
            // nvidia
            // 
            nvidia.Location = new Point(19, 52);
            nvidia.Name = "nvidia";
            nvidia.Size = new Size(154, 23);
            nvidia.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(tesla);
            groupBox5.Location = new Point(860, 214);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 100);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(66, 19);
            label8.Name = "label8";
            label8.Size = new Size(60, 30);
            label8.TabIndex = 14;
            label8.Text = "Tesla";
            // 
            // tesla
            // 
            tesla.Location = new Point(19, 52);
            tesla.Name = "tesla";
            tesla.Size = new Size(154, 23);
            tesla.TabIndex = 0;
            // 
            // tenure
            // 
            tenure.Location = new Point(355, 141);
            tenure.Name = "tenure";
            tenure.Size = new Size(154, 23);
            tenure.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(90, 132);
            label5.Name = "label5";
            label5.Size = new Size(239, 30);
            label5.TabIndex = 18;
            label5.Text = "Enter Tenure (in Years): ";
            label5.Click += label5_Click;
            // 
            // enter
            // 
            enter.Location = new Point(734, 423);
            enter.Name = "enter";
            enter.Size = new Size(301, 43);
            enter.TabIndex = 7;
            enter.Text = "&Calculate Returns";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // invested
            // 
            invested.Location = new Point(355, 423);
            invested.Name = "invested";
            invested.ReadOnly = true;
            invested.Size = new Size(154, 23);
            invested.TabIndex = 8;
            invested.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(90, 416);
            label10.Name = "label10";
            label10.Size = new Size(189, 30);
            label10.TabIndex = 23;
            label10.Text = "Amount Invested: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(google);
            groupBox2.Location = new Point(242, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(50, 19);
            label11.Name = "label11";
            label11.Size = new Size(100, 30);
            label11.TabIndex = 14;
            label11.Text = "Alphabet";
            // 
            // google
            // 
            google.Location = new Point(19, 52);
            google.Name = "google";
            google.Size = new Size(154, 23);
            google.TabIndex = 1;
            // 
            // ratePanel
            // 
            ratePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ratePanel.ColumnCount = 2;
            ratePanel.ColumnStyles.Add(new ColumnStyle());
            ratePanel.ColumnStyles.Add(new ColumnStyle());
            ratePanel.Controls.Add(teslaLabel, 1, 4);
            ratePanel.Controls.Add(nvidiaLabel, 1, 3);
            ratePanel.Controls.Add(metaLabel, 1, 2);
            ratePanel.Controls.Add(googleLabel, 1, 1);
            ratePanel.Controls.Add(appleLabel, 1, 0);
            ratePanel.Controls.Add(label13, 0, 1);
            ratePanel.Controls.Add(label14, 0, 2);
            ratePanel.Controls.Add(label15, 0, 3);
            ratePanel.Controls.Add(label16, 0, 4);
            ratePanel.Controls.Add(label12, 0, 0);
            ratePanel.Location = new Point(860, 70);
            ratePanel.Name = "ratePanel";
            ratePanel.RowCount = 5;
            ratePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ratePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ratePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ratePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ratePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ratePanel.Size = new Size(200, 138);
            ratePanel.TabIndex = 24;
            ratePanel.Paint += ratePanel_Paint;
            // 
            // teslaLabel
            // 
            teslaLabel.Anchor = AnchorStyles.Left;
            teslaLabel.AutoSize = true;
            teslaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teslaLabel.Location = new Point(83, 112);
            teslaLabel.Name = "teslaLabel";
            teslaLabel.Size = new Size(0, 21);
            teslaLabel.TabIndex = 9;
            teslaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nvidiaLabel
            // 
            nvidiaLabel.Anchor = AnchorStyles.Left;
            nvidiaLabel.AutoSize = true;
            nvidiaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nvidiaLabel.Location = new Point(83, 84);
            nvidiaLabel.Name = "nvidiaLabel";
            nvidiaLabel.Size = new Size(0, 21);
            nvidiaLabel.TabIndex = 8;
            nvidiaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // metaLabel
            // 
            metaLabel.Anchor = AnchorStyles.Left;
            metaLabel.AutoSize = true;
            metaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            metaLabel.Location = new Point(83, 57);
            metaLabel.Name = "metaLabel";
            metaLabel.Size = new Size(0, 21);
            metaLabel.TabIndex = 7;
            metaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // googleLabel
            // 
            googleLabel.Anchor = AnchorStyles.Left;
            googleLabel.AutoSize = true;
            googleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            googleLabel.Location = new Point(83, 30);
            googleLabel.Name = "googleLabel";
            googleLabel.Size = new Size(0, 21);
            googleLabel.TabIndex = 6;
            googleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // appleLabel
            // 
            appleLabel.Anchor = AnchorStyles.Left;
            appleLabel.AutoSize = true;
            appleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            appleLabel.Location = new Point(83, 3);
            appleLabel.Name = "appleLabel";
            appleLabel.Size = new Size(0, 21);
            appleLabel.TabIndex = 5;
            appleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(4, 30);
            label13.Name = "label13";
            label13.Size = new Size(72, 21);
            label13.TabIndex = 1;
            label13.Text = "Alphabet";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(4, 57);
            label14.Name = "label14";
            label14.Size = new Size(45, 21);
            label14.TabIndex = 2;
            label14.Text = "Meta";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(4, 84);
            label15.Name = "label15";
            label15.Size = new Size(55, 21);
            label15.TabIndex = 3;
            label15.Text = "Nvidia";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(4, 112);
            label16.Name = "label16";
            label16.Size = new Size(43, 21);
            label16.TabIndex = 4;
            label16.Text = "Tesla";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(4, 3);
            label12.Name = "label12";
            label12.Size = new Size(50, 21);
            label12.TabIndex = 0;
            label12.Text = "Apple";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(860, 48);
            label17.Name = "label17";
            label17.Size = new Size(57, 25);
            label17.TabIndex = 25;
            label17.Text = "Rates";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 600);
            Controls.Add(ratePanel);
            Controls.Add(groupBox2);
            Controls.Add(label10);
            Controls.Add(invested);
            Controls.Add(label9);
            Controls.Add(tenure);
            Controls.Add(label5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(total);
            Controls.Add(label3);
            Controls.Add(principal);
            Controls.Add(reset);
            Controls.Add(enter);
            Controls.Add(profits);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label17);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ratePanel.ResumeLayout(false);
            ratePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox profits;
        private Button reset;
        private TextBox principal;
        private TextBox total;
        private Label label3;
        private TextBox apple;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox meta;
        private GroupBox groupBox4;
        private Label label7;
        private TextBox nvidia;
        private GroupBox groupBox5;
        private Label label8;
        private TextBox tesla;
        private TextBox tenure;
        private Label label5;
        private Button enter;
        private TextBox invested;
        private Label label9;
        private Label label10;
        private GroupBox groupBox2;
        private Label label11;
        private TextBox google;
        private TableLayoutPanel ratePanel;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label teslaLabel;
        private Label nvidiaLabel;
        private Label metaLabel;
        private Label googleLabel;
        private Label appleLabel;
        private Label label17;
    }
}
