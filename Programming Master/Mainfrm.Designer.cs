namespace Programming_Master
{
    partial class Mainfrm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bttnSubmission = new FontAwesome.Sharp.IconButton();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.bttnAdHoc = new FontAwesome.Sharp.IconButton();
            this.bttnMathemitics = new FontAwesome.Sharp.IconButton();
            this.bttnDataStructure = new FontAwesome.Sharp.IconButton();
            this.bttnBeginner = new FontAwesome.Sharp.IconButton();
            this.bttnAbout = new FontAwesome.Sharp.IconButton();
            this.bttnProblem = new FontAwesome.Sharp.IconButton();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.maximize = new FontAwesome.Sharp.IconButton();
            this.exit = new FontAwesome.Sharp.IconButton();
            this.titleChildform = new System.Windows.Forms.Label();
            this.iconcurrentfrom = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelOpenProblem = new System.Windows.Forms.Panel();
            this.textviewProblemNo = new System.Windows.Forms.TextBox();
            this.bttnShow = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentfrom)).BeginInit();
            this.panelOpenProblem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.panelMenu.Controls.Add(this.bttnSubmission);
            this.panelMenu.Controls.Add(this.panelSubMenu);
            this.panelMenu.Controls.Add(this.bttnAbout);
            this.panelMenu.Controls.Add(this.bttnProblem);
            this.panelMenu.Controls.Add(this.panelHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(178, 742);
            this.panelMenu.TabIndex = 0;
            // 
            // bttnSubmission
            // 
            this.bttnSubmission.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnSubmission.FlatAppearance.BorderSize = 0;
            this.bttnSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSubmission.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bttnSubmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubmission.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttnSubmission.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.bttnSubmission.IconColor = System.Drawing.Color.Gainsboro;
            this.bttnSubmission.IconSize = 32;
            this.bttnSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSubmission.Location = new System.Drawing.Point(0, 403);
            this.bttnSubmission.Name = "bttnSubmission";
            this.bttnSubmission.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttnSubmission.Rotation = 0D;
            this.bttnSubmission.Size = new System.Drawing.Size(178, 50);
            this.bttnSubmission.TabIndex = 5;
            this.bttnSubmission.Text = "Submission";
            this.bttnSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnSubmission.UseVisualStyleBackColor = true;
            this.bttnSubmission.Click += new System.EventHandler(this.bttnSubmission_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panelSubMenu.Controls.Add(this.bttnAdHoc);
            this.panelSubMenu.Controls.Add(this.bttnMathemitics);
            this.panelSubMenu.Controls.Add(this.bttnDataStructure);
            this.panelSubMenu.Controls.Add(this.bttnBeginner);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 198);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(178, 205);
            this.panelSubMenu.TabIndex = 4;
            // 
            // bttnAdHoc
            // 
            this.bttnAdHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnAdHoc.FlatAppearance.BorderSize = 0;
            this.bttnAdHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdHoc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bttnAdHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdHoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttnAdHoc.IconChar = FontAwesome.Sharp.IconChar.FreeCodeCamp;
            this.bttnAdHoc.IconColor = System.Drawing.Color.Gainsboro;
            this.bttnAdHoc.IconSize = 32;
            this.bttnAdHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAdHoc.Location = new System.Drawing.Point(0, 150);
            this.bttnAdHoc.Name = "bttnAdHoc";
            this.bttnAdHoc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttnAdHoc.Rotation = 0D;
            this.bttnAdHoc.Size = new System.Drawing.Size(178, 50);
            this.bttnAdHoc.TabIndex = 5;
            this.bttnAdHoc.Text = "Ad-Hoc";
            this.bttnAdHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAdHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnAdHoc.UseVisualStyleBackColor = true;
            this.bttnAdHoc.Click += new System.EventHandler(this.bttnAdHoc_Click);
            // 
            // bttnMathemitics
            // 
            this.bttnMathemitics.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnMathemitics.FlatAppearance.BorderSize = 0;
            this.bttnMathemitics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMathemitics.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bttnMathemitics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMathemitics.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttnMathemitics.IconChar = FontAwesome.Sharp.IconChar.FreeCodeCamp;
            this.bttnMathemitics.IconColor = System.Drawing.Color.Gainsboro;
            this.bttnMathemitics.IconSize = 32;
            this.bttnMathemitics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnMathemitics.Location = new System.Drawing.Point(0, 100);
            this.bttnMathemitics.Name = "bttnMathemitics";
            this.bttnMathemitics.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttnMathemitics.Rotation = 0D;
            this.bttnMathemitics.Size = new System.Drawing.Size(178, 50);
            this.bttnMathemitics.TabIndex = 4;
            this.bttnMathemitics.Text = "Mathematics";
            this.bttnMathemitics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnMathemitics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnMathemitics.UseVisualStyleBackColor = true;
            this.bttnMathemitics.Click += new System.EventHandler(this.bttnMathemitics_Click);
            // 
            // bttnDataStructure
            // 
            this.bttnDataStructure.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnDataStructure.FlatAppearance.BorderSize = 0;
            this.bttnDataStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDataStructure.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bttnDataStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDataStructure.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttnDataStructure.IconChar = FontAwesome.Sharp.IconChar.FreeCodeCamp;
            this.bttnDataStructure.IconColor = System.Drawing.Color.Gainsboro;
            this.bttnDataStructure.IconSize = 32;
            this.bttnDataStructure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnDataStructure.Location = new System.Drawing.Point(0, 50);
            this.bttnDataStructure.Name = "bttnDataStructure";
            this.bttnDataStructure.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttnDataStructure.Rotation = 0D;
            this.bttnDataStructure.Size = new System.Drawing.Size(178, 50);
            this.bttnDataStructure.TabIndex = 3;
            this.bttnDataStructure.Text = "Data Structure";
            this.bttnDataStructure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnDataStructure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnDataStructure.UseVisualStyleBackColor = true;
            this.bttnDataStructure.Click += new System.EventHandler(this.bttnDataStructure_Click);
            // 
            // bttnBeginner
            // 
            this.bttnBeginner.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnBeginner.FlatAppearance.BorderSize = 0;
            this.bttnBeginner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBeginner.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bttnBeginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBeginner.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttnBeginner.IconChar = FontAwesome.Sharp.IconChar.FreeCodeCamp;
            this.bttnBeginner.IconColor = System.Drawing.Color.Gainsboro;
            this.bttnBeginner.IconSize = 32;
            this.bttnBeginner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBeginner.Location = new System.Drawing.Point(0, 0);
            this.bttnBeginner.Name = "bttnBeginner";
            this.bttnBeginner.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttnBeginner.Rotation = 0D;
            this.bttnBeginner.Size = new System.Drawing.Size(178, 50);
            this.bttnBeginner.TabIndex = 2;
            this.bttnBeginner.Text = "Beginner";
            this.bttnBeginner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBeginner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnBeginner.UseVisualStyleBackColor = true;
            this.bttnBeginner.Click += new System.EventHandler(this.bttnBeginner_Click);
            // 
            // bttnAbout
            // 
            this.bttnAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnAbout.FlatAppearance.BorderSize = 0;
            this.bttnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAbout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bttnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttnAbout.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.bttnAbout.IconColor = System.Drawing.Color.Gainsboro;
            this.bttnAbout.IconSize = 32;
            this.bttnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAbout.Location = new System.Drawing.Point(0, 692);
            this.bttnAbout.Name = "bttnAbout";
            this.bttnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttnAbout.Rotation = 0D;
            this.bttnAbout.Size = new System.Drawing.Size(178, 50);
            this.bttnAbout.TabIndex = 3;
            this.bttnAbout.Text = "About Me";
            this.bttnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnAbout.UseVisualStyleBackColor = true;
            this.bttnAbout.Click += new System.EventHandler(this.bttnAbout_Click);
            // 
            // bttnProblem
            // 
            this.bttnProblem.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnProblem.FlatAppearance.BorderSize = 0;
            this.bttnProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnProblem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bttnProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnProblem.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttnProblem.IconChar = FontAwesome.Sharp.IconChar.FreeCodeCamp;
            this.bttnProblem.IconColor = System.Drawing.Color.Gainsboro;
            this.bttnProblem.IconSize = 32;
            this.bttnProblem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnProblem.Location = new System.Drawing.Point(0, 148);
            this.bttnProblem.Name = "bttnProblem";
            this.bttnProblem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bttnProblem.Rotation = 0D;
            this.bttnProblem.Size = new System.Drawing.Size(178, 50);
            this.bttnProblem.TabIndex = 1;
            this.bttnProblem.Text = "Problems";
            this.bttnProblem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnProblem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnProblem.UseVisualStyleBackColor = true;
            this.bttnProblem.Click += new System.EventHandler(this.BttnProblem_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(178, 148);
            this.panelHome.TabIndex = 0;
            this.panelHome.Click += new System.EventHandler(this.panalHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::Programming_Master.Properties.Resources.LogoMakr_5mMGeA;
            this.btnHome.Location = new System.Drawing.Point(12, 38);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(156, 87);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.maximize);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.titleChildform);
            this.panel2.Controls.Add(this.iconcurrentfrom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(178, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 38);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.Red;
            this.minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize.IconColor = System.Drawing.Color.Gainsboro;
            this.minimize.IconSize = 32;
            this.minimize.Location = new System.Drawing.Point(1006, 6);
            this.minimize.Name = "minimize";
            this.minimize.Rotation = 0D;
            this.minimize.Size = new System.Drawing.Size(33, 26);
            this.minimize.TabIndex = 4;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize.ForeColor = System.Drawing.Color.Red;
            this.maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximize.IconColor = System.Drawing.Color.Gainsboro;
            this.maximize.IconSize = 32;
            this.maximize.Location = new System.Drawing.Point(1045, 7);
            this.maximize.Name = "maximize";
            this.maximize.Rotation = 0D;
            this.maximize.Size = new System.Drawing.Size(33, 26);
            this.maximize.TabIndex = 3;
            this.maximize.UseVisualStyleBackColor = true;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.exit.IconColor = System.Drawing.Color.Red;
            this.exit.IconSize = 32;
            this.exit.Location = new System.Drawing.Point(1084, 7);
            this.exit.Name = "exit";
            this.exit.Rotation = 0D;
            this.exit.Size = new System.Drawing.Size(33, 26);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // titleChildform
            // 
            this.titleChildform.AutoSize = true;
            this.titleChildform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleChildform.ForeColor = System.Drawing.Color.GhostWhite;
            this.titleChildform.Location = new System.Drawing.Point(42, 14);
            this.titleChildform.Name = "titleChildform";
            this.titleChildform.Size = new System.Drawing.Size(45, 16);
            this.titleChildform.TabIndex = 1;
            this.titleChildform.Text = "Home";
            // 
            // iconcurrentfrom
            // 
            this.iconcurrentfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconcurrentfrom.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconcurrentfrom.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconcurrentfrom.IconColor = System.Drawing.Color.MediumPurple;
            this.iconcurrentfrom.IconSize = 27;
            this.iconcurrentfrom.Location = new System.Drawing.Point(6, 9);
            this.iconcurrentfrom.Name = "iconcurrentfrom";
            this.iconcurrentfrom.Size = new System.Drawing.Size(34, 27);
            this.iconcurrentfrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcurrentfrom.TabIndex = 0;
            this.iconcurrentfrom.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(178, 642);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(178, 637);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1120, 5);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1293, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 559);
            this.panel6.TabIndex = 5;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(183, 78);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1110, 559);
            this.panelDesktop.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(178, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 559);
            this.panel7.TabIndex = 6;
            // 
            // panelOpenProblem
            // 
            this.panelOpenProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.panelOpenProblem.Controls.Add(this.textviewProblemNo);
            this.panelOpenProblem.Controls.Add(this.bttnShow);
            this.panelOpenProblem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpenProblem.Location = new System.Drawing.Point(178, 38);
            this.panelOpenProblem.Name = "panelOpenProblem";
            this.panelOpenProblem.Size = new System.Drawing.Size(1120, 40);
            this.panelOpenProblem.TabIndex = 3;
            // 
            // textviewProblemNo
            // 
            this.textviewProblemNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textviewProblemNo.Location = new System.Drawing.Point(927, 11);
            this.textviewProblemNo.Name = "textviewProblemNo";
            this.textviewProblemNo.Size = new System.Drawing.Size(100, 20);
            this.textviewProblemNo.TabIndex = 4;
            // 
            // bttnShow
            // 
            this.bttnShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnShow.FlatAppearance.BorderSize = 0;
            this.bttnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnShow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bttnShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.bttnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.bttnShow.IconColor = System.Drawing.Color.Gainsboro;
            this.bttnShow.IconSize = 16;
            this.bttnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnShow.Location = new System.Drawing.Point(1033, 9);
            this.bttnShow.Name = "bttnShow";
            this.bttnShow.Rotation = 0D;
            this.bttnShow.Size = new System.Drawing.Size(75, 23);
            this.bttnShow.TabIndex = 3;
            this.bttnShow.Text = "Show";
            this.bttnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnShow.UseVisualStyleBackColor = true;
            this.bttnShow.Click += new System.EventHandler(this.bttnShow_Click);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 742);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelOpenProblem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1314, 736);
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentfrom)).EndInit();
            this.panelOpenProblem.ResumeLayout(false);
            this.panelOpenProblem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton bttnAbout;
        private FontAwesome.Sharp.IconButton bttnProblem;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconcurrentfrom;
        private System.Windows.Forms.Label titleChildform;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton exit;
        private FontAwesome.Sharp.IconButton minimize;
        private FontAwesome.Sharp.IconButton maximize;
        public System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton bttnSubmission;
        private System.Windows.Forms.Panel panelSubMenu;
        private FontAwesome.Sharp.IconButton bttnAdHoc;
        private FontAwesome.Sharp.IconButton bttnMathemitics;
        private FontAwesome.Sharp.IconButton bttnDataStructure;
        private FontAwesome.Sharp.IconButton bttnBeginner;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelOpenProblem;
        private System.Windows.Forms.TextBox textviewProblemNo;
        private FontAwesome.Sharp.IconButton bttnShow;
    }
}

