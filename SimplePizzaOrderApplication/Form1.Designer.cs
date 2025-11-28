namespace SimplePizzaOrderApplication
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
            this.grSizes = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMediam = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.grCrustTypes = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.grWhereToEat = new System.Windows.Forms.GroupBox();
            this.rb_TakeOut = new System.Windows.Forms.RadioButton();
            this.rb_EatIn = new System.Windows.Forms.RadioButton();
            this.rtbBill = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grSauces = new System.Windows.Forms.GroupBox();
            this.chkHotSauce = new System.Windows.Forms.CheckBox();
            this.chkAlfredoSauce = new System.Windows.Forms.CheckBox();
            this.chkBBQSauce = new System.Windows.Forms.CheckBox();
            this.grHerbs = new System.Windows.Forms.GroupBox();
            this.chkThyme = new System.Windows.Forms.CheckBox();
            this.chkOregano = new System.Windows.Forms.CheckBox();
            this.grFruits = new System.Windows.Forms.GroupBox();
            this.chkBananaBeppers = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.grVegetables = new System.Windows.Forms.GroupBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.grCheeses = new System.Windows.Forms.GroupBox();
            this.chkParmesan = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.grMeats = new System.Windows.Forms.GroupBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.grSizes.SuspendLayout();
            this.grCrustTypes.SuspendLayout();
            this.grWhereToEat.SuspendLayout();
            this.grSauces.SuspendLayout();
            this.grHerbs.SuspendLayout();
            this.grFruits.SuspendLayout();
            this.grVegetables.SuspendLayout();
            this.grCheeses.SuspendLayout();
            this.grMeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // grSizes
            // 
            this.grSizes.BackColor = System.Drawing.Color.Transparent;
            this.grSizes.Controls.Add(this.rbLarge);
            this.grSizes.Controls.Add(this.rbMediam);
            this.grSizes.Controls.Add(this.rbSmall);
            this.grSizes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grSizes.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSizes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grSizes.Location = new System.Drawing.Point(373, 363);
            this.grSizes.Name = "grSizes";
            this.grSizes.Size = new System.Drawing.Size(175, 223);
            this.grSizes.TabIndex = 0;
            this.grSizes.TabStop = false;
            this.grSizes.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(23, 150);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(98, 39);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "15";
            this.rbLarge.Text = "Large";
            this.rbLarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMediam
            // 
            this.rbMediam.AutoSize = true;
            this.rbMediam.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMediam.Location = new System.Drawing.Point(23, 105);
            this.rbMediam.Name = "rbMediam";
            this.rbMediam.Size = new System.Drawing.Size(131, 39);
            this.rbMediam.TabIndex = 2;
            this.rbMediam.TabStop = true;
            this.rbMediam.Tag = "10";
            this.rbMediam.Text = "Mediam";
            this.rbMediam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMediam.UseVisualStyleBackColor = true;
            this.rbMediam.CheckedChanged += new System.EventHandler(this.rbMediam_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(23, 58);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(98, 39);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "5";
            this.rbSmall.Text = "Small";
            this.rbSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // grCrustTypes
            // 
            this.grCrustTypes.BackColor = System.Drawing.Color.Transparent;
            this.grCrustTypes.Controls.Add(this.rbThick);
            this.grCrustTypes.Controls.Add(this.rbThin);
            this.grCrustTypes.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grCrustTypes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grCrustTypes.Location = new System.Drawing.Point(347, 625);
            this.grCrustTypes.Name = "grCrustTypes";
            this.grCrustTypes.Size = new System.Drawing.Size(229, 184);
            this.grCrustTypes.TabIndex = 4;
            this.grCrustTypes.TabStop = false;
            this.grCrustTypes.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.Location = new System.Drawing.Point(40, 115);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(172, 39);
            this.rbThick.TabIndex = 6;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.Location = new System.Drawing.Point(40, 58);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(161, 39);
            this.rbThin.TabIndex = 5;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // grWhereToEat
            // 
            this.grWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.grWhereToEat.Controls.Add(this.rb_TakeOut);
            this.grWhereToEat.Controls.Add(this.rb_EatIn);
            this.grWhereToEat.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grWhereToEat.ForeColor = System.Drawing.Color.LightCyan;
            this.grWhereToEat.Location = new System.Drawing.Point(1187, 418);
            this.grWhereToEat.Name = "grWhereToEat";
            this.grWhereToEat.Size = new System.Drawing.Size(229, 150);
            this.grWhereToEat.TabIndex = 26;
            this.grWhereToEat.TabStop = false;
            this.grWhereToEat.Text = "Where To Eat";
            // 
            // rb_TakeOut
            // 
            this.rb_TakeOut.AutoSize = true;
            this.rb_TakeOut.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TakeOut.Location = new System.Drawing.Point(35, 91);
            this.rb_TakeOut.Name = "rb_TakeOut";
            this.rb_TakeOut.Size = new System.Drawing.Size(146, 39);
            this.rb_TakeOut.TabIndex = 28;
            this.rb_TakeOut.TabStop = true;
            this.rb_TakeOut.Text = "Take Out";
            this.rb_TakeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_TakeOut.UseVisualStyleBackColor = true;
            // 
            // rb_EatIn
            // 
            this.rb_EatIn.AutoSize = true;
            this.rb_EatIn.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_EatIn.Location = new System.Drawing.Point(35, 44);
            this.rb_EatIn.Name = "rb_EatIn";
            this.rb_EatIn.Size = new System.Drawing.Size(105, 39);
            this.rb_EatIn.TabIndex = 27;
            this.rb_EatIn.TabStop = true;
            this.rb_EatIn.Text = "Eat In";
            this.rb_EatIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_EatIn.UseVisualStyleBackColor = true;
            // 
            // rtbBill
            // 
            this.rtbBill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbBill.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbBill.Location = new System.Drawing.Point(1478, 388);
            this.rtbBill.Name = "rtbBill";
            this.rtbBill.ReadOnly = true;
            this.rtbBill.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbBill.Size = new System.Drawing.Size(320, 430);
            this.rtbBill.TabIndex = 18;
            this.rtbBill.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(1179, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 46);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total Price:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTotalPrice.Location = new System.Drawing.Point(1386, 608);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(65, 46);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.Tag = "";
            this.lblTotalPrice.Text = "$0";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder.Location = new System.Drawing.Point(1187, 693);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(237, 52);
            this.btnOrder.TabIndex = 29;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCoral;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(1187, 784);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(237, 52);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grSauces
            // 
            this.grSauces.BackColor = System.Drawing.Color.Transparent;
            this.grSauces.Controls.Add(this.chkHotSauce);
            this.grSauces.Controls.Add(this.chkAlfredoSauce);
            this.grSauces.Controls.Add(this.chkBBQSauce);
            this.grSauces.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSauces.ForeColor = System.Drawing.Color.Cyan;
            this.grSauces.Location = new System.Drawing.Point(908, 659);
            this.grSauces.Name = "grSauces";
            this.grSauces.Size = new System.Drawing.Size(247, 176);
            this.grSauces.TabIndex = 22;
            this.grSauces.TabStop = false;
            this.grSauces.Tag = "6";
            this.grSauces.Text = "Sauce";
            // 
            // chkHotSauce
            // 
            this.chkHotSauce.AutoSize = true;
            this.chkHotSauce.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHotSauce.Location = new System.Drawing.Point(28, 136);
            this.chkHotSauce.Name = "chkHotSauce";
            this.chkHotSauce.Size = new System.Drawing.Size(157, 39);
            this.chkHotSauce.TabIndex = 25;
            this.chkHotSauce.Tag = "3";
            this.chkHotSauce.Text = "Hot Sauce";
            this.chkHotSauce.UseVisualStyleBackColor = true;
            this.chkHotSauce.CheckedChanged += new System.EventHandler(this.chkHotSauce_CheckedChanged);
            // 
            // chkAlfredoSauce
            // 
            this.chkAlfredoSauce.AutoSize = true;
            this.chkAlfredoSauce.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlfredoSauce.Location = new System.Drawing.Point(28, 98);
            this.chkAlfredoSauce.Name = "chkAlfredoSauce";
            this.chkAlfredoSauce.Size = new System.Drawing.Size(201, 39);
            this.chkAlfredoSauce.TabIndex = 24;
            this.chkAlfredoSauce.Tag = "5";
            this.chkAlfredoSauce.Text = "Alfredo Sauce";
            this.chkAlfredoSauce.UseVisualStyleBackColor = true;
            this.chkAlfredoSauce.CheckedChanged += new System.EventHandler(this.chkAlfredoSauce_CheckedChanged);
            // 
            // chkBBQSauce
            // 
            this.chkBBQSauce.AutoSize = true;
            this.chkBBQSauce.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBBQSauce.Location = new System.Drawing.Point(28, 54);
            this.chkBBQSauce.Name = "chkBBQSauce";
            this.chkBBQSauce.Size = new System.Drawing.Size(160, 39);
            this.chkBBQSauce.TabIndex = 23;
            this.chkBBQSauce.Tag = "3";
            this.chkBBQSauce.Text = "BBQ Sauce";
            this.chkBBQSauce.UseVisualStyleBackColor = true;
            this.chkBBQSauce.CheckedChanged += new System.EventHandler(this.chkBBQSauce_CheckedChanged);
            // 
            // grHerbs
            // 
            this.grHerbs.BackColor = System.Drawing.Color.Transparent;
            this.grHerbs.Controls.Add(this.chkThyme);
            this.grHerbs.Controls.Add(this.chkOregano);
            this.grHerbs.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHerbs.ForeColor = System.Drawing.Color.LawnGreen;
            this.grHerbs.Location = new System.Drawing.Point(648, 674);
            this.grHerbs.Name = "grHerbs";
            this.grHerbs.Size = new System.Drawing.Size(202, 142);
            this.grHerbs.TabIndex = 19;
            this.grHerbs.TabStop = false;
            this.grHerbs.Tag = "5";
            this.grHerbs.Text = "Herbs";
            // 
            // chkThyme
            // 
            this.chkThyme.AutoSize = true;
            this.chkThyme.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThyme.Location = new System.Drawing.Point(28, 96);
            this.chkThyme.Name = "chkThyme";
            this.chkThyme.Size = new System.Drawing.Size(118, 39);
            this.chkThyme.TabIndex = 21;
            this.chkThyme.Tag = "5";
            this.chkThyme.Text = "Thyme";
            this.chkThyme.UseVisualStyleBackColor = true;
            this.chkThyme.CheckedChanged += new System.EventHandler(this.chkThyme_CheckedChanged);
            // 
            // chkOregano
            // 
            this.chkOregano.AutoSize = true;
            this.chkOregano.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOregano.Location = new System.Drawing.Point(28, 54);
            this.chkOregano.Name = "chkOregano";
            this.chkOregano.Size = new System.Drawing.Size(140, 39);
            this.chkOregano.TabIndex = 20;
            this.chkOregano.Tag = "5";
            this.chkOregano.Text = "Oregano";
            this.chkOregano.UseVisualStyleBackColor = true;
            this.chkOregano.CheckedChanged += new System.EventHandler(this.chkOregano_CheckedChanged);
            // 
            // grFruits
            // 
            this.grFruits.BackColor = System.Drawing.Color.Transparent;
            this.grFruits.Controls.Add(this.chkBananaBeppers);
            this.grFruits.Controls.Add(this.chkPineapple);
            this.grFruits.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grFruits.ForeColor = System.Drawing.Color.GreenYellow;
            this.grFruits.Location = new System.Drawing.Point(908, 496);
            this.grFruits.Name = "grFruits";
            this.grFruits.Size = new System.Drawing.Size(256, 142);
            this.grFruits.TabIndex = 16;
            this.grFruits.TabStop = false;
            this.grFruits.Tag = "4";
            this.grFruits.Text = "Fruits";
            // 
            // chkBananaBeppers
            // 
            this.chkBananaBeppers.AutoSize = true;
            this.chkBananaBeppers.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBananaBeppers.Location = new System.Drawing.Point(28, 96);
            this.chkBananaBeppers.Name = "chkBananaBeppers";
            this.chkBananaBeppers.Size = new System.Drawing.Size(210, 39);
            this.chkBananaBeppers.TabIndex = 18;
            this.chkBananaBeppers.Tag = "3";
            this.chkBananaBeppers.Text = "Banana Pepper";
            this.chkBananaBeppers.UseVisualStyleBackColor = true;
            this.chkBananaBeppers.CheckedChanged += new System.EventHandler(this.chkBananaBeppers_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapple.Location = new System.Drawing.Point(28, 54);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(151, 39);
            this.chkPineapple.TabIndex = 17;
            this.chkPineapple.Tag = "6";
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.chkPineapple_CheckedChanged);
            // 
            // grVegetables
            // 
            this.grVegetables.BackColor = System.Drawing.Color.Transparent;
            this.grVegetables.Controls.Add(this.chkMushroom);
            this.grVegetables.Controls.Add(this.chkOnion);
            this.grVegetables.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grVegetables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grVegetables.Location = new System.Drawing.Point(648, 512);
            this.grVegetables.Name = "grVegetables";
            this.grVegetables.Size = new System.Drawing.Size(236, 142);
            this.grVegetables.TabIndex = 13;
            this.grVegetables.TabStop = false;
            this.grVegetables.Tag = "3";
            this.grVegetables.Text = "Vegetables";
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushroom.Location = new System.Drawing.Point(45, 99);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(169, 39);
            this.chkMushroom.TabIndex = 15;
            this.chkMushroom.Tag = "5";
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(45, 54);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(113, 39);
            this.chkOnion.TabIndex = 14;
            this.chkOnion.Tag = "3";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // grCheeses
            // 
            this.grCheeses.BackColor = System.Drawing.Color.Transparent;
            this.grCheeses.Controls.Add(this.chkParmesan);
            this.grCheeses.Controls.Add(this.chkExtraCheese);
            this.grCheeses.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grCheeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grCheeses.Location = new System.Drawing.Point(908, 318);
            this.grCheeses.Name = "grCheeses";
            this.grCheeses.Size = new System.Drawing.Size(243, 155);
            this.grCheeses.TabIndex = 10;
            this.grCheeses.TabStop = false;
            this.grCheeses.Tag = "2";
            this.grCheeses.Text = "Cheeses";
            // 
            // chkParmesan
            // 
            this.chkParmesan.AutoSize = true;
            this.chkParmesan.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParmesan.Location = new System.Drawing.Point(28, 99);
            this.chkParmesan.Name = "chkParmesan";
            this.chkParmesan.Size = new System.Drawing.Size(149, 39);
            this.chkParmesan.TabIndex = 12;
            this.chkParmesan.Tag = "10";
            this.chkParmesan.Text = "Parmesan";
            this.chkParmesan.UseVisualStyleBackColor = true;
            this.chkParmesan.CheckedChanged += new System.EventHandler(this.chkParmesan_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(28, 58);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(187, 39);
            this.chkExtraCheese.TabIndex = 11;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // grMeats
            // 
            this.grMeats.BackColor = System.Drawing.Color.Transparent;
            this.grMeats.Controls.Add(this.chkChicken);
            this.grMeats.Controls.Add(this.chkPepperoni);
            this.grMeats.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grMeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grMeats.Location = new System.Drawing.Point(648, 318);
            this.grMeats.Name = "grMeats";
            this.grMeats.Size = new System.Drawing.Size(236, 155);
            this.grMeats.TabIndex = 7;
            this.grMeats.TabStop = false;
            this.grMeats.Tag = "1";
            this.grMeats.Text = "Meats";
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChicken.Location = new System.Drawing.Point(45, 99);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(132, 39);
            this.chkChicken.TabIndex = 9;
            this.chkChicken.Tag = "5";
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            this.chkChicken.CheckedChanged += new System.EventHandler(this.chkChicken_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepperoni.Location = new System.Drawing.Point(45, 54);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(157, 39);
            this.chkPepperoni.TabIndex = 8;
            this.chkPepperoni.Tag = "10";
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkPepperoni_CheckedChanged);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblToppings.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Black;
            this.lblToppings.Location = new System.Drawing.Point(641, 253);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(115, 37);
            this.lblToppings.TabIndex = 38;
            this.lblToppings.Tag = "";
            this.lblToppings.Text = "Toppings:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(739, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 118);
            this.label1.TabIndex = 39;
            this.label1.Text = "Make Your Pizza";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSize.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Black;
            this.lblSize.Location = new System.Drawing.Point(641, 129);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(62, 37);
            this.lblSize.TabIndex = 40;
            this.lblSize.Tag = "";
            this.lblSize.Text = "Size:";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCrust.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrust.ForeColor = System.Drawing.Color.Black;
            this.lblCrust.Location = new System.Drawing.Point(643, 188);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(127, 37);
            this.lblCrust.TabIndex = 41;
            this.lblCrust.Tag = "";
            this.lblCrust.Text = "Crust Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1855, 866);
            this.Controls.Add(this.lblCrust);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.grSauces);
            this.Controls.Add(this.grHerbs);
            this.Controls.Add(this.grFruits);
            this.Controls.Add(this.grVegetables);
            this.Controls.Add(this.grCheeses);
            this.Controls.Add(this.grMeats);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbBill);
            this.Controls.Add(this.grWhereToEat);
            this.Controls.Add(this.grCrustTypes);
            this.Controls.Add(this.grSizes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "PizzaOrderPage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grSizes.ResumeLayout(false);
            this.grSizes.PerformLayout();
            this.grCrustTypes.ResumeLayout(false);
            this.grCrustTypes.PerformLayout();
            this.grWhereToEat.ResumeLayout(false);
            this.grWhereToEat.PerformLayout();
            this.grSauces.ResumeLayout(false);
            this.grSauces.PerformLayout();
            this.grHerbs.ResumeLayout(false);
            this.grHerbs.PerformLayout();
            this.grFruits.ResumeLayout(false);
            this.grFruits.PerformLayout();
            this.grVegetables.ResumeLayout(false);
            this.grVegetables.PerformLayout();
            this.grCheeses.ResumeLayout(false);
            this.grCheeses.PerformLayout();
            this.grMeats.ResumeLayout(false);
            this.grMeats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grSizes;
        private System.Windows.Forms.GroupBox grCrustTypes;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox grWhereToEat;
        private System.Windows.Forms.RichTextBox rtbBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMediam;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rb_TakeOut;
        private System.Windows.Forms.RadioButton rb_EatIn;
        private System.Windows.Forms.GroupBox grSauces;
        private System.Windows.Forms.CheckBox chkHotSauce;
        private System.Windows.Forms.CheckBox chkAlfredoSauce;
        private System.Windows.Forms.CheckBox chkBBQSauce;
        private System.Windows.Forms.GroupBox grHerbs;
        private System.Windows.Forms.CheckBox chkThyme;
        private System.Windows.Forms.CheckBox chkOregano;
        private System.Windows.Forms.GroupBox grFruits;
        private System.Windows.Forms.CheckBox chkBananaBeppers;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.GroupBox grVegetables;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox grCheeses;
        private System.Windows.Forms.CheckBox chkParmesan;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox grMeats;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCrust;
    }
}

