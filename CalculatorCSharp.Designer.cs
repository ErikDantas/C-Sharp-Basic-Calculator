namespace CalculadoraCsharp
{
	partial class mainfrm
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainfrm));
            this.btnexit = new System.Windows.Forms.Button();
            this.gboperators = new System.Windows.Forms.GroupBox();
            this.rbroot = new System.Windows.Forms.RadioButton();
            this.rbdivision = new System.Windows.Forms.RadioButton();
            this.rbmultiplication = new System.Windows.Forms.RadioButton();
            this.rbsubtraction = new System.Windows.Forms.RadioButton();
            this.rbaddition = new System.Windows.Forms.RadioButton();
            this.tbfirst = new System.Windows.Forms.TextBox();
            this.tbsecond = new System.Windows.Forms.TextBox();
            this.tbresult = new System.Windows.Forms.TextBox();
            this.lbsecond = new System.Windows.Forms.Label();
            this.lbfirst = new System.Windows.Forms.Label();
            this.lbresult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbname = new System.Windows.Forms.Label();
            this.gboperators.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(449, 124);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(149, 46);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // gboperators
            // 
            this.gboperators.Controls.Add(this.rbroot);
            this.gboperators.Controls.Add(this.rbdivision);
            this.gboperators.Controls.Add(this.rbmultiplication);
            this.gboperators.Controls.Add(this.rbsubtraction);
            this.gboperators.Controls.Add(this.rbaddition);
            this.gboperators.Location = new System.Drawing.Point(12, 12);
            this.gboperators.Name = "gboperators";
            this.gboperators.Size = new System.Drawing.Size(197, 158);
            this.gboperators.TabIndex = 1;
            this.gboperators.TabStop = false;
            this.gboperators.Text = "Operators";
            // 
            // rbroot
            // 
            this.rbroot.AutoSize = true;
            this.rbroot.Location = new System.Drawing.Point(34, 125);
            this.rbroot.Name = "rbroot";
            this.rbroot.Size = new System.Drawing.Size(53, 17);
            this.rbroot.TabIndex = 2;
            this.rbroot.Text = "Roots";
            this.rbroot.UseVisualStyleBackColor = true;
            this.rbroot.CheckedChanged += new System.EventHandler(this.rbroot_CheckedChanged);
            // 
            // rbdivision
            // 
            this.rbdivision.AutoSize = true;
            this.rbdivision.Location = new System.Drawing.Point(34, 102);
            this.rbdivision.Name = "rbdivision";
            this.rbdivision.Size = new System.Drawing.Size(62, 17);
            this.rbdivision.TabIndex = 3;
            this.rbdivision.Text = "Division";
            this.rbdivision.UseVisualStyleBackColor = true;
            this.rbdivision.CheckedChanged += new System.EventHandler(this.rbdivision_CheckedChanged);
            // 
            // rbmultiplication
            // 
            this.rbmultiplication.AutoSize = true;
            this.rbmultiplication.Location = new System.Drawing.Point(34, 78);
            this.rbmultiplication.Name = "rbmultiplication";
            this.rbmultiplication.Size = new System.Drawing.Size(86, 17);
            this.rbmultiplication.TabIndex = 2;
            this.rbmultiplication.Text = "Multiplication";
            this.rbmultiplication.UseVisualStyleBackColor = true;
            this.rbmultiplication.CheckedChanged += new System.EventHandler(this.rbmultiplication_CheckedChanged);
            // 
            // rbsubtraction
            // 
            this.rbsubtraction.AutoSize = true;
            this.rbsubtraction.Location = new System.Drawing.Point(34, 54);
            this.rbsubtraction.Name = "rbsubtraction";
            this.rbsubtraction.Size = new System.Drawing.Size(79, 17);
            this.rbsubtraction.TabIndex = 1;
            this.rbsubtraction.Text = "Subtraction";
            this.rbsubtraction.UseVisualStyleBackColor = true;
            this.rbsubtraction.CheckedChanged += new System.EventHandler(this.rbsubtraction_CheckedChanged);
            // 
            // rbaddition
            // 
            this.rbaddition.AutoSize = true;
            this.rbaddition.Location = new System.Drawing.Point(34, 30);
            this.rbaddition.Name = "rbaddition";
            this.rbaddition.Size = new System.Drawing.Size(63, 17);
            this.rbaddition.TabIndex = 0;
            this.rbaddition.Text = "Addition";
            this.rbaddition.UseVisualStyleBackColor = true;
            this.rbaddition.CheckedChanged += new System.EventHandler(this.rbaddition_CheckedChanged);
            // 
            // tbfirst
            // 
            this.tbfirst.Location = new System.Drawing.Point(212, 39);
            this.tbfirst.Name = "tbfirst";
            this.tbfirst.Size = new System.Drawing.Size(137, 20);
            this.tbfirst.TabIndex = 2;
            this.tbfirst.TextChanged += new System.EventHandler(this.tbfirst_TextChanged);
            // 
            // tbsecond
            // 
            this.tbsecond.Location = new System.Drawing.Point(212, 83);
            this.tbsecond.Name = "tbsecond";
            this.tbsecond.Size = new System.Drawing.Size(137, 20);
            this.tbsecond.TabIndex = 3;
            this.tbsecond.TextChanged += new System.EventHandler(this.tbsecond_TextChanged);
            // 
            // tbresult
            // 
            this.tbresult.Location = new System.Drawing.Point(212, 150);
            this.tbresult.Name = "tbresult";
            this.tbresult.Size = new System.Drawing.Size(149, 20);
            this.tbresult.TabIndex = 4;
            // 
            // lbsecond
            // 
            this.lbsecond.AutoSize = true;
            this.lbsecond.Location = new System.Drawing.Point(212, 67);
            this.lbsecond.Name = "lbsecond";
            this.lbsecond.Size = new System.Drawing.Size(84, 13);
            this.lbsecond.TabIndex = 5;
            this.lbsecond.Text = "Second Number";
            // 
            // lbfirst
            // 
            this.lbfirst.AutoSize = true;
            this.lbfirst.Location = new System.Drawing.Point(212, 22);
            this.lbfirst.Name = "lbfirst";
            this.lbfirst.Size = new System.Drawing.Size(66, 13);
            this.lbfirst.TabIndex = 6;
            this.lbfirst.Text = "First Number";
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(209, 133);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(40, 13);
            this.lbresult.TabIndex = 7;
            this.lbresult.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(13, 194);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(180, 26);
            this.lbname.TabIndex = 9;
            this.lbname.Text = "Created by: Jose Erik Ramos Dantas\r\njose.erikdantas@outlook.com";
            // 
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 229);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.lbfirst);
            this.Controls.Add(this.lbsecond);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.tbsecond);
            this.Controls.Add(this.tbfirst);
            this.Controls.Add(this.gboperators);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainfrm";
            this.Text = "Basic Calculator";
            this.gboperators.ResumeLayout(false);
            this.gboperators.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnexit;
		private System.Windows.Forms.GroupBox gboperators;
		private System.Windows.Forms.RadioButton rbroot;
		private System.Windows.Forms.RadioButton rbdivision;
		private System.Windows.Forms.RadioButton rbmultiplication;
		private System.Windows.Forms.RadioButton rbsubtraction;
		private System.Windows.Forms.RadioButton rbaddition;
		private System.Windows.Forms.TextBox tbfirst;
		private System.Windows.Forms.TextBox tbsecond;
		private System.Windows.Forms.TextBox tbresult;
		private System.Windows.Forms.Label lbsecond;
		private System.Windows.Forms.Label lbfirst;
		private System.Windows.Forms.Label lbresult;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbname;
    }
}

