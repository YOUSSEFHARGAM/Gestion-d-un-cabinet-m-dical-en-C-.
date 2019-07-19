using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using gestionRdv.traitBdd;
using System.Data;

namespace gestionRdv
{
	/// <summary>
	/// Description résumée de RdvMedecin.
	/// </summary>
	public class RdvMedecin : System.Windows.Forms.Form
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		/// 

		string nomMed;
		RecupInfoBdd service;
		private System.Windows.Forms.MonthCalendar calendrier;
		private System.Windows.Forms.ListView lstRendezVous;
		private System.Windows.Forms.Label lblInfo;
		private System.ComponentModel.Container components = null;

		public RdvMedecin()
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			//
			// TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
			//
		}
		public RdvMedecin(String unNom)
		{
			InitializeComponent();
			nomMed = unNom;
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
			this.calendrier = new System.Windows.Forms.MonthCalendar();
			this.lstRendezVous = new System.Windows.Forms.ListView();
			this.lblInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// calendrier
			// 
			this.calendrier.Location = new System.Drawing.Point(40, 160);
			this.calendrier.Name = "calendrier";
			this.calendrier.TabIndex = 0;
			this.calendrier.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendrier_DateChanged);
			// 
			// lstRendezVous
			// 
			this.lstRendezVous.Location = new System.Drawing.Point(312, 160);
			this.lstRendezVous.Name = "lstRendezVous";
			this.lstRendezVous.Size = new System.Drawing.Size(360, 192);
			this.lstRendezVous.TabIndex = 1;
			this.lstRendezVous.View = System.Windows.Forms.View.Details;
			// 
			// lblInfo
			// 
			this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(48, 16);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(640, 88);
			this.lblInfo.TabIndex = 2;
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RdvMedecin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(720, 493);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.lstRendezVous);
			this.Controls.Add(this.calendrier);
			this.Name = "RdvMedecin";
			this.Text = "RdvMedecin";
			this.Load += new System.EventHandler(this.RdvMedecin_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void RdvMedecin_Load(object sender, System.EventArgs e)
		{
		
			
			lblInfo.Text = "Bonjour Mr "+nomMed;

			service = new RecupInfoBdd();
			affichRdv();

		}
		private void affichRdv()
		{
			
			lstRendezVous.Clear();
			
			DataSet monDs;
			monDs=service.getAllRdvFix(calendrier.SelectionStart,nomMed);
			//parcour du dataset et affichage dans la listeView
			

			int i;
			
			lstRendezVous.Columns.Add("Nom Patient",90,System.Windows.Forms.HorizontalAlignment.Center);
			lstRendezVous.Columns.Add("Heure",190,System.Windows.Forms.HorizontalAlignment.Center);

			for(i=0;i<=monDs.Tables[0].Rows.Count -1;i++)
			{
				lstRendezVous.Items.Add(monDs.Tables[0].Rows[i][0].ToString()).SubItems.Add(monDs.Tables[0].Rows[i][1].ToString());
			}
		}

		private void calendrier_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			affichRdv();
		}
	}
}
