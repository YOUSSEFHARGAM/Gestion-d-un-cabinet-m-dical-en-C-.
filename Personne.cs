using System;

namespace gestionRdv
{
	/// <summary>
	/// Description résumée de Personne.
	/// </summary>
	public class Personne
	{
		private String nom;
		private String prenom;
		private String ad;
		private String cp;
		private String ville;
		private String tel;

		public Personne()
		{
			//
			// TODO : ajoutez ici la logique du constructeur
			//
		}
		public Personne(String unNom )
		{
			//
			// TODO : ajoutez ici la logique du constructeur
			//
		}
		public Personne(String unNom , String unPrenom , String uneAd  , String unCp , String uneVille , String unTel)
		{
			nom = unNom;
			prenom = unPrenom;
			ad = uneAd;
			cp = unCp;
			ville = uneVille;
			tel = unTel;
		}

		#region "modificateur & recuperateur"
		public void setNom(String unNom)
		{
			nom = unNom;
		}
		public String getNom()
		{
			return nom;
		}
		public void setPrenom(String unPrenom)
		{
			prenom = unPrenom;
		}
		public String getPrenom()
		{
			return prenom;
		}
		public void setAd(String uneAd)
		{
			ad = uneAd;
		}
		public String getAd()
		{
			return ad;
		}
		public void setCp(String unCp)
		{
			cp = unCp;
		}
		public String getCp()
		{
			return cp;
		}
		public void setVille(String uneVille)
		{
			ville = uneVille;
		}
		public String getVille()
		{
			return ville;
		}
		public void setTel(String unTel)
		{
			tel = unTel;
		}
		public String getTel()
		{
			return tel;
		}


		#endregion
	}
}
