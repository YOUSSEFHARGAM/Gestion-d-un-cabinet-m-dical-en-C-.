using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using gestionRdv;

namespace gestionRdv
{
	/// <summary>
	/// Description résumée de NouveauPatient.
	/// </summary>
	public class NouveauPatient : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.TextBox txtPrenom;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtVille;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbMedecin;
		private System.Windows.Forms.Button btnEnreg;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox textBox1;
		
		private traitBdd.RecupInfoBdd service = new traitBdd.RecupInfoBdd();

		public NouveauPatient()
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
			this.txtNom = new System.Windows.Forms.TextBox();
			this.txtPrenom = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCp = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtVille = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbMedecin = new System.Windows.Forms.ComboBox();
			this.btnEnreg = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(80, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(496, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ajouter un nouveau patient";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(216, 48);
			this.txtNom.Name = "txtNom";
			this.txtNom.TabIndex = 1;
			this.txtNom.Text = "";
			// 
			// txtPrenom
			// 
			this.txtPrenom.Location = new System.Drawing.Point(216, 80);
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.TabIndex = 2;
			this.txtPrenom.Text = "";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(216, 120);
			this.txtAd.Name = "txtAd";
			this.txtAd.TabIndex = 3;
			this.txtAd.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(80, 56);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "Nom";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(80, 88);
			this.label3.Name = "label3";
			this.label3.TabIndex = 5;
			this.label3.Text = "Prenom";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(80, 120);
			this.label4.Name = "label4";
			this.label4.TabIndex = 6;
			this.label4.Text = "Adresse";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(80, 152);
			this.label5.Name = "label5";
			this.label5.TabIndex = 8;
			this.label5.Text = "code postal";
			// 
			// txtCp
			// 
			this.txtCp.Location = new System.Drawing.Point(216, 152);
			this.txtCp.Name = "txtCp";
			this.txtCp.TabIndex = 7;
			this.txtCp.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(80, 184);
			this.label6.Name = "label6";
			this.label6.TabIndex = 10;
			this.label6.Text = "Ville";
			// 
			// txtVille
			// 
			this.txtVille.Location = new System.Drawing.Point(216, 184);
			this.txtVille.Name = "txtVille";
			this.txtVille.TabIndex = 9;
			this.txtVille.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(80, 216);
			this.label7.Name = "label7";
			this.label7.TabIndex = 12;
			this.label7.Text = "telephone";
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(216, 216);
			this.txtTel.Name = "txtTel";
			this.txtTel.TabIndex = 11;
			this.txtTel.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(72, 248);
			this.label8.Name = "label8";
			this.label8.TabIndex = 13;
			this.label8.Text = "Medecin traitant";
			// 
			// cmbMedecin
			// 
			this.cmbMedecin.Location = new System.Drawing.Point(208, 248);
			this.cmbMedecin.Name = "cmbMedecin";
			this.cmbMedecin.Size = new System.Drawing.Size(121, 21);
			this.cmbMedecin.TabIndex = 14;
			// 
			// btnEnreg
			// 
			this.btnEnreg.Location = new System.Drawing.Point(272, 296);
			this.btnEnreg.Name = "btnEnreg";
			this.btnEnreg.Size = new System.Drawing.Size(144, 23);
			this.btnEnreg.TabIndex = 15;
			this.btnEnreg.Text = "Enregistrer";
			this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 288);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(232, 20);
			this.textBox1.TabIndex = 16;
			this.textBox1.Text = "textBox1";
			// 
			// NouveauPatient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(616, 341);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnEnreg);
			this.Controls.Add(this.cmbMedecin);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtVille);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCp);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.txtPrenom);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label1);
			this.Name = "NouveauPatient";
			this.Text = "NouveauPatient";
			this.Load += new System.EventHandler(this.NouveauPatient_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void NouveauPatient_Load(object sender, System.EventArgs e)
		{
			int i;
			for(i=0;i<= service.getAllMed().Tables[0].Rows.Count-1;i++)
			{
				cmbMedecin.Items.Add(service.getAllMed().Tables[0].Rows[i][1].ToString());
			}
		}

		private void btnEnreg_Click(object sender, System.EventArgs e)
		{
			//recuperation du numero du medecin traitant
			Patient unPatient = new Patient(txtNom.Text,txtPrenom.Text,txtAd.Text,txtCp.Text,txtVille.Text,txtTel.Text,cmbMedecin.Text);
			textBox1.Text = unPatient.enregistrer();
			ApplicationGestionRdv maFrm;
			maFrm = new ApplicationGestionRdv();
			this.Close();
		}
	}
}
