using System;
using gestionRdv.traitBdd;

namespace gestionRdv
{
	/// <summary>
	/// Description résumée de Medecin.
	/// </summary>
	public class Medecin :gestionRdv.Personne 
	{
		private String spe;
		private String mobile;
		private String mail;
		private String pwd;

		gestionRdv.traitBdd.RecupInfoBdd  service;

		public Medecin() : base()
		{
			
			//
			// TODO : ajoutez ici la logique du constructeur
			//
		}
		public Medecin(String unNom , String unPrenom , String uneAd , String unCp , String uneVille , String unTel , String uneSpe , String unMob,String unMail,String unMdp):base(unNom , unPrenom , uneAd , unCp , uneVille , unTel) 
		{
			//appel du constructeur de la classe mere
			spe = uneSpe;
			mobile = unMob;
			mail=unMail;
			pwd=unMdp;
		}
		#region "Modificateur & recuperateur"
		public void setSpe(String uneSpe)
		{
			spe = uneSpe;
		}
		public String getSpe()
		{
			return spe;
		}
		public String getMobil()
		{
			return mobile;
		}
		public void setMobil(String unMob)
		{
			mobile = unMob;
		}
		public String getPwd()
		{
			return pwd;
		}
		public void setPwd(String unPwd)
		{
			pwd=unPwd;
		}
		public String getMail()
		{
			return mail;
		}
		#endregion 

		#region "Methodes"

		public String enregistrer()
		{
			service = new RecupInfoBdd();
			return (String) service.enregistrerMedecin(getNom().ToString(),getPrenom().ToString(),getAd().ToString(),getCp().ToString(),getVille().ToString(),getTel().ToString(),getSpe().ToString(),getMobil().ToString(),getMail().ToString(),getPwd().ToString());		
		}


		#endregion


	}
}
