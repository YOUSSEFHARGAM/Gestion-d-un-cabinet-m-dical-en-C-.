using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using gestionRdv.log;

namespace gestionRdv
{
	/// <summary>
	/// Description résumée de Form1.
	/// </summary>
	/// 
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Button cmdEntrer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label result;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		/// 
		log.Log test;
		private System.ComponentModel.Container components = null;

		public Form1()
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
				if (components != null) 
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
			this.txtNom = new System.Windows.Forms.TextBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.cmdEntrer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(168, 40);
			this.txtNom.Name = "txtNom";
			this.txtNom.TabIndex = 0;
			this.txtNom.Text = "";
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(168, 80);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.TabIndex = 1;
			this.txtPwd.Text = "";
			// 
			// cmdEntrer
			// 
			this.cmdEntrer.Location = new System.Drawing.Point(120, 120);
			this.cmdEntrer.Name = "cmdEntrer";
			this.cmdEntrer.TabIndex = 2;
			this.cmdEntrer.Text = "utiliser";
			this.cmdEntrer.Click += new System.EventHandler(this.cmdEntrer_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 48);
			this.label1.Name = "label1";
			this.label1.TabIndex = 3;
			this.label1.Text = "Login : ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "Mot de passe:";
			// 
			// result
			// 
			this.result.Location = new System.Drawing.Point(48, 8);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(232, 23);
			this.result.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 166);
			this.Controls.Add(this.result);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdEntrer);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.txtNom);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void cmdEntrer_Click(object sender, System.EventArgs e)
		{
			
			if(txtNom.Text=="admin" && txtPwd.Text=="admin")
			{
				AdminInterface maForm;
				maForm = new AdminInterface();
				maForm.Show();
				
			}
			else
			{
				
				
				test = new log.Log();


				try
				{				
					if(test.testLog(txtNom.Text,txtPwd.Text))
					{
						//l'authentification est bonne on redirectionne vers le bon frm
						if(test.testType(txtNom.Text,txtPwd.Text)=="medecin")
						{
							
							//ouverture du formulaire pour le medecin
							RdvMedecin maForm;
							maForm = new RdvMedecin(test.getNomMed(txtNom.Text,txtPwd.Text));
							maForm.Show();
						}
						else
						{
							ApplicationGestionRdv maForm;
							maForm = new ApplicationGestionRdv();
							//this.Close();
							maForm.Show();
						}
						
						
					}
					else
					{
						this.result.Text = "Mauvaise authentificaiton"; 
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}


	}
}
