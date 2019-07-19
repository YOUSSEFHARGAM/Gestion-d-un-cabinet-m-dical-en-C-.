using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace gestionRdv
{
	/// <summary>
	/// Description résumée de AdminInterface.
	/// </summary>
	public class AdminInterface : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.TextBox txtVille;
		private System.Windows.Forms.TextBox txtCodePostal;
		private System.Windows.Forms.TextBox txtAdMed;
		private System.Windows.Forms.TextBox txtPrenomMed;
		private System.Windows.Forms.TextBox txtNomMed;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtSpeMed;
		private System.Windows.Forms.TextBox txtMobilMed;
		private System.Windows.Forms.Button btnEnregMed;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtTelSec;
		private System.Windows.Forms.TextBox txtVilleSec;
		private System.Windows.Forms.TextBox txtCpSec;
		private System.Windows.Forms.TextBox txtAdSec;
		private System.Windows.Forms.TextBox txtPrenomSec;
		private System.Windows.Forms.TextBox txtNomSec;
		private System.Windows.Forms.ComboBox cmbContratSec;
		private System.Windows.Forms.Button btnEnregSec;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtMdp;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtPwdSec;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtMailSec;
		private System.Windows.Forms.TextBox textBox2;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AdminInterface()
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			//
			// TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
			//
		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label17 = new System.Windows.Forms.Label();
			this.txtMdp = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnEnregMed = new System.Windows.Forms.Button();
			this.txtMobilMed = new System.Windows.Forms.TextBox();
			this.txtSpeMed = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtVille = new System.Windows.Forms.TextBox();
			this.txtCodePostal = new System.Windows.Forms.TextBox();
			this.txtAdMed = new System.Windows.Forms.TextBox();
			this.txtPrenomMed = new System.Windows.Forms.TextBox();
			this.txtNomMed = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnEnregSec = new System.Windows.Forms.Button();
			this.cmbContratSec = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtTelSec = new System.Windows.Forms.TextBox();
			this.txtVilleSec = new System.Windows.Forms.TextBox();
			this.txtCpSec = new System.Windows.Forms.TextBox();
			this.txtAdSec = new System.Windows.Forms.TextBox();
			this.txtPrenomSec = new System.Windows.Forms.TextBox();
			this.txtNomSec = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtPwdSec = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtMailSec = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(88, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Interface d\'administration";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(40, 48);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(424, 440);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label17);
			this.tabPage1.Controls.Add(this.txtMdp);
			this.tabPage1.Controls.Add(this.label18);
			this.tabPage1.Controls.Add(this.txtMail);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.btnEnregMed);
			this.tabPage1.Controls.Add(this.txtMobilMed);
			this.tabPage1.Controls.Add(this.txtSpeMed);
			this.tabPage1.Controls.Add(this.label15);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txtTel);
			this.tabPage1.Controls.Add(this.txtVille);
			this.tabPage1.Controls.Add(this.txtCodePostal);
			this.tabPage1.Controls.Add(this.txtAdMed);
			this.tabPage1.Controls.Add(this.txtPrenomMed);
			this.tabPage1.Controls.Add(this.txtNomMed);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(416, 414);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Medecin";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(90, 304);
			this.label17.Name = "label17";
			this.label17.TabIndex = 34;
			this.label17.Text = "mot de passe";
			// 
			// txtMdp
			// 
			this.txtMdp.Location = new System.Drawing.Point(226, 304);
			this.txtMdp.Name = "txtMdp";
			this.txtMdp.TabIndex = 33;
			this.txtMdp.Text = "";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(90, 272);
			this.label18.Name = "label18";
			this.label18.TabIndex = 32;
			this.label18.Text = "Mail";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(226, 272);
			this.txtMail.Name = "txtMail";
			this.txtMail.TabIndex = 31;
			this.txtMail.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 376);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(376, 20);
			this.textBox1.TabIndex = 30;
			this.textBox1.Text = "textBox1";
			// 
			// btnEnregMed
			// 
			this.btnEnregMed.Location = new System.Drawing.Point(184, 344);
			this.btnEnregMed.Name = "btnEnregMed";
			this.btnEnregMed.TabIndex = 29;
			this.btnEnregMed.Text = "Enregistrer";
			this.btnEnregMed.Click += new System.EventHandler(this.btnEnregMed_Click);
			// 
			// txtMobilMed
			// 
			this.txtMobilMed.Location = new System.Drawing.Point(224, 248);
			this.txtMobilMed.Name = "txtMobilMed";
			this.txtMobilMed.TabIndex = 28;
			this.txtMobilMed.Text = "";
			// 
			// txtSpeMed
			// 
			this.txtSpeMed.Location = new System.Drawing.Point(224, 216);
			this.txtSpeMed.Name = "txtSpeMed";
			this.txtSpeMed.TabIndex = 27;
			this.txtSpeMed.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(88, 240);
			this.label15.Name = "label15";
			this.label15.TabIndex = 26;
			this.label15.Text = "Mobile";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(96, 208);
			this.label14.Name = "label14";
			this.label14.TabIndex = 25;
			this.label14.Text = "Spécialité";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(98, 41);
			this.label7.Name = "label7";
			this.label7.TabIndex = 24;
			this.label7.Text = "Prenom";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(98, 81);
			this.label6.Name = "label6";
			this.label6.TabIndex = 23;
			this.label6.Text = "Adresse";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(98, 113);
			this.label5.Name = "label5";
			this.label5.TabIndex = 22;
			this.label5.Text = "Code postal";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(90, 145);
			this.label4.Name = "label4";
			this.label4.TabIndex = 21;
			this.label4.Text = "Ville";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(90, 177);
			this.label3.Name = "label3";
			this.label3.TabIndex = 20;
			this.label3.Text = "Telephone";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(98, 9);
			this.label2.Name = "label2";
			this.label2.TabIndex = 19;
			this.label2.Text = "Nom";
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(226, 185);
			this.txtTel.Name = "txtTel";
			this.txtTel.TabIndex = 18;
			this.txtTel.Text = "";
			// 
			// txtVille
			// 
			this.txtVille.Location = new System.Drawing.Point(226, 145);
			this.txtVille.Name = "txtVille";
			this.txtVille.TabIndex = 17;
			this.txtVille.Text = "";
			// 
			// txtCodePostal
			// 
			this.txtCodePostal.Location = new System.Drawing.Point(226, 114);
			this.txtCodePostal.Name = "txtCodePostal";
			this.txtCodePostal.TabIndex = 16;
			this.txtCodePostal.Text = "";
			// 
			// txtAdMed
			// 
			this.txtAdMed.Location = new System.Drawing.Point(226, 81);
			this.txtAdMed.Name = "txtAdMed";
			this.txtAdMed.TabIndex = 15;
			this.txtAdMed.Text = "";
			// 
			// txtPrenomMed
			// 
			this.txtPrenomMed.Location = new System.Drawing.Point(226, 41);
			this.txtPrenomMed.Name = "txtPrenomMed";
			this.txtPrenomMed.TabIndex = 14;
			this.txtPrenomMed.Text = "";
			// 
			// txtNomMed
			// 
			this.txtNomMed.Location = new System.Drawing.Point(226, 9);
			this.txtNomMed.Name = "txtNomMed";
			this.txtNomMed.TabIndex = 13;
			this.txtNomMed.Text = "";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.label19);
			this.tabPage2.Controls.Add(this.txtPwdSec);
			this.tabPage2.Controls.Add(this.label20);
			this.tabPage2.Controls.Add(this.txtMailSec);
			this.tabPage2.Controls.Add(this.btnEnregSec);
			this.tabPage2.Controls.Add(this.cmbContratSec);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.txtTelSec);
			this.tabPage2.Controls.Add(this.txtVilleSec);
			this.tabPage2.Controls.Add(this.txtCpSec);
			this.tabPage2.Controls.Add(this.txtAdSec);
			this.tabPage2.Controls.Add(this.txtPrenomSec);
			this.tabPage2.Controls.Add(this.txtNomSec);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(416, 414);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Secretaire";
			// 
			// btnEnregSec
			// 
			this.btnEnregSec.Location = new System.Drawing.Point(184, 368);
			this.btnEnregSec.Name = "btnEnregSec";
			this.btnEnregSec.TabIndex = 40;
			this.btnEnregSec.Text = "Enregistrer";
			this.btnEnregSec.Click += new System.EventHandler(this.btnEnregSec_Click);
			// 
			// cmbContratSec
			// 
			this.cmbContratSec.Items.AddRange(new object[] {
															   "CDD",
															   "CDI"});
			this.cmbContratSec.Location = new System.Drawing.Point(224, 216);
			this.cmbContratSec.Name = "cmbContratSec";
			this.cmbContratSec.Size = new System.Drawing.Size(104, 21);
			this.cmbContratSec.TabIndex = 39;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(88, 208);
			this.label16.Name = "label16";
			this.label16.TabIndex = 38;
			this.label16.Text = "TypeContrat";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(98, 41);
			this.label8.Name = "label8";
			this.label8.TabIndex = 36;
			this.label8.Text = "Prenom";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(98, 81);
			this.label9.Name = "label9";
			this.label9.TabIndex = 35;
			this.label9.Text = "Adresse";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(98, 113);
			this.label10.Name = "label10";
			this.label10.TabIndex = 34;
			this.label10.Text = "Code postal";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(90, 145);
			this.label11.Name = "label11";
			this.label11.TabIndex = 33;
			this.label11.Text = "Ville";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(90, 177);
			this.label12.Name = "label12";
			this.label12.TabIndex = 32;
			this.label12.Text = "Telephone";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(98, 9);
			this.label13.Name = "label13";
			this.label13.TabIndex = 31;
			this.label13.Text = "Nom";
			// 
			// txtTelSec
			// 
			this.txtTelSec.Location = new System.Drawing.Point(226, 185);
			this.txtTelSec.Name = "txtTelSec";
			this.txtTelSec.TabIndex = 30;
			this.txtTelSec.Text = "";
			// 
			// txtVilleSec
			// 
			this.txtVilleSec.Location = new System.Drawing.Point(226, 145);
			this.txtVilleSec.Name = "txtVilleSec";
			this.txtVilleSec.TabIndex = 29;
			this.txtVilleSec.Text = "";
			// 
			// txtCpSec
			// 
			this.txtCpSec.Location = new System.Drawing.Point(226, 114);
			this.txtCpSec.Name = "txtCpSec";
			this.txtCpSec.TabIndex = 28;
			this.txtCpSec.Text = "";
			// 
			// txtAdSec
			// 
			this.txtAdSec.Location = new System.Drawing.Point(226, 81);
			this.txtAdSec.Name = "txtAdSec";
			this.txtAdSec.TabIndex = 27;
			this.txtAdSec.Text = "";
			// 
			// txtPrenomSec
			// 
			this.txtPrenomSec.Location = new System.Drawing.Point(226, 41);
			this.txtPrenomSec.Name = "txtPrenomSec";
			this.txtPrenomSec.TabIndex = 26;
			this.txtPrenomSec.Text = "";
			// 
			// txtNomSec
			// 
			this.txtNomSec.Location = new System.Drawing.Point(226, 9);
			this.txtNomSec.Name = "txtNomSec";
			this.txtNomSec.TabIndex = 25;
			this.txtNomSec.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(88, 280);
			this.label19.Name = "label19";
			this.label19.TabIndex = 44;
			this.label19.Text = "mot de passe";
			// 
			// txtPwdSec
			// 
			this.txtPwdSec.Location = new System.Drawing.Point(224, 280);
			this.txtPwdSec.Name = "txtPwdSec";
			this.txtPwdSec.TabIndex = 43;
			this.txtPwdSec.Text = "";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(88, 248);
			this.label20.Name = "label20";
			this.label20.TabIndex = 42;
			this.label20.Text = "Mail";
			// 
			// txtMailSec
			// 
			this.txtMailSec.Location = new System.Drawing.Point(224, 248);
			this.txtMailSec.Name = "txtMailSec";
			this.txtMailSec.TabIndex = 41;
			this.txtMailSec.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(32, 328);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 45;
			this.textBox2.Text = "textBox2";
			// 
			// AdminInterface
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 526);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label1);
			this.Name = "AdminInterface";
			this.Text = "AdminInterface";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnEnregMed_Click(object sender, System.EventArgs e)
		{
			Medecin unMedecin = new Medecin(txtNomMed.Text,txtPrenomMed.Text,txtAdMed.Text,txtCodePostal.Text,txtVille.Text,txtTel.Text,txtSpeMed.Text,txtMobilMed.Text,txtMail.Text,txtMdp.Text);
			textBox1.Text = unMedecin.enregistrer();

		}

		private void btnEnregSec_Click(object sender, System.EventArgs e)
		{
			Secretaire uneSec = new Secretaire(txtNomSec.Text , txtPrenomSec.Text , txtAdSec.Text , txtVille.Text , txtVilleSec.Text , txtTelSec.Text,cmbContratSec.Text , txtPwdSec.Text , txtMailSec.Text);
			textBox2.Text = uneSec.enregistrer();
		}


	}
}
