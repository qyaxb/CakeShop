namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            btnOrder = new Button();
            comboBoxPayment = new ComboBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtQuantityStraw = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxDeliveryMethod = new ComboBox();
            OnCart = new ListView();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            txtQuantityChoco = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtQuantityVanilla = new TextBox();
            label12 = new Label();
            label13 = new Label();
            pictureBox5 = new PictureBox();
            txtTotal = new TextBox();
            btnCloseAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(661, 163);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(193, 27);
            txtPhoneNumber.TabIndex = 0;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("FOT-Yuruka Std UB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 54);
            label1.Name = "label1";
            label1.Size = new Size(271, 44);
            label1.TabIndex = 1;
            label1.Text = "K98 Cake Shop";
            label1.Click += label1_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(64, 64, 64);
            btnOrder.Font = new Font("FOT-Yuruka Std UB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnOrder.ForeColor = Color.Transparent;
            btnOrder.Location = new Point(676, 332);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(178, 45);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "ORDER NOW!!";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.TextChanged += btnOrder_TextChanged;
            btnOrder.Click += btnOrder_Click;
            // 
            // comboBoxPayment
            // 
            comboBoxPayment.FormattingEnabled = true;
            comboBoxPayment.Location = new Point(661, 205);
            comboBoxPayment.Name = "comboBoxPayment";
            comboBoxPayment.Size = new Size(193, 28);
            comboBoxPayment.TabIndex = 3;
            comboBoxPayment.SelectedIndexChanged += comboBoxPayment_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.birthday_cake_1021x1024__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(360, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 49);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 128);
            label2.Location = new Point(216, 98);
            label2.Name = "label2";
            label2.Size = new Size(397, 24);
            label2.TabIndex = 1;
            label2.Text = "Sweeten your day with a slice of happiness!";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("FOT-Yuruka Std UB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.Location = new Point(462, 203);
            label3.Name = "label3";
            label3.Size = new Size(193, 27);
            label3.TabIndex = 1;
            label3.Text = "PayMent Method:";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("FOT-Yuruka Std UB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.Location = new Point(462, 161);
            label4.Name = "label4";
            label4.Size = new Size(164, 27);
            label4.TabIndex = 1;
            label4.Text = "Phone number:";
            label4.Click += label1_Click;
            // 
            // txtQuantityStraw
            // 
            txtQuantityStraw.BackColor = Color.Cyan;
            txtQuantityStraw.Location = new Point(252, 175);
            txtQuantityStraw.Name = "txtQuantityStraw";
            txtQuantityStraw.Size = new Size(60, 27);
            txtQuantityStraw.TabIndex = 0;
            txtQuantityStraw.TextChanged += txtQuantityStraw_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("FOT-Yuruka Std UB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.Location = new Point(469, 300);
            label5.Name = "label5";
            label5.Size = new Size(62, 27);
            label5.TabIndex = 1;
            label5.Text = "Total";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("FOT-Yuruka Std UB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label6.Location = new Point(462, 253);
            label6.Name = "label6";
            label6.Size = new Size(173, 27);
            label6.TabIndex = 1;
            label6.Text = "Deliver Method:";
            label6.Click += label1_Click;
            // 
            // comboBoxDeliveryMethod
            // 
            comboBoxDeliveryMethod.FormattingEnabled = true;
            comboBoxDeliveryMethod.Location = new Point(661, 255);
            comboBoxDeliveryMethod.Name = "comboBoxDeliveryMethod";
            comboBoxDeliveryMethod.Size = new Size(193, 28);
            comboBoxDeliveryMethod.TabIndex = 3;
            comboBoxDeliveryMethod.SelectedIndexChanged += comboBoxDeliveryMethod_SelectedIndexChanged;
            comboBoxDeliveryMethod.Click += comboBoxDeliveryMethod_Click;
            // 
            // OnCart
            // 
            OnCart.Location = new Point(113, 383);
            OnCart.Name = "OnCart";
            OnCart.Size = new Size(741, 120);
            OnCart.TabIndex = 5;
            OnCart.UseCompatibleStateImageBehavior = false;
            OnCart.SelectedIndexChanged += OnCart_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(27, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(27, 216);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(27, 289);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 128);
            label8.Location = new Point(158, 151);
            label8.Name = "label8";
            label8.Size = new Size(154, 24);
            label8.TabIndex = 1;
            label8.Text = "Strawberry Cake";
            label8.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("FOT-Yuruka Std UB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label9.Location = new Point(158, 175);
            label9.Name = "label9";
            label9.Size = new Size(97, 27);
            label9.TabIndex = 1;
            label9.Text = "200.000";
            label9.Click += label1_Click;
            // 
            // txtQuantityChoco
            // 
            txtQuantityChoco.BackColor = Color.Cyan;
            txtQuantityChoco.Location = new Point(252, 251);
            txtQuantityChoco.Name = "txtQuantityChoco";
            txtQuantityChoco.Size = new Size(60, 27);
            txtQuantityChoco.TabIndex = 0;
            txtQuantityChoco.TextChanged += txtQuantityChoco_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 128);
            label10.Location = new Point(158, 227);
            label10.Name = "label10";
            label10.Size = new Size(152, 24);
            label10.TabIndex = 1;
            label10.Text = "Chocolate Cake";
            label10.Click += label1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("FOT-Yuruka Std UB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label11.Location = new Point(158, 251);
            label11.Name = "label11";
            label11.Size = new Size(97, 27);
            label11.TabIndex = 1;
            label11.Text = "200.000";
            label11.Click += label1_Click;
            // 
            // txtQuantityVanilla
            // 
            txtQuantityVanilla.BackColor = Color.Cyan;
            txtQuantityVanilla.Location = new Point(252, 323);
            txtQuantityVanilla.Name = "txtQuantityVanilla";
            txtQuantityVanilla.Size = new Size(60, 27);
            txtQuantityVanilla.TabIndex = 0;
            txtQuantityVanilla.TextChanged += txtQuantityVanilla_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 128);
            label12.Location = new Point(158, 299);
            label12.Name = "label12";
            label12.Size = new Size(126, 24);
            label12.TabIndex = 1;
            label12.Text = "Vanilla Cake";
            label12.Click += label1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("FOT-Yuruka Std UB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label13.Location = new Point(158, 323);
            label13.Name = "label13";
            label13.Size = new Size(97, 27);
            label13.TabIndex = 1;
            label13.Text = "200.000";
            label13.Click += label1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(5, 392);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(102, 69);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(661, 299);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(193, 27);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btnCloseAll
            // 
            btnCloseAll.BackColor = Color.Transparent;
            btnCloseAll.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseAll.ForeColor = Color.Black;
            btnCloseAll.Location = new Point(820, 2);
            btnCloseAll.Name = "btnCloseAll";
            btnCloseAll.Size = new Size(43, 31);
            btnCloseAll.TabIndex = 18;
            btnCloseAll.Text = "X";
            btnCloseAll.UseVisualStyleBackColor = false;
            btnCloseAll.Click += btnCloseAll_Click;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.output_onlinepngtools;
            ClientSize = new Size(866, 515);
            Controls.Add(btnCloseAll);
            Controls.Add(OnCart);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxDeliveryMethod);
            Controls.Add(comboBoxPayment);
            Controls.Add(btnOrder);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtQuantityVanilla);
            Controls.Add(txtQuantityChoco);
            Controls.Add(txtQuantityStraw);
            Controls.Add(txtTotal);
            Controls.Add(txtPhoneNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShopForm";
            Text = "ShopForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhoneNumber;
        private Label label1;
        private Button btnOrder;
        private ComboBox comboBoxPayment;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtQuantityStraw;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxDeliveryMethod;
        private ListView OnCart;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label8;
        private Label label9;
        private TextBox txtQuantityChoco;
        private Label label10;
        private Label label11;
        private TextBox txtQuantityVanilla;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox5;
        private TextBox txtTotal;
        private Button btnCloseAll;
    }
}