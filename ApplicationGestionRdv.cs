using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data; 


namespace gestionRdv
{
	/// <summary>
	/// Description résumée de ApplicationGestionRdv.
	/// </summary>
	public class ApplicationGestionRdv : System.Windows.Forms.Form
	{
		traitBdd.RecupInfoBdd   service;

		int numMed;
		int numPat;
		DataSet rdvEnreg;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListView lstRdvExist;
		private System.Windows.Forms.ColumnHeader Patient;
		private System.Windows.Forms.ColumnHeader Heure;
		private System.Windows.Forms.Label lstRdv;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbMin;
		private System.Windows.Forms.ComboBox cmbHeur;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEnreg;
		private System.Windows.Forms.MonthCalendar calendrier;
		private System.Windows.Forms.Button btnNewPat;
		private System.Windows.Forms.ComboBox cmbPatien;
		private System.Windows.Forms.ComboBox cmbMed;
		private System.Windows.Forms.TabControl tabControl1;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ApplicationGestionRdv()
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lstRdvExist = new System.Windows.Forms.ListView();
			this.Patient = new System.Windows.Forms.ColumnHeader();
			this.Heure = new System.Windows.Forms.ColumnHeader();
			this.lstRdv = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbMin = new System.Windows.Forms.ComboBox();
			this.cmbHeur = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnEnreg = new System.Windows.Forms.Button();
			this.calendrier = new System.Windows.Forms.MonthCalendar();
			this.btnNewPat = new System.Windows.Forms.Button();
			this.cmbPatien = new System.Windows.Forms.ComboBox();
			this.cmbMed = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lstRdvExist);
			this.tabPage1.Controls.Add(this.lstRdv);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.cmbMin);
			this.tabPage1.Controls.Add(this.cmbHeur);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.btnEnreg);
			this.tabPage1.Controls.Add(this.calendrier);
			this.tabPage1.Controls.Add(this.btnNewPat);
			this.tabPage1.Controls.Add(this.cmbPatien);
			this.tabPage1.Controls.Add(this.cmbMed);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(648, 427);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Rendez vous";
			// 
			// lstRdvExist
			// 
			this.lstRdvExist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.Patient,
																						  this.Heure});
			this.lstRdvExist.Location = new System.Drawing.Point(48, 288);
			this.lstRdvExist.Name = "lstRdvExist";
			this.lstRdvExist.Size = new System.Drawing.Size(568, 128);
			this.lstRdvExist.TabIndex = 13;
			this.lstRdvExist.View = System.Windows.Forms.View.Details;
			// 
			// Patient
			// 
			this.Patient.Text = "Patient";
			this.Patient.Width = 304;
			// 
			// Heure
			// 
			this.Heure.Text = "Heure";
			this.Heure.Width = 172;
			// 
			// lstRdv
			// 
			this.lstRdv.Location = new System.Drawing.Point(168, 240);
			this.lstRdv.Name = "lstRdv";
			this.lstRdv.Size = new System.Drawing.Size(336, 32);
			this.lstRdv.TabIndex = 12;
			this.lstRdv.Text = "Planning des rendez-vous";
			this.lstRdv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(280, 72);
			this.label4.Name = "label4";
			this.label4.TabIndex = 11;
			this.label4.Text = "Medecin :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(280, 40);
			this.label3.Name = "label3";
			this.label3.TabIndex = 10;
			this.label3.Text = "Patient :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(128, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = ":    min";
			// 
			// cmbMin
			// 
			this.cmbMin.ItemHeight = 13;
			this.cmbMin.Items.AddRange(new object[] {
														"00",
														"15",
														"30",
														"45"});
			this.cmbMin.Location = new System.Drawing.Point(176, 184);
			this.cmbMin.Name = "cmbMin";
			this.cmbMin.Size = new System.Drawing.Size(48, 21);
			this.cmbMin.TabIndex = 8;
			// 
			// cmbHeur
			// 
			this.cmbHeur.ItemHeight = 13;
			this.cmbHeur.Items.AddRange(new object[] {
														 "8",
														 "9",
														 "10",
														 "11",
														 "12",
														 "13",
														 "14",
														 "15",
														 "16",
														 "17",
														 "18",
														 "19"});
			this.cmbHeur.Location = new System.Drawing.Point(72, 184);
			this.cmbHeur.Name = "cmbHeur";
			this.cmbHeur.Size = new System.Drawing.Size(48, 21);
			this.cmbHeur.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "heure";
			// 
			// btnEnreg
			// 
			this.btnEnreg.Location = new System.Drawing.Point(376, 144);
			this.btnEnreg.Name = "btnEnreg";
			this.btnEnreg.Size = new System.Drawing.Size(208, 23);
			this.btnEnreg.TabIndex = 5;
			this.btnEnreg.Text = "Enregistrer le rendez vous";
			this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
			// 
			// calendrier
			// 
			this.calendrier.Location = new System.Drawing.Point(32, 16);
			this.calendrier.Name = "calendrier";
			this.calendrier.TabIndex = 4;
			this.calendrier.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendrier_DateChanged);
			// 
			// btnNewPat
			// 
			this.btnNewPat.Location = new System.Drawing.Point(528, 40);
			this.btnNewPat.Name = "btnNewPat";
			this.btnNewPat.TabIndex = 3;
			this.btnNewPat.Text = "nouveau";
			this.btnNewPat.Click += new System.EventHandler(this.btnNewPat_Click);
			// 
			// cmbPatien
			// 
			this.cmbPatien.ItemHeight = 13;
			this.cmbPatien.Location = new System.Drawing.Point(392, 40);
			this.cmbPatien.Name = "cmbPatien";
			this.cmbPatien.Size = new System.Drawing.Size(121, 21);
			this.cmbPatien.TabIndex = 2;
			// 
			// cmbMed
			// 
			this.cmbMed.ItemHeight = 13;
			this.cmbMed.Location = new System.Drawing.Point(392, 72);
			this.cmbMed.Name = "cmbMed";
			this.cmbMed.Size = new System.Drawing.Size(121, 21);
			this.cmbMed.TabIndex = 1;
			this.cmbMed.SelectedIndexChanged += new System.EventHandler(this.cmbMed_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.ItemSize = new System.Drawing.Size(75, 21);
			this.tabControl1.Location = new System.Drawing.Point(16, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(656, 456);
			this.tabControl1.TabIndex = 0;
			// 
			// ApplicationGestionRdv
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 502);
			this.Controls.Add(this.tabControl1);
			this.Name = "ApplicationGestionRdv";
			this.Text = "ApplicationGestionRdv";
			this.Load += new System.EventHandler(this.ApplicationGestionRdv_Load);
			this.tabPage1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void ApplicationGestionRdv_Load(object sender, System.EventArgs e)
		{

			
			//on va mettre a jour les comboBox grace au dataset que le webService a renvoyer :)
			int i;
			cmbHeur.SelectedIndex = 0;
			cmbMin.SelectedIndex=0;
			service = new traitBdd.RecupInfoBdd();

			for(i=0;i<=service.getAllMed().Tables[0].Rows.Count -1;i++)
			{
				cmbMed.Items.Add(service.getAllMed().Tables[0].Rows[i][1].ToString());
			}
			for(i=0;i<=service.gelAllPat().Tables[0].Rows.Count -1;i++)
			{
				cmbPatien.Items.Add(service.gelAllPat().Tables[0].Rows[i][1].ToString());
			}

		}

		private void btnNewPat_Click(object sender, System.EventArgs e)
		{
			NouveauPatient maForm = new NouveauPatient();
			maForm.Show();
		}

		private void btnEnreg_Click(object sender, System.EventArgs e)
		{
			//on va enregistrer le rendez vous et passé en parametre les info k on veux enreg au webserv
			int i;


			Boolean rep;
			rep=false;
			i=0;


			while(i<= service.getAllMed().Tables[0].Rows.Count -1 && (!rep))
			{
				if((String) service.getAllMed().Tables[0].Rows[i][1] == cmbMed.Text)
				{
					rep=true;
				}
				else
				{
					i++;
				}
			}
			if(rep)
			{
				numMed=(int)service.getAllMed().Tables[0].Rows[i][0];
			}
			

			rep=false;
			i=0;

			//de meme pour les medecin
			while(i<= service.gelAllPat().Tables[0].Rows.Count -1 && (!rep))
			{
				if((string)service.gelAllPat().Tables[0].Rows[i][1]==cmbPatien.Text)
				{
					rep=true;
				}
				else
				{
					i++;
				}
			}
			if(rep)
			{
				numPat = (int) service.gelAllPat().Tables[0].Rows[i][0];
			}

			//recuperation de la date et heure 
			DateTime  date;
			date = new DateTime(calendrier.SelectionStart.Year,calendrier.SelectionStart.Month,calendrier.SelectionStart.Day,int.Parse(cmbHeur.Text),int.Parse(cmbMin.Text),00);
			
			String query = "insert into rdv (nummed , numpat , laDate) values ("+numMed+","+numPat+",'"+date+"')";
			MessageBox.Show(service.addRdv(query));
			affichLstRdvEnreg();

			
		}

		private void calendrier_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			//lorsque l'on change la date du calendrier on met la liste des rendez vous deja pris a jour 
			affichLstRdvEnreg();
		}

		private void cmbMed_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			affichLstRdvEnreg();
		}
		private void affichLstRdvEnreg()
		{
			int i;
			rdvEnreg = service.getAllRdvFix(calendrier.SelectionStart,cmbMed.Text);
			lstRdvExist.Clear();
			lstRdvExist.Columns.Add("patient",200,System.Windows.Forms.HorizontalAlignment.Center);
			lstRdvExist.Columns.Add("Heure",200,System.Windows.Forms.HorizontalAlignment.Center);
			for(i=0;i<=rdvEnreg.Tables[0].Rows.Count -1;i++)
			{
				lstRdvExist.Items.Add(rdvEnreg.Tables[0].Rows[i][0].ToString()).SubItems.Add(rdvEnreg.Tables[0].Rows[i][1].ToString());
			}
		}


	}
}
