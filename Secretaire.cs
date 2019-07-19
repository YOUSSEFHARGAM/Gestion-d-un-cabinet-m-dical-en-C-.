using System;
using gestionRdv.traitBdd;

namespace gestionRdv
{
	/// <summary>
	/// Description résumée de Secretaire.
	/// </summary>
	public class Secretaire : gestionRdv.Personne 
	{
		private String contrat;
		private String mdp;
		private String mail;

		public Secretaire() : base()
		{
			//
			// TODO : ajoutez ici la logique du constructeur
			//
		}
		public Secretaire(String unNom , String unPrenom , String uneAd , String unCp , String uneVille , String unTel , String unContrat , String unMdp , String unMail):base(unNom , unPrenom , uneAd , unCp , uneVille , unTel) 
		{
			//appel du constructeur de la classe mere
			contrat = unContrat;
			mail = unMail;
			mdp = unMdp;
		}

		#region "modificateur recuperateur"
		public void setContrat(String unContrat)
		{
			contrat = unContrat;
		}
		public String getContrat()
		{
			return contrat;
		}
		public String getMail()
		{
			return mail;
		}
		public void setMail(String unContrat)
		{
			contrat = unContrat;
		}
		public String getPwd()
		{
			return mdp;
		}
		public void setPwd(String unPwd)
		{
			mdp = unPwd;
		}

		#endregion 
		
		#region "Methodes"

		public String enregistrer()
		{
			RecupInfoBdd  unService;
			unService = new RecupInfoBdd();

			return (String) unService.enregistrerSecretaire(getNom(),getPrenom(),getAd(),getCp(),getVille(),getTel(),getContrat(),getMail(),getPwd());


		
		}

		#endregion
	}
}
