using System;
using gestionRdv.traitBdd;

namespace gestionRdv
{
	/// <summary>
	/// Description résumée de Patient.
	/// </summary>
	public class Patient : Personne
	{
		String medTrait;

		public Patient() : base()
		{
			//
			// TODO : ajoutez ici la logique du constructeur
			//
		}
		public Patient(String unNom , String unPrenom , String uneAd , String unCp , String uneVille , String unTel , String unMedTrait):base(unNom , unPrenom , uneAd , unCp , uneVille , unTel)
		{
			medTrait = unMedTrait;
		}
		#region "Modificateur & recuperateur"
		public String getMedTrait()
		{
			return medTrait;
		}
		public void setMedTrait(String unMedTrait)
		{
			medTrait = unMedTrait;
		}
		#endregion

		public String enregistrer()
		{
			//on va recuperer le numero du medecin traitant choisi	
			traitBdd.RecupInfoBdd service = new RecupInfoBdd();
			return service.enregistrerPatient(getNom(),getPrenom(),getAd(),getCp(),getVille(),getTel(),getMedTrait());
			
		}

	}
}
